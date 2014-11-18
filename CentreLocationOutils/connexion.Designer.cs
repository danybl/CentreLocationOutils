namespace CentreLocationOutils
{
    partial class connexion
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
            this.connexionControl1 = new ConnexionControl.ConnexionControl();
            this.SuspendLayout();
            // 
            // connexionControl1
            // 
            this.connexionControl1.labelPassword = "Password :";
            this.connexionControl1.labelUserName = "Username :";
            this.connexionControl1.Location = new System.Drawing.Point(-3, 12);
            this.connexionControl1.Name = "connexionControl1";
            this.connexionControl1.Size = new System.Drawing.Size(288, 190);
            this.connexionControl1.TabIndex = 0;
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 201);
            this.Controls.Add(this.connexionControl1);
            this.Name = "connexion";
            this.Text = "connexion";
            this.ResumeLayout(false);

        }

        #endregion

        private ConnexionControl.ConnexionControl connexionControl1;

    }
}