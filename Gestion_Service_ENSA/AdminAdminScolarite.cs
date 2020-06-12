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
    public partial class AdminAdminScolarite : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alMostapha\Desktop\Gestion_Service_ENSA\Gestion_Service_ENSA\Gestion_Service_ENSA\DatabaseGestionService.mdf;Integrated Security=True");
        public AdminAdminScolarite()
        {
            InitializeComponent();
        }

        private void AdminAdminScolarite_Load(object sender, EventArgs e)
        {
            this.cinscol.Focus();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into AdministrateurScol values ('" + cinscol.Text + "','"
                                                               + nom.Text + "','"
                                                               + prenom.Text + "','"
                                                               + datenai.Text + "','"
                                                               + email.Text + "','"
                                                               + tel.Text + "' );";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Ajout avec succes!!");
            this.cinscol.Clear();
            this.nom.Clear();
            this.prenom.Clear();
            this.datedenaissance.Clear();
            this.email.Clear();
            this.tel.Clear();
            this.search.Clear();
            connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataReader myReader1 = null;
            SqlCommand myCommand1 = new SqlCommand("select * from AdministrateurScol where CIN = '" + search.Text + "'", connection);
            myReader1 = myCommand1.ExecuteReader();
            while (myReader1.Read())
            {
                this.cinscol.Text = myReader1["CIN"].ToString();
                this.nom.Text = myReader1["Nom"].ToString();
                this.prenom.Text = myReader1["Prenom"].ToString();
                this.datedenaissance.Text = myReader1["Date_n"].ToString();
                this.email.Text = myReader1["Email"].ToString();
                this.tel.Text = myReader1["Tel"].ToString();
            }
            connection.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir supprimer cet Administrateur Scolarité ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader myReader2 = null;
                SqlCommand myCommand2 = new SqlCommand("delete from AdministrateurScol where CIN = '" + search.Text + "'", connection);
                myReader2 = myCommand2.ExecuteReader();
                MessageBox.Show("Suppression d'etudiant avec succees !!");
                this.cinscol.Clear();
                this.nom.Clear();
                this.prenom.Clear();
                this.datedenaissance.Clear();
                this.email.Clear();
                this.tel.Clear();
                this.search.Clear();

                connection.Close();
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de vouloir modifier cet Administrateur Scolarité ?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("update AdministrateurScol set CIN = '" + cinscol.Text + "', Nom = '" + nom.Text + "', Prenom = '" + prenom.Text + "', Date_n = '" + datedenaissance.Text + "', Email = '" + email.Text + "', Tel = '" + tel.Text + "' where CIN = '" + search.Text + "'", connection);
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Mise à jour avec succees !!");
            }
            this.cinscol.Clear();
            this.nom.Clear();
            this.prenom.Clear();
            this.datedenaissance.Clear();
            this.email.Clear();
            this.tel.Clear();
            this.search.Clear();

            connection.Close();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            this.cinscol.Clear();
            this.nom.Clear();
            this.prenom.Clear();
            this.datedenaissance.Clear();
            this.email.Clear();
            this.tel.Clear();
            this.search.Clear();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrateur ad = new Administrateur();
            ad.Show();
        }
    }
}
