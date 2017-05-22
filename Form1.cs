using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjetGestionBudjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirType();
            initialisationCheckBoxClient();
        }

        private void remplirType()
        {
            OleDbConnection connexion = new OleDbConnection();
            try
            {
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Desktop\ProjetGestionBudget\ProjetGestionBudjet\ProjetGestionBudjet\budget1.mdb";
                connexion.Open();
                OleDbDataAdapter daType = new OleDbDataAdapter(@"SELECT libType FROM TypeTransaction", connexion);
                DataSet dsType = new DataSet();
                daType.Fill(dsType);

                foreach (DataRow ligne in dsType.Tables[0].Rows)
                {
                    comboBoxType.Items.Add(ligne[0]);
                }
            }







            catch (OleDbException)
            {
                MessageBox.Show("Requete erroné");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion");
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }


            }
       
         } // On remplit le comboBox Type


        private void initialisationCheckBoxClient() // On ajoute les checkBox des clients
        {
            OleDbConnection connexion = new OleDbConnection();
            try
            {
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Desktop\ProjetGestionBudget\ProjetGestionBudjet\ProjetGestionBudjet\budget1.mdb";
                connexion.Open();
                OleDbDataAdapter daNbClient = new OleDbDataAdapter(@"SELECT nomPersonne, pnPersonne from Personne", connexion);
                DataSet dsNbClient = new DataSet();
                daNbClient.Fill(dsNbClient);
                daNbClient.Dispose();

                for (int i = 0; i < dsNbClient.Tables[0].Rows.Count; i++)
                {
                    CheckBox checkBox2 = new CheckBox();
                    checkBox2.AutoSize = true;
                    checkBox2.Location = new System.Drawing.Point(397, 57+40*i);
                    checkBox2.Name = "checkB" +dsNbClient.Tables[0].Rows[i].ItemArray[0].ToString() + dsNbClient.Tables[0].Rows[i].ItemArray[1].ToString();
                    checkBox2.Size = new System.Drawing.Size(80, 17);
                    checkBox2.TabIndex = 13;
                    checkBox2.UseVisualStyleBackColor = true;
                    checkBox2.Text = dsNbClient.Tables[0].Rows[i].ItemArray[0].ToString() + " " + dsNbClient.Tables[0].Rows[i].ItemArray[1].ToString();
                    tabPage2.Controls.Add(checkBox2);
                }
                
              
                
                

                
            }
            catch (OleDbException)
            {
                MessageBox.Show("Requete erroné");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Erreur de connexion");
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttAjoutType_Click(object sender, EventArgs e)
        {
            Form2 modifierType = new Form2();
           
            modifierType.ShowDialog();
            







          

        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
             
        
            comboBoxType.Items.Clear();
            OleDbConnection connexion = new OleDbConnection();

            connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Desktop\ProjetGestionBudget\ProjetGestionBudjet\ProjetGestionBudjet\budget1.mdb";
            connexion.Open();
            OleDbDataAdapter daType = new OleDbDataAdapter(@"SELECT libType FROM TypeTransaction", connexion);
            DataSet dsType = new DataSet();
            daType.Fill(dsType);

            foreach (DataRow ligne in dsType.Tables[0].Rows)
            {
                comboBoxType.Items.Add(ligne[0]);
            }

            connexion.Close();

        }

        private void btnAjouterTrans_Click(object sender, EventArgs e)
        {
            ajoutTransaction();
        }
        private void ajoutTransaction()
        {
            String recette = "False";
            string percu = "False";
            if (comboBoxType.Text == "")
            {
                MessageBox.Show("Un probleme est survenue");
            }
            else
            {
                OleDbConnection connexion = new OleDbConnection();
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Desktop\ProjetGestionBudget\ProjetGestionBudjet\ProjetGestionBudjet\budget1.mdb";
                connexion.Open();

                OleDbCommand typeCommande = new OleDbCommand("Select codeType from TypeTransaction WHERE libType = " + '"' + comboBoxType.Text + '"', connexion);
                OleDbCommand numCommande = new OleDbCommand("SELECT count(codeTransaction) from [Transaction]",connexion);
                MessageBox.Show(numCommande.ExecuteScalar().ToString());
                
                if (checkRecette.Checked == true)
                {
                    recette = "True";
                }
                else
                {
                    recette = "False";
                }
                //////////////////////////:
                if (checkPercu.Checked == true)
                {
                    percu = "True";
                }
                else
                {
                    percu = "False";
                }
                
                int newCodeTransaction = int.Parse(numCommande.ExecuteScalar().ToString()) + 1;
                int newCodeType = int.Parse(typeCommande.ExecuteScalar().ToString());
                int newPrix = int.Parse(montantText.Text);
                string newDescription = descriptionText.Text;
                string newDate = dateTransaction.Value.ToShortDateString();
                MessageBox.Show(newDate);
                String commande = "Insert into [Transaction] (codeTransaction,dateTransaction,description,montant,recetteON,percuON,type)  VALUES (" + newCodeTransaction + ",#" + dateTransaction.Value.ToString() +"#," + '"'+descriptionText.Text+ '"' + "," + int.Parse(montantText.Text) + ","+ recette +"," + percu +","+ newCodeType+")";
                OleDbCommand insert = new OleDbCommand(commande, connexion);
                insert.ExecuteNonQuery();
                //  MessageBox.Show("Le type " + textBox1.Text + " a été ajoutée");
                connexion.Close();
            }
           
        }
    }
    
    
}
// test test 2
