namespace CentreLcationOutils_front_end.forms
{
    partial class ConnexionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnexionForm));
            this.pbConnexion_Image = new System.Windows.Forms.PictureBox();
            this.controlConnexion = new ConnexionControl.ConnexionControl();
            this.lblConnexion_Titre = new System.Windows.Forms.Label();
            this.lblResultatConnexion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnexion_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pbConnexion_Image
            // 
            this.pbConnexion_Image.Image = ((System.Drawing.Image)(resources.GetObject("pbConnexion_Image.Image")));
            this.pbConnexion_Image.Location = new System.Drawing.Point(333, 52);
            this.pbConnexion_Image.Name = "pbConnexion_Image";
            this.pbConnexion_Image.Size = new System.Drawing.Size(133, 128);
            this.pbConnexion_Image.TabIndex = 0;
            this.pbConnexion_Image.TabStop = false;
            // 
            // controlConnexion
            // 
            this.controlConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlConnexion.labelEmail = "Email :";
            this.controlConnexion.labelPassword = "Password :";
            this.controlConnexion.Location = new System.Drawing.Point(299, 323);
            this.controlConnexion.Name = "controlConnexion";
            this.controlConnexion.Size = new System.Drawing.Size(201, 151);
            this.controlConnexion.TabIndex = 1;
            this.controlConnexion.connexionReussie += new ConnexionControl.ConnexionControl.EventHandler(this.controlConnexion_connexionReussie);
            this.controlConnexion.connexionEchec += new ConnexionControl.ConnexionControl.EventHandler(this.controlConnexion_connexionEchec);
            // 
            // lblConnexion_Titre
            // 
            this.lblConnexion_Titre.AutoSize = true;
            this.lblConnexion_Titre.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion_Titre.ForeColor = System.Drawing.Color.Gold;
            this.lblConnexion_Titre.Location = new System.Drawing.Point(262, 246);
            this.lblConnexion_Titre.Name = "lblConnexion_Titre";
            this.lblConnexion_Titre.Size = new System.Drawing.Size(289, 38);
            this.lblConnexion_Titre.TabIndex = 2;
            this.lblConnexion_Titre.Text = "Connectez-vous!";
            // 
            // lblResultatConnexion
            // 
            this.lblResultatConnexion.AutoSize = true;
            this.lblResultatConnexion.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultatConnexion.ForeColor = System.Drawing.Color.Gold;
            this.lblResultatConnexion.Location = new System.Drawing.Point(349, 295);
            this.lblResultatConnexion.Name = "lblResultatConnexion";
            this.lblResultatConnexion.Size = new System.Drawing.Size(0, 15);
            this.lblResultatConnexion.TabIndex = 3;
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblResultatConnexion);
            this.Controls.Add(this.lblConnexion_Titre);
            this.Controls.Add(this.controlConnexion);
            this.Controls.Add(this.pbConnexion_Image);
            this.Name = "ConnexionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutilMate";
            ((System.ComponentModel.ISupportInitialize)(this.pbConnexion_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbConnexion_Image;
        private ConnexionControl.ConnexionControl controlConnexion;
        private System.Windows.Forms.Label lblConnexion_Titre;
        private System.Windows.Forms.Label lblResultatConnexion;
    }
}