namespace Gestion_Service_ENSA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.labellogin = new MetroFramework.Controls.MetroLabel();
            this.passlabel = new MetroFramework.Controls.MetroLabel();
            this.conx = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(232, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Vous etes un :";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Administrateur",
            "Administrateur Scolarité",
            "Professeur",
            "Etudiant"});
            this.metroComboBox1.Location = new System.Drawing.Point(277, 154);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(209, 29);
            this.metroComboBox1.TabIndex = 5;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(277, 242);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(209, 23);
            this.login.TabIndex = 6;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(277, 298);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(209, 23);
            this.pass.TabIndex = 7;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.ForeColor = System.Drawing.Color.Black;
            this.labellogin.Location = new System.Drawing.Point(213, 242);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(48, 19);
            this.labellogin.TabIndex = 8;
            this.labellogin.Text = "Login :";
            this.labellogin.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.ForeColor = System.Drawing.Color.Black;
            this.passlabel.Location = new System.Drawing.Point(191, 298);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(70, 19);
            this.passlabel.TabIndex = 9;
            this.passlabel.Text = "Password :";
            this.passlabel.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // conx
            // 
            this.conx.Location = new System.Drawing.Point(319, 368);
            this.conx.Name = "conx";
            this.conx.Size = new System.Drawing.Size(112, 35);
            this.conx.TabIndex = 10;
            this.conx.Text = "Connexion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 474);
            this.Controls.Add(this.conx);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Gestion de Services ENSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroTextBox pass;
        private MetroFramework.Controls.MetroLabel labellogin;
        private MetroFramework.Controls.MetroLabel passlabel;
        private MetroFramework.Controls.MetroButton conx;
    }
}

