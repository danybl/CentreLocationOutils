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
            this.menuGestionLocations = new System.Windows.Forms.MenuStrip();
            this.mItemGestionLocations_Accueil = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Gestionnaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_Apropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionLocations_SigneInterrogation = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGestionLocations_InfoLocation = new System.Windows.Forms.Panel();
            this.btnGestionLocations_Rechercher = new System.Windows.Forms.Button();
            this.btnGestionLocations_Annuler = new System.Windows.Forms.Button();
            this.btnGestionLocations_Renouveler = new System.Windows.Forms.Button();
            this.btnGestionLocations_Ajouter = new System.Windows.Forms.Button();
            this.tbGestionLocations_DateRetour = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_DateLimite = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_DateLocation = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_Depot = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_IdOutil = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_IdEmploye = new System.Windows.Forms.TextBox();
            this.tbGestionLocations_IdClient = new System.Windows.Forms.TextBox();
            this.lblGestionLocations_DateRetour = new System.Windows.Forms.Label();
            this.lblGestionLocations_DateLimite = new System.Windows.Forms.Label();
            this.lblGestionLocations_DateLocation = new System.Windows.Forms.Label();
            this.lblGestionLocations_Depot = new System.Windows.Forms.Label();
            this.lblGestionLocations_IdOutil = new System.Windows.Forms.Label();
            this.lblGestionLocations_IdEmploye = new System.Windows.Forms.Label();
            this.lblGestionLocations_IdClient = new System.Windows.Forms.Label();
            this.tbGestionLocations_IdLocation = new System.Windows.Forms.TextBox();
            this.lblGestionLocations_IdLocation = new System.Windows.Forms.Label();
            this.lblGestionLocations_Titre1 = new System.Windows.Forms.Label();
            this.panelGestionLocations_ListeLocations = new System.Windows.Forms.Panel();
            this.dgGestionLocations_ListeLocations = new System.Windows.Forms.DataGridView();
            this.columnIDLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdEmploye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdOutil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionLocations_Titre2 = new System.Windows.Forms.Label();
            this.menuGestionLocations.SuspendLayout();
            this.panelGestionLocations_InfoLocation.SuspendLayout();
            this.panelGestionLocations_ListeLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionLocations_ListeLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGestionLocations
            // 
            this.menuGestionLocations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionLocations_Accueil,
            this.mItemGestionLocations_Option,
            this.mItemGestionClients_Aide});
            this.menuGestionLocations.Location = new System.Drawing.Point(0, 0);
            this.menuGestionLocations.Name = "menuGestionLocations";
            this.menuGestionLocations.Size = new System.Drawing.Size(784, 24);
            this.menuGestionLocations.TabIndex = 25;
            this.menuGestionLocations.Text = "menuStrip1";
            // 
            // mItemGestionLocations_Accueil
            // 
            this.mItemGestionLocations_Accueil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionLocations_Gestionnaire,
            this.mItemGestionLocations_Connexion,
            this.mItemGestionLocations_Deconnexion,
            this.mItemGestionLocations_Quitter});
            this.mItemGestionLocations_Accueil.Name = "mItemGestionLocations_Accueil";
            this.mItemGestionLocations_Accueil.Size = new System.Drawing.Size(58, 20);
            this.mItemGestionLocations_Accueil.Text = "Accueil";
            // 
            // mItemGestionLocations_Gestionnaire
            // 
            this.mItemGestionLocations_Gestionnaire.Name = "mItemGestionLocations_Gestionnaire";
            this.mItemGestionLocations_Gestionnaire.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionLocations_Gestionnaire.Text = "Gestionnaire";
            // 
            // mItemGestionLocations_Connexion
            // 
            this.mItemGestionLocations_Connexion.Name = "mItemGestionLocations_Connexion";
            this.mItemGestionLocations_Connexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionLocations_Connexion.Text = "Connexion";
            // 
            // mItemGestionLocations_Deconnexion
            // 
            this.mItemGestionLocations_Deconnexion.Name = "mItemGestionLocations_Deconnexion";
            this.mItemGestionLocations_Deconnexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionLocations_Deconnexion.Text = "Deconnexion";
            // 
            // mItemGestionLocations_Quitter
            // 
            this.mItemGestionLocations_Quitter.Name = "mItemGestionLocations_Quitter";
            this.mItemGestionLocations_Quitter.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionLocations_Quitter.Text = "Quitter";
            // 
            // mItemGestionLocations_Option
            // 
            this.mItemGestionLocations_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionLocations_Parametres});
            this.mItemGestionLocations_Option.Name = "mItemGestionLocations_Option";
            this.mItemGestionLocations_Option.Size = new System.Drawing.Size(61, 20);
            this.mItemGestionLocations_Option.Text = "Options";
            // 
            // mItemGestionLocations_Parametres
            // 
            this.mItemGestionLocations_Parametres.Name = "mItemGestionLocations_Parametres";
            this.mItemGestionLocations_Parametres.Size = new System.Drawing.Size(133, 22);
            this.mItemGestionLocations_Parametres.Text = "Paramètres";
            // 
            // mItemGestionClients_Aide
            // 
            this.mItemGestionClients_Aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionLocations_Apropos,
            this.mItemGestionLocations_SigneInterrogation});
            this.mItemGestionClients_Aide.Name = "mItemGestionClients_Aide";
            this.mItemGestionClients_Aide.Size = new System.Drawing.Size(43, 20);
            this.mItemGestionClients_Aide.Text = "Aide";
            // 
            // mItemGestionLocations_Apropos
            // 
            this.mItemGestionLocations_Apropos.Name = "mItemGestionLocations_Apropos";
            this.mItemGestionLocations_Apropos.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionLocations_Apropos.Text = "à propos de nous";
            // 
            // mItemGestionLocations_SigneInterrogation
            // 
            this.mItemGestionLocations_SigneInterrogation.Name = "mItemGestionLocations_SigneInterrogation";
            this.mItemGestionLocations_SigneInterrogation.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionLocations_SigneInterrogation.Text = "?";
            // 
            // panelGestionLocations_InfoLocation
            // 
            this.panelGestionLocations_InfoLocation.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionLocations_InfoLocation.Controls.Add(this.btnGestionLocations_Rechercher);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.btnGestionLocations_Annuler);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.btnGestionLocations_Renouveler);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.btnGestionLocations_Ajouter);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_DateRetour);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_DateLimite);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_DateLocation);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_Depot);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_IdOutil);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_IdEmploye);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_IdClient);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_DateRetour);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_DateLimite);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_DateLocation);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_Depot);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_IdOutil);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_IdEmploye);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_IdClient);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.tbGestionLocations_IdLocation);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_IdLocation);
            this.panelGestionLocations_InfoLocation.Controls.Add(this.lblGestionLocations_Titre1);
            this.panelGestionLocations_InfoLocation.Location = new System.Drawing.Point(10, 27);
            this.panelGestionLocations_InfoLocation.Name = "panelGestionLocations_InfoLocation";
            this.panelGestionLocations_InfoLocation.Size = new System.Drawing.Size(762, 237);
            this.panelGestionLocations_InfoLocation.TabIndex = 26;
            // 
            // btnGestionLocations_Rechercher
            // 
            this.btnGestionLocations_Rechercher.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGestionLocations_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Rechercher.Image")));
            this.btnGestionLocations_Rechercher.Location = new System.Drawing.Point(373, 180);
            this.btnGestionLocations_Rechercher.Name = "btnGestionLocations_Rechercher";
            this.btnGestionLocations_Rechercher.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Rechercher.TabIndex = 22;
            this.btnGestionLocations_Rechercher.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Annuler
            // 
            this.btnGestionLocations_Annuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnGestionLocations_Annuler.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Annuler.Image")));
            this.btnGestionLocations_Annuler.Location = new System.Drawing.Point(593, 180);
            this.btnGestionLocations_Annuler.Name = "btnGestionLocations_Annuler";
            this.btnGestionLocations_Annuler.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Annuler.TabIndex = 21;
            this.btnGestionLocations_Annuler.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Renouveler
            // 
            this.btnGestionLocations_Renouveler.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGestionLocations_Renouveler.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Renouveler.Image")));
            this.btnGestionLocations_Renouveler.Location = new System.Drawing.Point(519, 180);
            this.btnGestionLocations_Renouveler.Name = "btnGestionLocations_Renouveler";
            this.btnGestionLocations_Renouveler.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Renouveler.TabIndex = 20;
            this.btnGestionLocations_Renouveler.UseVisualStyleBackColor = false;
            // 
            // btnGestionLocations_Ajouter
            // 
            this.btnGestionLocations_Ajouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGestionLocations_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionLocations_Ajouter.Image")));
            this.btnGestionLocations_Ajouter.Location = new System.Drawing.Point(446, 180);
            this.btnGestionLocations_Ajouter.Name = "btnGestionLocations_Ajouter";
            this.btnGestionLocations_Ajouter.Size = new System.Drawing.Size(50, 30);
            this.btnGestionLocations_Ajouter.TabIndex = 19;
            this.btnGestionLocations_Ajouter.UseVisualStyleBackColor = false;
            // 
            // tbGestionLocations_DateRetour
            // 
            this.tbGestionLocations_DateRetour.Location = new System.Drawing.Point(519, 124);
            this.tbGestionLocations_DateRetour.Name = "tbGestionLocations_DateRetour";
            this.tbGestionLocations_DateRetour.Size = new System.Drawing.Size(157, 20);
            this.tbGestionLocations_DateRetour.TabIndex = 18;
            // 
            // tbGestionLocations_DateLimite
            // 
            this.tbGestionLocations_DateLimite.Location = new System.Drawing.Point(519, 93);
            this.tbGestionLocations_DateLimite.Name = "tbGestionLocations_DateLimite";
            this.tbGestionLocations_DateLimite.ReadOnly = true;
            this.tbGestionLocations_DateLimite.Size = new System.Drawing.Size(157, 20);
            this.tbGestionLocations_DateLimite.TabIndex = 17;
            // 
            // tbGestionLocations_DateLocation
            // 
            this.tbGestionLocations_DateLocation.Location = new System.Drawing.Point(519, 62);
            this.tbGestionLocations_DateLocation.Name = "tbGestionLocations_DateLocation";
            this.tbGestionLocations_DateLocation.ReadOnly = true;
            this.tbGestionLocations_DateLocation.Size = new System.Drawing.Size(157, 20);
            this.tbGestionLocations_DateLocation.TabIndex = 16;
            // 
            // tbGestionLocations_Depot
            // 
            this.tbGestionLocations_Depot.Location = new System.Drawing.Point(116, 184);
            this.tbGestionLocations_Depot.Name = "tbGestionLocations_Depot";
            this.tbGestionLocations_Depot.Size = new System.Drawing.Size(202, 20);
            this.tbGestionLocations_Depot.TabIndex = 15;
            // 
            // tbGestionLocations_IdOutil
            // 
            this.tbGestionLocations_IdOutil.Location = new System.Drawing.Point(116, 153);
            this.tbGestionLocations_IdOutil.Name = "tbGestionLocations_IdOutil";
            this.tbGestionLocations_IdOutil.Size = new System.Drawing.Size(67, 20);
            this.tbGestionLocations_IdOutil.TabIndex = 14;
            // 
            // tbGestionLocations_IdEmploye
            // 
            this.tbGestionLocations_IdEmploye.Location = new System.Drawing.Point(116, 124);
            this.tbGestionLocations_IdEmploye.Name = "tbGestionLocations_IdEmploye";
            this.tbGestionLocations_IdEmploye.Size = new System.Drawing.Size(67, 20);
            this.tbGestionLocations_IdEmploye.TabIndex = 13;
            // 
            // tbGestionLocations_IdClient
            // 
            this.tbGestionLocations_IdClient.Location = new System.Drawing.Point(116, 93);
            this.tbGestionLocations_IdClient.Name = "tbGestionLocations_IdClient";
            this.tbGestionLocations_IdClient.Size = new System.Drawing.Size(67, 20);
            this.tbGestionLocations_IdClient.TabIndex = 12;
            // 
            // lblGestionLocations_DateRetour
            // 
            this.lblGestionLocations_DateRetour.AutoSize = true;
            this.lblGestionLocations_DateRetour.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_DateRetour.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_DateRetour.Location = new System.Drawing.Point(355, 128);
            this.lblGestionLocations_DateRetour.Name = "lblGestionLocations_DateRetour";
            this.lblGestionLocations_DateRetour.Size = new System.Drawing.Size(104, 16);
            this.lblGestionLocations_DateRetour.TabIndex = 11;
            this.lblGestionLocations_DateRetour.Text = "DATE RETOUR : ";
            // 
            // lblGestionLocations_DateLimite
            // 
            this.lblGestionLocations_DateLimite.AutoSize = true;
            this.lblGestionLocations_DateLimite.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_DateLimite.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_DateLimite.Location = new System.Drawing.Point(355, 97);
            this.lblGestionLocations_DateLimite.Name = "lblGestionLocations_DateLimite";
            this.lblGestionLocations_DateLimite.Size = new System.Drawing.Size(98, 16);
            this.lblGestionLocations_DateLimite.TabIndex = 10;
            this.lblGestionLocations_DateLimite.Text = "DATE LIMITIE :";
            // 
            // lblGestionLocations_DateLocation
            // 
            this.lblGestionLocations_DateLocation.AutoSize = true;
            this.lblGestionLocations_DateLocation.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_DateLocation.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_DateLocation.Location = new System.Drawing.Point(355, 66);
            this.lblGestionLocations_DateLocation.Name = "lblGestionLocations_DateLocation";
            this.lblGestionLocations_DateLocation.Size = new System.Drawing.Size(111, 16);
            this.lblGestionLocations_DateLocation.TabIndex = 9;
            this.lblGestionLocations_DateLocation.Text = "DATE LOCATION :";
            // 
            // lblGestionLocations_Depot
            // 
            this.lblGestionLocations_Depot.AutoSize = true;
            this.lblGestionLocations_Depot.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_Depot.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_Depot.Location = new System.Drawing.Point(15, 188);
            this.lblGestionLocations_Depot.Name = "lblGestionLocations_Depot";
            this.lblGestionLocations_Depot.Size = new System.Drawing.Size(55, 16);
            this.lblGestionLocations_Depot.TabIndex = 8;
            this.lblGestionLocations_Depot.Text = "DÉPÔT :";
            // 
            // lblGestionLocations_IdOutil
            // 
            this.lblGestionLocations_IdOutil.AutoSize = true;
            this.lblGestionLocations_IdOutil.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_IdOutil.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_IdOutil.Location = new System.Drawing.Point(15, 157);
            this.lblGestionLocations_IdOutil.Name = "lblGestionLocations_IdOutil";
            this.lblGestionLocations_IdOutil.Size = new System.Drawing.Size(52, 16);
            this.lblGestionLocations_IdOutil.TabIndex = 7;
            this.lblGestionLocations_IdOutil.Text = "OUTIL :";
            // 
            // lblGestionLocations_IdEmploye
            // 
            this.lblGestionLocations_IdEmploye.AutoSize = true;
            this.lblGestionLocations_IdEmploye.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_IdEmploye.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_IdEmploye.Location = new System.Drawing.Point(15, 128);
            this.lblGestionLocations_IdEmploye.Name = "lblGestionLocations_IdEmploye";
            this.lblGestionLocations_IdEmploye.Size = new System.Drawing.Size(90, 16);
            this.lblGestionLocations_IdEmploye.TabIndex = 6;
            this.lblGestionLocations_IdEmploye.Text = "EMPLOYÉ(E) :";
            // 
            // lblGestionLocations_IdClient
            // 
            this.lblGestionLocations_IdClient.AutoSize = true;
            this.lblGestionLocations_IdClient.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_IdClient.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_IdClient.Location = new System.Drawing.Point(15, 97);
            this.lblGestionLocations_IdClient.Name = "lblGestionLocations_IdClient";
            this.lblGestionLocations_IdClient.Size = new System.Drawing.Size(63, 16);
            this.lblGestionLocations_IdClient.TabIndex = 5;
            this.lblGestionLocations_IdClient.Text = "CLIENT : ";
            // 
            // tbGestionLocations_IdLocation
            // 
            this.tbGestionLocations_IdLocation.Location = new System.Drawing.Point(116, 62);
            this.tbGestionLocations_IdLocation.Name = "tbGestionLocations_IdLocation";
            this.tbGestionLocations_IdLocation.ReadOnly = true;
            this.tbGestionLocations_IdLocation.Size = new System.Drawing.Size(67, 20);
            this.tbGestionLocations_IdLocation.TabIndex = 4;
            // 
            // lblGestionLocations_IdLocation
            // 
            this.lblGestionLocations_IdLocation.AutoSize = true;
            this.lblGestionLocations_IdLocation.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_IdLocation.ForeColor = System.Drawing.Color.White;
            this.lblGestionLocations_IdLocation.Location = new System.Drawing.Point(15, 66);
            this.lblGestionLocations_IdLocation.Name = "lblGestionLocations_IdLocation";
            this.lblGestionLocations_IdLocation.Size = new System.Drawing.Size(28, 16);
            this.lblGestionLocations_IdLocation.TabIndex = 3;
            this.lblGestionLocations_IdLocation.Text = "ID :";
            // 
            // lblGestionLocations_Titre1
            // 
            this.lblGestionLocations_Titre1.AutoSize = true;
            this.lblGestionLocations_Titre1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_Titre1.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionLocations_Titre1.Location = new System.Drawing.Point(264, 20);
            this.lblGestionLocations_Titre1.Name = "lblGestionLocations_Titre1";
            this.lblGestionLocations_Titre1.Size = new System.Drawing.Size(253, 19);
            this.lblGestionLocations_Titre1.TabIndex = 2;
            this.lblGestionLocations_Titre1.Text = "Information sur la location";
            // 
            // panelGestionLocations_ListeLocations
            // 
            this.panelGestionLocations_ListeLocations.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionLocations_ListeLocations.Controls.Add(this.dgGestionLocations_ListeLocations);
            this.panelGestionLocations_ListeLocations.Controls.Add(this.lblGestionLocations_Titre2);
            this.panelGestionLocations_ListeLocations.Location = new System.Drawing.Point(10, 273);
            this.panelGestionLocations_ListeLocations.Name = "panelGestionLocations_ListeLocations";
            this.panelGestionLocations_ListeLocations.Size = new System.Drawing.Size(762, 276);
            this.panelGestionLocations_ListeLocations.TabIndex = 24;
            // 
            // dgGestionLocations_ListeLocations
            // 
            this.dgGestionLocations_ListeLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionLocations_ListeLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIDLocation,
            this.columnIdClient,
            this.columnIdEmploye,
            this.columnIdOutil,
            this.columnDepot,
            this.columnDateLocation,
            this.columnDateLimite,
            this.columnDateRetour});
            this.dgGestionLocations_ListeLocations.Location = new System.Drawing.Point(18, 48);
            this.dgGestionLocations_ListeLocations.Name = "dgGestionLocations_ListeLocations";
            this.dgGestionLocations_ListeLocations.Size = new System.Drawing.Size(731, 209);
            this.dgGestionLocations_ListeLocations.TabIndex = 1;
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
            // lblGestionLocations_Titre2
            // 
            this.lblGestionLocations_Titre2.AutoSize = true;
            this.lblGestionLocations_Titre2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionLocations_Titre2.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionLocations_Titre2.Location = new System.Drawing.Point(304, 20);
            this.lblGestionLocations_Titre2.Name = "lblGestionLocations_Titre2";
            this.lblGestionLocations_Titre2.Size = new System.Drawing.Size(172, 19);
            this.lblGestionLocations_Titre2.TabIndex = 0;
            this.lblGestionLocations_Titre2.Text = "Liste des locations";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelGestionLocations_ListeLocations);
            this.Controls.Add(this.panelGestionLocations_InfoLocation);
            this.Controls.Add(this.menuGestionLocations);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.menuGestionLocations.ResumeLayout(false);
            this.menuGestionLocations.PerformLayout();
            this.panelGestionLocations_InfoLocation.ResumeLayout(false);
            this.panelGestionLocations_InfoLocation.PerformLayout();
            this.panelGestionLocations_ListeLocations.ResumeLayout(false);
            this.panelGestionLocations_ListeLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionLocations_ListeLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGestionLocations;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Accueil;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Gestionnaire;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Connexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Deconnexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Quitter;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Option;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Parametres;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Aide;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_Apropos;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionLocations_SigneInterrogation;
        private System.Windows.Forms.Panel panelGestionLocations_InfoLocation;
        private System.Windows.Forms.Button btnGestionLocations_Rechercher;
        private System.Windows.Forms.Button btnGestionLocations_Annuler;
        private System.Windows.Forms.Button btnGestionLocations_Renouveler;
        private System.Windows.Forms.Button btnGestionLocations_Ajouter;
        private System.Windows.Forms.TextBox tbGestionLocations_DateRetour;
        private System.Windows.Forms.TextBox tbGestionLocations_DateLimite;
        private System.Windows.Forms.TextBox tbGestionLocations_DateLocation;
        private System.Windows.Forms.TextBox tbGestionLocations_Depot;
        private System.Windows.Forms.TextBox tbGestionLocations_IdOutil;
        private System.Windows.Forms.TextBox tbGestionLocations_IdEmploye;
        private System.Windows.Forms.TextBox tbGestionLocations_IdClient;
        private System.Windows.Forms.Label lblGestionLocations_DateRetour;
        private System.Windows.Forms.Label lblGestionLocations_DateLimite;
        private System.Windows.Forms.Label lblGestionLocations_DateLocation;
        private System.Windows.Forms.Label lblGestionLocations_Depot;
        private System.Windows.Forms.Label lblGestionLocations_IdOutil;
        private System.Windows.Forms.Label lblGestionLocations_IdEmploye;
        private System.Windows.Forms.Label lblGestionLocations_IdClient;
        private System.Windows.Forms.TextBox tbGestionLocations_IdLocation;
        private System.Windows.Forms.Label lblGestionLocations_IdLocation;
        private System.Windows.Forms.Label lblGestionLocations_Titre1;
        private System.Windows.Forms.Panel panelGestionLocations_ListeLocations;
        private System.Windows.Forms.DataGridView dgGestionLocations_ListeLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdEmploye;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdOutil;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateRetour;
        private System.Windows.Forms.Label lblGestionLocations_Titre2;
    }
}