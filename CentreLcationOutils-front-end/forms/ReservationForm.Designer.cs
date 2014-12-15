namespace CentreLcationOutils_front_end.forms
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.menuGestionReservations = new System.Windows.Forms.MenuStrip();
            this.mItemGestionReservations_Accueil = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Gestionnaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_Apropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionReservations_SigneInterrogation = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGestionReservations_InfoReservation = new System.Windows.Forms.Panel();
            this.btnGestionLocations_Rechercher = new System.Windows.Forms.Button();
            this.btnGestionLocations_Annuler = new System.Windows.Forms.Button();
            this.btnGestionLocations_Renouveler = new System.Windows.Forms.Button();
            this.btnGestionLocations_Ajouter = new System.Windows.Forms.Button();
            this.tbGestionReservations_DateLimite = new System.Windows.Forms.TextBox();
            this.tbGestionReservations_DateReservation = new System.Windows.Forms.TextBox();
            this.tbGestionReservations_IdOutil = new System.Windows.Forms.TextBox();
            this.tbGestionReservations_IdClient = new System.Windows.Forms.TextBox();
            this.lblGestionReservation_DateLimite = new System.Windows.Forms.Label();
            this.lblGestionReservations_DateReservation = new System.Windows.Forms.Label();
            this.lblGestionReservations_IdOutil = new System.Windows.Forms.Label();
            this.lblGestionReservations_IdClient = new System.Windows.Forms.Label();
            this.tbGestionReservations_IdReservation = new System.Windows.Forms.TextBox();
            this.lblGestionReservations_IdReservation = new System.Windows.Forms.Label();
            this.lblGestionReservations_Titre1 = new System.Windows.Forms.Label();
            this.panelGestionReservations_ListeReservations = new System.Windows.Forms.Panel();
            this.dgGestionReservations_ListeReservations = new System.Windows.Forms.DataGridView();
            this.columnIDLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdOutil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionReservations_Titre2 = new System.Windows.Forms.Label();
            this.menuGestionReservations.SuspendLayout();
            this.panelGestionReservations_InfoReservation.SuspendLayout();
            this.panelGestionReservations_ListeReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionReservations_ListeReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGestionReservations
            // 
            this.menuGestionReservations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionReservations_Accueil,
            this.mItemGestionReservations_Option,
            this.mItemGestionReservations_Aide});
            this.menuGestionReservations.Location = new System.Drawing.Point(0, 0);
            this.menuGestionReservations.Name = "menuGestionReservations";
            this.menuGestionReservations.Size = new System.Drawing.Size(784, 24);
            this.menuGestionReservations.TabIndex = 25;
            this.menuGestionReservations.Text = "menuStrip1";
            // 
            // mItemGestionReservations_Accueil
            // 
            this.mItemGestionReservations_Accueil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionReservations_Gestionnaire,
            this.mItemGestionReservations_Connexion,
            this.mItemGestionReservations_Deconnexion,
            this.mItemGestionReservations_Quitter});
            this.mItemGestionReservations_Accueil.Name = "mItemGestionReservations_Accueil";
            this.mItemGestionReservations_Accueil.Size = new System.Drawing.Size(58, 20);
            this.mItemGestionReservations_Accueil.Text = "Accueil";
            // 
            // mItemGestionReservations_Gestionnaire
            // 
            this.mItemGestionReservations_Gestionnaire.Name = "mItemGestionReservations_Gestionnaire";
            this.mItemGestionReservations_Gestionnaire.Size = new System.Drawing.Size(152, 22);
            this.mItemGestionReservations_Gestionnaire.Text = "Gestionnaire";
            // 
            // mItemGestionReservations_Connexion
            // 
            this.mItemGestionReservations_Connexion.Name = "mItemGestionReservations_Connexion";
            this.mItemGestionReservations_Connexion.Size = new System.Drawing.Size(152, 22);
            this.mItemGestionReservations_Connexion.Text = "Connexion";
            // 
            // mItemGestionReservations_Deconnexion
            // 
            this.mItemGestionReservations_Deconnexion.Name = "mItemGestionReservations_Deconnexion";
            this.mItemGestionReservations_Deconnexion.Size = new System.Drawing.Size(152, 22);
            this.mItemGestionReservations_Deconnexion.Text = "Deconnexion";
            // 
            // mItemGestionReservations_Quitter
            // 
            this.mItemGestionReservations_Quitter.Name = "mItemGestionReservations_Quitter";
            this.mItemGestionReservations_Quitter.Size = new System.Drawing.Size(152, 22);
            this.mItemGestionReservations_Quitter.Text = "Quitter";
            // 
            // mItemGestionReservations_Option
            // 
            this.mItemGestionReservations_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionReservations_Parametres});
            this.mItemGestionReservations_Option.Name = "mItemGestionReservations_Option";
            this.mItemGestionReservations_Option.Size = new System.Drawing.Size(61, 20);
            this.mItemGestionReservations_Option.Text = "Options";
            // 
            // mItemGestionReservations_Parametres
            // 
            this.mItemGestionReservations_Parametres.Name = "mItemGestionReservations_Parametres";
            this.mItemGestionReservations_Parametres.Size = new System.Drawing.Size(133, 22);
            this.mItemGestionReservations_Parametres.Text = "Paramètres";
            // 
            // mItemGestionReservations_Aide
            // 
            this.mItemGestionReservations_Aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionReservations_Apropos,
            this.mItemGestionReservations_SigneInterrogation});
            this.mItemGestionReservations_Aide.Name = "mItemGestionReservations_Aide";
            this.mItemGestionReservations_Aide.Size = new System.Drawing.Size(43, 20);
            this.mItemGestionReservations_Aide.Text = "Aide";
            // 
            // mItemGestionReservations_Apropos
            // 
            this.mItemGestionReservations_Apropos.Name = "mItemGestionReservations_Apropos";
            this.mItemGestionReservations_Apropos.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionReservations_Apropos.Text = "à propos de nous";
            // 
            // mItemGestionReservations_SigneInterrogation
            // 
            this.mItemGestionReservations_SigneInterrogation.Name = "mItemGestionReservations_SigneInterrogation";
            this.mItemGestionReservations_SigneInterrogation.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionReservations_SigneInterrogation.Text = "?";
            // 
            // panelGestionReservations_InfoReservation
            // 
            this.panelGestionReservations_InfoReservation.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionReservations_InfoReservation.Controls.Add(this.btnGestionLocations_Rechercher);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.btnGestionLocations_Annuler);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.btnGestionLocations_Renouveler);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.btnGestionLocations_Ajouter);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.tbGestionReservations_DateLimite);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.tbGestionReservations_DateReservation);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.tbGestionReservations_IdOutil);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.tbGestionReservations_IdClient);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservation_DateLimite);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservations_DateReservation);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservations_IdOutil);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservations_IdClient);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.tbGestionReservations_IdReservation);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservations_IdReservation);
            this.panelGestionReservations_InfoReservation.Controls.Add(this.lblGestionReservations_Titre1);
            this.panelGestionReservations_InfoReservation.Location = new System.Drawing.Point(10, 27);
            this.panelGestionReservations_InfoReservation.Name = "panelGestionReservations_InfoReservation";
            this.panelGestionReservations_InfoReservation.Size = new System.Drawing.Size(762, 237);
            this.panelGestionReservations_InfoReservation.TabIndex = 26;
            // 
            // btnGestionLocations_Rechercher
            // 
            this.btnGestionLocations_Rechercher.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGestionLocations_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Rechercher.Image")));
            this.btnGestionLocations_Rechercher.Location = new System.Drawing.Point(263, 176);
            this.btnGestionLocations_Rechercher.Name = "btnGestionLocations_Rechercher";
            this.btnGestionLocations_Rechercher.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Rechercher.TabIndex = 22;
            this.btnGestionLocations_Rechercher.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Annuler
            // 
            this.btnGestionLocations_Annuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnGestionLocations_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Annuler.Image")));
            this.btnGestionLocations_Annuler.Location = new System.Drawing.Point(483, 176);
            this.btnGestionLocations_Annuler.Name = "btnGestionLocations_Annuler";
            this.btnGestionLocations_Annuler.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Annuler.TabIndex = 21;
            this.btnGestionLocations_Annuler.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Renouveler
            // 
            this.btnGestionLocations_Renouveler.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGestionLocations_Renouveler.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Renouveler.Image")));
            this.btnGestionLocations_Renouveler.Location = new System.Drawing.Point(409, 176);
            this.btnGestionLocations_Renouveler.Name = "btnGestionLocations_Renouveler";
            this.btnGestionLocations_Renouveler.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Renouveler.TabIndex = 20;
            this.btnGestionLocations_Renouveler.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Ajouter
            // 
            this.btnGestionLocations_Ajouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGestionLocations_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Ajouter.Image")));
            this.btnGestionLocations_Ajouter.Location = new System.Drawing.Point(336, 176);
            this.btnGestionLocations_Ajouter.Name = "btnGestionLocations_Ajouter";
            this.btnGestionLocations_Ajouter.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Ajouter.TabIndex = 19;
            this.btnGestionLocations_Ajouter.UseVisualStyleBackColor = false;
            // 
            // tbGestionReservations_DateLimite
            // 
            this.tbGestionReservations_DateLimite.Location = new System.Drawing.Point(519, 93);
            this.tbGestionReservations_DateLimite.Name = "tbGestionReservations_DateLimite";
            this.tbGestionReservations_DateLimite.ReadOnly = true;
            this.tbGestionReservations_DateLimite.Size = new System.Drawing.Size(157, 20);
            this.tbGestionReservations_DateLimite.TabIndex = 17;
            // 
            // tbGestionReservations_DateReservation
            // 
            this.tbGestionReservations_DateReservation.Location = new System.Drawing.Point(519, 62);
            this.tbGestionReservations_DateReservation.Name = "tbGestionReservations_DateReservation";
            this.tbGestionReservations_DateReservation.ReadOnly = true;
            this.tbGestionReservations_DateReservation.Size = new System.Drawing.Size(157, 20);
            this.tbGestionReservations_DateReservation.TabIndex = 16;
            // 
            // tbGestionReservations_IdOutil
            // 
            this.tbGestionReservations_IdOutil.Location = new System.Drawing.Point(212, 124);
            this.tbGestionReservations_IdOutil.Name = "tbGestionReservations_IdOutil";
            this.tbGestionReservations_IdOutil.Size = new System.Drawing.Size(67, 20);
            this.tbGestionReservations_IdOutil.TabIndex = 14;
            // 
            // tbGestionReservations_IdClient
            // 
            this.tbGestionReservations_IdClient.Location = new System.Drawing.Point(212, 93);
            this.tbGestionReservations_IdClient.Name = "tbGestionReservations_IdClient";
            this.tbGestionReservations_IdClient.Size = new System.Drawing.Size(67, 20);
            this.tbGestionReservations_IdClient.TabIndex = 12;
            // 
            // lblGestionReservation_DateLimite
            // 
            this.lblGestionReservation_DateLimite.AutoSize = true;
            this.lblGestionReservation_DateLimite.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservation_DateLimite.ForeColor = System.Drawing.Color.White;
            this.lblGestionReservation_DateLimite.Location = new System.Drawing.Point(355, 97);
            this.lblGestionReservation_DateLimite.Name = "lblGestionReservation_DateLimite";
            this.lblGestionReservation_DateLimite.Size = new System.Drawing.Size(98, 16);
            this.lblGestionReservation_DateLimite.TabIndex = 10;
            this.lblGestionReservation_DateLimite.Text = "DATE LIMITIE :";
            // 
            // lblGestionReservations_DateReservation
            // 
            this.lblGestionReservations_DateReservation.AutoSize = true;
            this.lblGestionReservations_DateReservation.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_DateReservation.ForeColor = System.Drawing.Color.White;
            this.lblGestionReservations_DateReservation.Location = new System.Drawing.Point(355, 66);
            this.lblGestionReservations_DateReservation.Name = "lblGestionReservations_DateReservation";
            this.lblGestionReservations_DateReservation.Size = new System.Drawing.Size(137, 16);
            this.lblGestionReservations_DateReservation.TabIndex = 9;
            this.lblGestionReservations_DateReservation.Text = "DATE RESERVATION :";
            // 
            // lblGestionReservations_IdOutil
            // 
            this.lblGestionReservations_IdOutil.AutoSize = true;
            this.lblGestionReservations_IdOutil.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_IdOutil.ForeColor = System.Drawing.Color.White;
            this.lblGestionReservations_IdOutil.Location = new System.Drawing.Point(111, 128);
            this.lblGestionReservations_IdOutil.Name = "lblGestionReservations_IdOutil";
            this.lblGestionReservations_IdOutil.Size = new System.Drawing.Size(52, 16);
            this.lblGestionReservations_IdOutil.TabIndex = 7;
            this.lblGestionReservations_IdOutil.Text = "OUTIL :";
            // 
            // lblGestionReservations_IdClient
            // 
            this.lblGestionReservations_IdClient.AutoSize = true;
            this.lblGestionReservations_IdClient.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_IdClient.ForeColor = System.Drawing.Color.White;
            this.lblGestionReservations_IdClient.Location = new System.Drawing.Point(111, 97);
            this.lblGestionReservations_IdClient.Name = "lblGestionReservations_IdClient";
            this.lblGestionReservations_IdClient.Size = new System.Drawing.Size(63, 16);
            this.lblGestionReservations_IdClient.TabIndex = 5;
            this.lblGestionReservations_IdClient.Text = "CLIENT : ";
            // 
            // tbGestionReservations_IdReservation
            // 
            this.tbGestionReservations_IdReservation.Location = new System.Drawing.Point(212, 62);
            this.tbGestionReservations_IdReservation.Name = "tbGestionReservations_IdReservation";
            this.tbGestionReservations_IdReservation.ReadOnly = true;
            this.tbGestionReservations_IdReservation.Size = new System.Drawing.Size(67, 20);
            this.tbGestionReservations_IdReservation.TabIndex = 4;
            // 
            // lblGestionReservations_IdReservation
            // 
            this.lblGestionReservations_IdReservation.AutoSize = true;
            this.lblGestionReservations_IdReservation.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_IdReservation.ForeColor = System.Drawing.Color.White;
            this.lblGestionReservations_IdReservation.Location = new System.Drawing.Point(111, 66);
            this.lblGestionReservations_IdReservation.Name = "lblGestionReservations_IdReservation";
            this.lblGestionReservations_IdReservation.Size = new System.Drawing.Size(28, 16);
            this.lblGestionReservations_IdReservation.TabIndex = 3;
            this.lblGestionReservations_IdReservation.Text = "ID :";
            // 
            // lblGestionReservations_Titre1
            // 
            this.lblGestionReservations_Titre1.AutoSize = true;
            this.lblGestionReservations_Titre1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_Titre1.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionReservations_Titre1.Location = new System.Drawing.Point(249, 19);
            this.lblGestionReservations_Titre1.Name = "lblGestionReservations_Titre1";
            this.lblGestionReservations_Titre1.Size = new System.Drawing.Size(284, 19);
            this.lblGestionReservations_Titre1.TabIndex = 2;
            this.lblGestionReservations_Titre1.Text = "Information sur la reservation";
            // 
            // panelGestionReservations_ListeReservations
            // 
            this.panelGestionReservations_ListeReservations.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionReservations_ListeReservations.Controls.Add(this.dgGestionReservations_ListeReservations);
            this.panelGestionReservations_ListeReservations.Controls.Add(this.lblGestionReservations_Titre2);
            this.panelGestionReservations_ListeReservations.Location = new System.Drawing.Point(10, 273);
            this.panelGestionReservations_ListeReservations.Name = "panelGestionReservations_ListeReservations";
            this.panelGestionReservations_ListeReservations.Size = new System.Drawing.Size(762, 276);
            this.panelGestionReservations_ListeReservations.TabIndex = 24;
            // 
            // dgGestionReservations_ListeReservations
            // 
            this.dgGestionReservations_ListeReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionReservations_ListeReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDLocation,
            this.columnIdClient,
            this.columnIdEmploye,
            this.columnIdOutil,
            this.columnDepot,
            this.columnDateLocation,
            this.columnDateLimite,
            this.columnDateRetour});
            this.dgGestionReservations_ListeReservations.Location = new System.Drawing.Point(18, 48);
            this.dgGestionReservations_ListeReservations.Name = "dgGestionReservations_ListeReservations";
            this.dgGestionReservations_ListeReservations.Size = new System.Drawing.Size(731, 209);
            this.dgGestionReservations_ListeReservations.TabIndex = 1;
            // 
            // columnIDLocation
            // 
            this.columnIDLocation.HeaderText = "ID";
            this.columnIDLocation.Name = "columnIDLocation";
            this.columnIDLocation.ReadOnly = true;
            // 
            // columnIdClient
            // 
            this.columnIdClient.HeaderText = "Client";
            this.columnIdClient.Name = "columnIdClient";
            this.columnIdClient.ToolTipText = "Client";
            // 
            // columnIdEmploye
            // 
            this.columnIdEmploye.HeaderText = "Employe";
            this.columnIdEmploye.Name = "columnIdEmploye";
            this.columnIdEmploye.ToolTipText = "Employe";
            // 
            // columnIdOutil
            // 
            this.columnIdOutil.HeaderText = "Outil";
            this.columnIdOutil.Name = "columnIdOutil";
            this.columnIdOutil.ToolTipText = "Outil";
            // 
            // columnDepot
            // 
            this.columnDepot.HeaderText = "Depot";
            this.columnDepot.Name = "columnDepot";
            this.columnDepot.ToolTipText = "Depot";
            // 
            // columnDateLocation
            // 
            this.columnDateLocation.HeaderText = "DateLocation";
            this.columnDateLocation.Name = "columnDateLocation";
            this.columnDateLocation.ToolTipText = "DateLocation";
            // 
            // columnDateLimite
            // 
            this.columnDateLimite.HeaderText = "DateLimite";
            this.columnDateLimite.Name = "columnDateLimite";
            this.columnDateLimite.ToolTipText = "DateLimite";
            // 
            // columnDateRetour
            // 
            this.columnDateRetour.HeaderText = "DateRetour";
            this.columnDateRetour.Name = "columnDateRetour";
            this.columnDateRetour.ToolTipText = "DateRetour";
            // 
            // lblGestionReservations_Titre2
            // 
            this.lblGestionReservations_Titre2.AutoSize = true;
            this.lblGestionReservations_Titre2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionReservations_Titre2.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionReservations_Titre2.Location = new System.Drawing.Point(304, 20);
            this.lblGestionReservations_Titre2.Name = "lblGestionReservations_Titre2";
            this.lblGestionReservations_Titre2.Size = new System.Drawing.Size(203, 19);
            this.lblGestionReservations_Titre2.TabIndex = 0;
            this.lblGestionReservations_Titre2.Text = "Liste des reservations";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelGestionReservations_ListeReservations);
            this.Controls.Add(this.panelGestionReservations_InfoReservation);
            this.Controls.Add(this.menuGestionReservations);
            this.Name = "ReservationForm";
            this.Text = "Gestion des reservations";
            this.menuGestionReservations.ResumeLayout(false);
            this.menuGestionReservations.PerformLayout();
            this.panelGestionReservations_InfoReservation.ResumeLayout(false);
            this.panelGestionReservations_InfoReservation.PerformLayout();
            this.panelGestionReservations_ListeReservations.ResumeLayout(false);
            this.panelGestionReservations_ListeReservations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionReservations_ListeReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGestionReservations;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Accueil;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Gestionnaire;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Connexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Deconnexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Quitter;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Option;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Parametres;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Aide;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_Apropos;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionReservations_SigneInterrogation;
        private System.Windows.Forms.Panel panelGestionReservations_InfoReservation;
        private System.Windows.Forms.Button btnGestionLocations_Rechercher;
        private System.Windows.Forms.Button btnGestionLocations_Annuler;
        private System.Windows.Forms.Button btnGestionLocations_Renouveler;
        private System.Windows.Forms.Button btnGestionLocations_Ajouter;
        private System.Windows.Forms.TextBox tbGestionReservations_DateLimite;
        private System.Windows.Forms.TextBox tbGestionReservations_DateReservation;
        private System.Windows.Forms.TextBox tbGestionReservations_IdOutil;
        private System.Windows.Forms.TextBox tbGestionReservations_IdClient;
        private System.Windows.Forms.Label lblGestionReservation_DateLimite;
        private System.Windows.Forms.Label lblGestionReservations_DateReservation;
        private System.Windows.Forms.Label lblGestionReservations_IdOutil;
        private System.Windows.Forms.Label lblGestionReservations_IdClient;
        private System.Windows.Forms.TextBox tbGestionReservations_IdReservation;
        private System.Windows.Forms.Label lblGestionReservations_IdReservation;
        private System.Windows.Forms.Label lblGestionReservations_Titre1;
        private System.Windows.Forms.Panel panelGestionReservations_ListeReservations;
        private System.Windows.Forms.DataGridView dgGestionReservations_ListeReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdOutil;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateRetour;
        private System.Windows.Forms.Label lblGestionReservations_Titre2;
    }
}