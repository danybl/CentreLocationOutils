namespace CentreLocationOutils
{
    partial class rechercherClientForm
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
            this.lblRechercherClientId = new System.Windows.Forms.Label();
            this.lblRechercherClientNom = new System.Windows.Forms.Label();
            this.txtRechercherClientId = new System.Windows.Forms.TextBox();
            this.txtRechercherClientNom = new System.Windows.Forms.TextBox();
            this.btnRechercherClientOk = new System.Windows.Forms.Button();
            this.btnRechercherClientAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRechercherClientId
            // 
            this.lblRechercherClientId.AutoSize = true;
            this.lblRechercherClientId.Location = new System.Drawing.Point(54, 45);
            this.lblRechercherClientId.Name = "lblRechercherClientId";
            this.lblRechercherClientId.Size = new System.Drawing.Size(37, 13);
            this.lblRechercherClientId.TabIndex = 0;
            this.lblRechercherClientId.Text = "Par ID";
            // 
            // lblRechercherClientNom
            // 
            this.lblRechercherClientNom.AutoSize = true;
            this.lblRechercherClientNom.Location = new System.Drawing.Point(43, 88);
            this.lblRechercherClientNom.Name = "lblRechercherClientNom";
            this.lblRechercherClientNom.Size = new System.Drawing.Size(48, 13);
            this.lblRechercherClientNom.TabIndex = 1;
            this.lblRechercherClientNom.Text = "Par Nom";
            // 
            // txtRechercherClientId
            // 
            this.txtRechercherClientId.Location = new System.Drawing.Point(97, 42);
            this.txtRechercherClientId.Name = "txtRechercherClientId";
            this.txtRechercherClientId.Size = new System.Drawing.Size(100, 20);
            this.txtRechercherClientId.TabIndex = 2;
            // 
            // txtRechercherClientNom
            // 
            this.txtRechercherClientNom.Location = new System.Drawing.Point(97, 85);
            this.txtRechercherClientNom.Name = "txtRechercherClientNom";
            this.txtRechercherClientNom.Size = new System.Drawing.Size(100, 20);
            this.txtRechercherClientNom.TabIndex = 3;
            // 
            // btnRechercherClientOk
            // 
            this.btnRechercherClientOk.Location = new System.Drawing.Point(57, 146);
            this.btnRechercherClientOk.Name = "btnRechercherClientOk";
            this.btnRechercherClientOk.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherClientOk.TabIndex = 4;
            this.btnRechercherClientOk.Text = "OK";
            this.btnRechercherClientOk.UseVisualStyleBackColor = true;
            // 
            // btnRechercherClientAnnuler
            // 
            this.btnRechercherClientAnnuler.Location = new System.Drawing.Point(138, 146);
            this.btnRechercherClientAnnuler.Name = "btnRechercherClientAnnuler";
            this.btnRechercherClientAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherClientAnnuler.TabIndex = 5;
            this.btnRechercherClientAnnuler.Text = "Annuler";
            this.btnRechercherClientAnnuler.UseVisualStyleBackColor = true;
            // 
            // rechercherClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 210);
            this.Controls.Add(this.btnRechercherClientAnnuler);
            this.Controls.Add(this.btnRechercherClientOk);
            this.Controls.Add(this.txtRechercherClientNom);
            this.Controls.Add(this.txtRechercherClientId);
            this.Controls.Add(this.lblRechercherClientNom);
            this.Controls.Add(this.lblRechercherClientId);
            this.Name = "rechercherClientForm";
            this.Text = "Rechercher Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRechercherClientId;
        private System.Windows.Forms.Label lblRechercherClientNom;
        private System.Windows.Forms.TextBox txtRechercherClientId;
        private System.Windows.Forms.TextBox txtRechercherClientNom;
        private System.Windows.Forms.Button btnRechercherClientOk;
        private System.Windows.Forms.Button btnRechercherClientAnnuler;
    }
}