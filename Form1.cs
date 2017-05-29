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

        string provider2 = "";
        string provider = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Desktop\ProjetGestionBudget\ProjetGestionBudjet\ProjetGestionBudjet\budget1.mdb";


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirType();
            chargerCbxSupprimerPersonne();
            initialisationCheckBoxClient();
            remplirGridModifier();
            remplirGridSupprimer();
            actualiserInfosTypes();
            // Utilisation des procedure au chargement du formulaire
        }

        private void remplirType() // Procedure de remplissage/Actualisation de la combobox de type
        {
            comboBoxType.Items.Clear();
            OleDbConnection connexion = new OleDbConnection();
            try
            {
                connexion.ConnectionString = provider;
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

        }


        private void initialisationCheckBoxClient() // On ajoute les checkBox de chaque personnes
        {
            OleDbConnection connexion = new OleDbConnection();
            try
            {


                connexion.ConnectionString = provider;
                connexion.Open();
                OleDbDataAdapter daNbClient = new OleDbDataAdapter(@"SELECT nomPersonne, pnPersonne from Personne", connexion);
                DataSet dsNbClient = new DataSet();
                daNbClient.Fill(dsNbClient);
                daNbClient.Dispose();


                for (int i = 0; i < dsNbClient.Tables[0].Rows.Count; i++)
                {

                    CheckBox checkBox2 = new CheckBox();
                    checkBox2.AutoSize = true;
                    checkBox2.Location = new System.Drawing.Point(20, 20 + 35 * i);
                    checkBox2.Name = dsNbClient.Tables[0].Rows[i].ItemArray[0].ToString() + dsNbClient.Tables[0].Rows[i].ItemArray[1].ToString();
                    checkBox2.Size = new System.Drawing.Size(80, 17);
                    checkBox2.TabIndex = 13;
                    checkBox2.UseVisualStyleBackColor = true;
                    checkBox2.Text = dsNbClient.Tables[0].Rows[i].ItemArray[0].ToString() + " " + dsNbClient.Tables[0].Rows[i].ItemArray[1].ToString();
                    groupBoxBeni.Controls.Add(checkBox2);

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



        private void buttAjoutType_Click(object sender, EventArgs e)//bouton pour ouvrir le formulaire d'edition de type
        {
            Form2 modifierType = new Form2();

            modifierType.ShowDialog();


        }

        private void btnActualiser_Click(object sender, EventArgs e)//bouton pour actualiser la combobox de type
        {
            remplirType();
            actualiserInfosTypes();

        }

        private void btnAjouterTrans_Click(object sender, EventArgs e)// bouton d'ajout de transaction 
        {
            ajoutTransaction();
        }
        private void ajoutTransaction()// procedure d'ajout de transaction 
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
                connexion.ConnectionString = provider;
                connexion.Open();

                OleDbCommand typeCommande = new OleDbCommand("Select codeType from TypeTransaction WHERE libType = " + '"' + comboBoxType.Text + '"', connexion);
                OleDbCommand numCommande = new OleDbCommand("SELECT count(codeTransaction) from [Transaction]", connexion);
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
                String commande = "Insert into [Transaction] (codeTransaction,dateTransaction,description,montant,recetteON,percuON,type)  VALUES (" + newCodeTransaction + ",#" + newDate + "#," + '"' + descriptionText.Text + '"' + "," + int.Parse(montantText.Text) + "," + recette + "," + percu + "," + newCodeType + ")";
                OleDbCommand insert = new OleDbCommand(commande, connexion);
                insert.ExecuteNonQuery();
                //  MessageBox.Show("Le type " + textBox1.Text + " a été ajoutée");
                connexion.Close();
            }

        }

        private void btnAjoutperson_Click(object sender, EventArgs e)
        {
            ajoutPersonne();
            chargerCbxSupprimerPersonne();
        }

        public void ajoutPersonne()
        {
            ClearPanels();
            
            if (newNomTxt.Text == "" || newPrenomTxt.Text == "")
            {
                MessageBox.Show("Aucune valeur à ajouter ");
            }
            else
            {
             
                OleDbConnection connexion = new OleDbConnection();
                connexion.ConnectionString = provider;
                connexion.Open();

                OleDbCommand codePerso = new OleDbCommand("Select max(codePersonne) from Personne", connexion);
                int newCodePerso = int.Parse(codePerso.ExecuteScalar().ToString());

                newCodePerso++;
                OleDbCommand ajout = new OleDbCommand("INSERT INTO [Personne] (codePersonne,nomPersonne,pnPersonne,telMobile) VALUES (" + newCodePerso + ",'" + newNomTxt.Text + "','" + newPrenomTxt.Text + "',null )", connexion);
                ajout.ExecuteNonQuery();

               
                connexion.Close();

                
            }
            initialisationCheckBoxClient();
        }

        public void ClearPanels()//Nettoyage du groupBox 
        {
            int c = groupBoxBeni.Controls.Count;

            for (int i = c - 1; i >= 0; i--)
                groupBoxBeni.Controls.Remove(groupBoxBeni.Controls[i]);
        }
        public void chargerCbxSupprimerPersonne()
        {
            cbxListSuppr.Items.Clear();
            OleDbConnection connexion = new OleDbConnection();
                connexion.ConnectionString = provider;
                connexion.Open();
                OleDbDataAdapter daType = new OleDbDataAdapter(@"SELECT nomPersonne,pnPersonne FROM [Personne]", connexion);
                DataSet dsType = new DataSet();
                daType.Fill(dsType);

                foreach (DataRow ligne in dsType.Tables[0].Rows)
                {
                    cbxListSuppr.Items.Add(ligne[0]+" "+ ligne[1]);
                }
            }

        

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            ClearPanels();
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = provider;
            connexion.Open();
            string prenom = cbxListSuppr.Text.Remove(0, cbxListSuppr.Text.IndexOf(' ') + 1);
            string nom = cbxListSuppr.Text.Split(new char[] { ' ' }, 2)[0];


            OleDbCommand supprimerPersonne = new OleDbCommand("DELETE FROM [Personne] WHERE nomPersonne ="+'"'+ nom +'"'+"AND pnPersonne="+'"'+prenom+'"'+" ", connexion);
            supprimerPersonne.ExecuteNonQuery();
            connexion.Close();
            cbxListSuppr.Text = "";
            initialisationCheckBoxClient();
            chargerCbxSupprimerPersonne();
        }

        private void remplirGridModifier()
        {
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = provider;
            connexion.Open();
            OleDbDataAdapter daSupprimer = new OleDbDataAdapter(@"SELECT * FROM [Transaction]", connexion);
            DataTable dtable = new DataTable();
            daSupprimer.Fill(dtable);
            dataGridViewModifier.DataSource = dtable;
            connexion.Close();

        } // On remplit le dataGridView

        private void remplirGridSupprimer()
        {

            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = provider;
            connexion.Open();
            OleDbDataAdapter daSupprimer = new OleDbDataAdapter(@"SELECT * FROM [Transaction]", connexion);
            DataTable dtable = new DataTable();
            daSupprimer.Fill(dtable);
            dataGridViewSupprimer.DataSource = dtable;
            connexion.Close();

        } // On remplit le dataGridView

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string commande = "";
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = provider;
            connexion.Open();
            DataTable datable = new DataTable();
            datable = (DataTable)dataGridViewModifier.DataSource;
            commande = "DELETE FROM [Transaction]";
            OleDbCommand delete = new OleDbCommand(commande, connexion);
            delete.ExecuteNonQuery();
            foreach (DataRow ligne in datable.Rows)
            {
                string newdate = dateTransaction.Value.ToShortDateString();
                commande = "Insert into [Transaction] VALUES (" + ligne[0] + ",#" + newdate + "#," + '"' + ligne[2] + '"' + "," + ligne[3] + "," + ligne[4] + "," + ligne[5] + "," + ligne[6] + ")";
                OleDbCommand rajouter = new OleDbCommand(commande, connexion);
                try
                {
                    rajouter.ExecuteNonQuery();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Attention ! Le type entré " + ligne[6].ToString() + " n'existe pas ! La ligne sera supprimée.");
                }


            }
            connexion.Close();
            MessageBox.Show("Modification terminée");
            remplirGridSupprimer();
            remplirGridModifier();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            string ligne = dataGridViewSupprimer.CurrentRow.Cells[0].Value.ToString();
            string commande = "DELETE FROM [Transaction] WHERE [codeTransaction] = " + ligne;
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = provider;
            connexion.Open();
            OleDbCommand delete = new OleDbCommand(commande, connexion);
            delete.ExecuteNonQuery();
            MessageBox.Show("Ligne supprimée");
            connexion.Close();
            remplirGridSupprimer();
            remplirGridModifier();
        }

        private void actualiserInfosTypes()
        {

            groupBoxType.Controls.Clear();
            OleDbConnection connexion = new OleDbConnection();

            connexion.ConnectionString = provider;
            connexion.Open();
            OleDbDataAdapter daType = new OleDbDataAdapter(@"SELECT codeType, libType FROM TypeTransaction", connexion);
            DataSet dsType = new DataSet();
            daType.Fill(dsType);
            int i = 0;
            int n = 0;
            foreach (DataRow ligne in dsType.Tables[0].Rows)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(10 + 100 * n, 29 + 20 * i);
                label.Name = "label3";
                label.Size = new System.Drawing.Size(35, 13);
                label.TabIndex = 0;
                label.Text = "" + ligne[0] + " = " + ligne[1];
                groupBoxType.Controls.Add(label);
                i++;
                if (i > 5)
                {
                    n++;
                    i = 0;
                }
            }
            connexion.Close();
        }
    }
    
    
}
// test test 2
