using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Service_ENSA
{
    public partial class Form1 : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alMostapha\Desktop\Gestion_Service_ENSA\Gestion_Service_ENSA\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.login.Focus();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void conx_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select Profil from Compte where Login = '" + login.Text + "' and Password = '" + pass.Text + "'",connection);
            myReader = myCommand.ExecuteReader();
            //string userText = MainMDI.globalstring;
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {
                    if (myReader["Profil"].ToString() == "Administrateur")
                    {
                        this.Hide();
                        Administrateur ad = new Administrateur();
                        ad.Show();
                    }
                    
                }
            }
            else 
            {
                MessageBox.Show("Invalid Login or Password !!");
                this.login.Focus();
                this.login.Clear();
                this.pass.Clear();
                
            }
            
           
           connection.Close();
        }
    }
}
