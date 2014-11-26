namespace CentreLocationOutils
{
    partial class rechercherOutilForm
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
            this.btnRechercherClientAnnuler = new System.Windows.Forms.Button();
            this.btnRechercherClientOk = new System.Windows.Forms.Button();
            this.txtRechercherOutilNom = new System.Windows.Forms.TextBox();
            this.txtRechercherOutilId = new System.Windows.Forms.TextBox();
            this.lblRechercherOutilNom = new System.Windows.Forms.Label();
            this.lblRechercherOutilId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRechercherClientAnnuler
            // 
            this.btnRechercherClientAnnuler.Location = new System.Drawing.Point(126, 143);
            this.btnRechercherClientAnnuler.Name = "btnRechercherClientAnnuler";
            this.btnRechercherClientAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherClientAnnuler.TabIndex = 11;
            this.btnRechercherClientAnnuler.Text = "Annuler";
            this.btnRechercherClientAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnRechercherClientOk
            // 
            this.btnRechercherClientOk.Location = new System.Drawing.Point(45, 143);
            this.btnRechercherClientOk.Name = "btnRechercherClientOk";
            this.btnRechercherClientOk.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherClientOk.TabIndex = 10;
            this.btnRechercherClientOk.Text = "OK";
            this.btnRechercherClientOk.UseVisualStyleBackColor = true;
            // 
            // txtRechercherOutilNom
            // 
            this.txtRechercherOutilNom.Location = new System.Drawing.Point(85, 82);
            this.txtRechercherOutilNom.Name = "txtRechercherOutilNom";
            this.txtRechercherOutilNom.Size = new System.Drawing.Size(100, 20);
            this.txtRechercherOutilNom.TabIndex = 9;
            // 
            // txtRechercherOutilId
            // 
            this.txtRechercherOutilId.Location = new System.Drawing.Point(85, 39);
            this.txtRechercherOutilId.Name = "txtRechercherOutilId";
            this.txtRechercherOutilId.Size = new System.Drawing.Size(100, 20);
            this.txtRechercherOutilId.TabIndex = 8;
            // 
            // lblRechercherOutilNom
            // 
            this.lblRechercherOutilNom.AutoSize = true;
            this.lblRechercherOutilNom.Location = new System.Drawing.Point(31, 85);
            this.lblRechercherOutilNom.Name = "lblRechercherOutilNom";
            this.lblRechercherOutilNom.Size = new System.Drawing.Size(48, 13);
            this.lblRechercherOutilNom.TabIndex = 7;
            this.lblRechercherOutilNom.Text = "Par Nom";
            // 
            // lblRechercherOutilId
            // 
            this.lblRechercherOutilId.AutoSize = true;
            this.lblRechercherOutilId.Location = new System.Drawing.Point(42, 42);
            this.lblRechercherOutilId.Name = "lblRechercherOutilId";
            this.lblRechercherOutilId.Size = new System.Drawing.Size(37, 13);
            this.lblRechercherOutilId.TabIndex = 6;
            this.lblRechercherOutilId.Text = "Par ID";
            // 
            // rechercherOutilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 201);
            this.Controls.Add(this.btnRechercherClientAnnuler);
            this.Controls.Add(this.btnRechercherClientOk);
            this.Controls.Add(this.txtRechercherOutilNom);
            this.Controls.Add(this.txtRechercherOutilId);
            this.Controls.Add(this.lblRechercherOutilNom);
            this.Controls.Add(this.lblRechercherOutilId);
            this.Name = "rechercherOutilForm";
            this.Text = "Rechercher Outil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechercherClientAnnuler;
        private System.Windows.Forms.Button btnRechercherClientOk;
        private System.Windows.Forms.TextBox txtRechercherOutilNom;
        private System.Windows.Forms.TextBox txtRechercherOutilId;
        private System.Windows.Forms.Label lblRechercherOutilNom;
        private System.Windows.Forms.Label lblRechercherOutilId;
    }
}