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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
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
                    cbxSupprimerType.Items.Add(ligne[0]);
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" )
            {
                OleDbConnection connexion = new OleDbConnection();
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
                connexion.Open();
                OleDbCommand nombre = new OleDbCommand("Select count(codeType) from TypeTransaction", connexion);
                int codeType = int.Parse(nombre.ExecuteScalar().ToString());
                
                codeType++;







                String commande = "Insert into TypeTransaction (codeType, libType) VALUES (" + codeType + "," + '"' + textBox1.Text + '"'  +")"  ;
                OleDbCommand insert = new OleDbCommand(commande, connexion);
                insert.ExecuteNonQuery();
                MessageBox.Show("Le type " + textBox1.Text + " a été ajoutée");
                connexion.Close();
                textBox1.Text = "";
                actualiser();
            }
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            String commande = "DELETE FROM typeTransaction WHERE libType =" + '"' + cbxSupprimerType.Text + '"';
            OleDbConnection connexion = new OleDbConnection();
            connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
            connexion.Open();
            OleDbCommand delete = new OleDbCommand(commande, connexion);
            delete.ExecuteNonQuery();
            MessageBox.Show("Le type " + cbxSupprimerType.Text + " a été supprimé");
            cbxSupprimerType.Text = "";
            connexion.Close();
            actualiser();
        }

        private void actualiser()
        {
            cbxSupprimerType.Items.Clear();
            OleDbConnection connexion = new OleDbConnection();
           
                connexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dark_\Downloads\budget1.mdb";
                connexion.Open();
                OleDbDataAdapter daType = new OleDbDataAdapter(@"SELECT libType FROM TypeTransaction", connexion);
                DataSet dsType = new DataSet();
                daType.Fill(dsType);

                foreach (DataRow ligne in dsType.Tables[0].Rows)
                {
                    cbxSupprimerType.Items.Add(ligne[0]);
                }

                connexion.Close();

            }
        }
}
    
// 
