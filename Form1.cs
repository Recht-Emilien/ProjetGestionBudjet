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
        }

        private void remplirType()
        {
            OleDbConnection connexion = new OleDbConnection();
            try
            {
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
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
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
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
            initialisationCheckBoxClient();
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

            connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
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
    
    }
    
    
}
// test test 2
