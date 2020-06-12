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
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.labellogin = new MetroFramework.Controls.MetroLabel();
            this.passlabel = new MetroFramework.Controls.MetroLabel();
            this.conx = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(289, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(209, 23);
            this.login.TabIndex = 6;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(289, 217);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(209, 23);
            this.pass.TabIndex = 7;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.ForeColor = System.Drawing.Color.Black;
            this.labellogin.Location = new System.Drawing.Point(225, 161);
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
            this.passlabel.Location = new System.Drawing.Point(203, 217);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(70, 19);
            this.passlabel.TabIndex = 9;
            this.passlabel.Text = "Password :";
            this.passlabel.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // conx
            // 
            this.conx.Location = new System.Drawing.Point(331, 287);
            this.conx.Name = "conx";
            this.conx.Size = new System.Drawing.Size(112, 35);
            this.conx.TabIndex = 10;
            this.conx.Text = "Connexion";
            this.conx.Click += new System.EventHandler(this.conx_Click);
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
            this.Name = "Form1";
            this.Text = "Gestion de Services ENSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroTextBox pass;
        private MetroFramework.Controls.MetroLabel labellogin;
        private MetroFramework.Controls.MetroLabel passlabel;
        private MetroFramework.Controls.MetroButton conx;
    }
}

