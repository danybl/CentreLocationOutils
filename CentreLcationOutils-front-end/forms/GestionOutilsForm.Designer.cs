namespace CentreLcationOutils_front_end.forms
{
    partial class GestionOutilsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionOutilsForm));
            this.menuGestionOutils = new System.Windows.Forms.MenuStrip();
            this.mItemGestionOutils_Accueil = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Gestionnaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_Apropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionOutils_SigneInterrogation = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGestionOutils_ListeOutils = new System.Windows.Forms.Panel();
            this.dgGestionOutils_ListeOutils = new System.Windows.Forms.DataGridView();
            this.columnIdOutil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNomOutil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrixLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionOutils_ListeOutils = new System.Windows.Forms.Label();
            this.panelGestionOutils_InfoOutil = new System.Windows.Forms.Panel();
            this.btnGestionOutils_Rechercher = new System.Windows.Forms.Button();
            this.btnGestionOutils_Supprimer = new System.Windows.Forms.Button();
            this.btnGestionOutils_Modifier = new System.Windows.Forms.Button();
            this.btnGestionOutils_Ajouter = new System.Windows.Forms.Button();
            this.tbGestionOutils_DateAcquisition = new System.Windows.Forms.TextBox();
            this.tbGestionOutils_NumeroSerie = new System.Windows.Forms.TextBox();
            this.tbGestionOutils_IdCategorie = new System.Windows.Forms.TextBox();
            this.tbGestionOutils_PrixLocation = new System.Windows.Forms.TextBox();
            this.tbGestionOutils_Description = new System.Windows.Forms.TextBox();
            this.tbGestionOutils_Nom = new System.Windows.Forms.TextBox();
            this.lblGestionOutils_DateAcquisition = new System.Windows.Forms.Label();
            this.lblGestionOutils_NumeroSerie = new System.Windows.Forms.Label();
            this.lblGestionOutils_IdCategorie = new System.Windows.Forms.Label();
            this.lblGestionOutils_PrixLocation = new System.Windows.Forms.Label();
            this.lblGestionOutils_Description = new System.Windows.Forms.Label();
            this.lblGestionOutils_Nom = new System.Windows.Forms.Label();
            this.tbGestionOutils_Id = new System.Windows.Forms.TextBox();
            this.lblGestionOutils_Id = new System.Windows.Forms.Label();
            this.lblGestionOutils_InfoOutils = new System.Windows.Forms.Label();
            this.errorProviderOutil = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuGestionOutils.SuspendLayout();
            this.panelGestionOutils_ListeOutils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionOutils_ListeOutils)).BeginInit();
            this.panelGestionOutils_InfoOutil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOutil)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGestionOutils
            // 
            this.menuGestionOutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionOutils_Accueil,
            this.mItemGestionOutils_Options,
            this.mItemGestionOutils_Aide});
            this.menuGestionOutils.Location = new System.Drawing.Point(0, 0);
            this.menuGestionOutils.Name = "menuGestionOutils";
            this.menuGestionOutils.Size = new System.Drawing.Size(784, 24);
            this.menuGestionOutils.TabIndex = 0;
            this.menuGestionOutils.Text = "menuStrip1";
            // 
            // mItemGestionOutils_Accueil
            // 
            this.mItemGestionOutils_Accueil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionOutils_Gestionnaire,
            this.mItemGestionOutils_Connexion,
            this.mItemGestionOutils_Deconnexion,
            this.mItemGestionOutils_Quitter});
            this.mItemGestionOutils_Accueil.Name = "mItemGestionOutils_Accueil";
            this.mItemGestionOutils_Accueil.Size = new System.Drawing.Size(58, 20);
            this.mItemGestionOutils_Accueil.Text = "Accueil";
            // 
            // mItemGestionOutils_Gestionnaire
            // 
            this.mItemGestionOutils_Gestionnaire.Name = "mItemGestionOutils_Gestionnaire";
            this.mItemGestionOutils_Gestionnaire.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionOutils_Gestionnaire.Text = "Gestionnaire";
            // 
            // mItemGestionOutils_Connexion
            // 
            this.mItemGestionOutils_Connexion.Name = "mItemGestionOutils_Connexion";
            this.mItemGestionOutils_Connexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionOutils_Connexion.Text = "Connexion";
            // 
            // mItemGestionOutils_Deconnexion
            // 
            this.mItemGestionOutils_Deconnexion.Name = "mItemGestionOutils_Deconnexion";
            this.mItemGestionOutils_Deconnexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionOutils_Deconnexion.Text = "Deconnexion";
            // 
            // mItemGestionOutils_Quitter
            // 
            this.mItemGestionOutils_Quitter.Name = "mItemGestionOutils_Quitter";
            this.mItemGestionOutils_Quitter.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionOutils_Quitter.Text = "Quitter";
            // 
            // mItemGestionOutils_Options
            // 
            this.mItemGestionOutils_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionOutils_Parametres});
            this.mItemGestionOutils_Options.Name = "mItemGestionOutils_Options";
            this.mItemGestionOutils_Options.Size = new System.Drawing.Size(61, 20);
            this.mItemGestionOutils_Options.Text = "Options";
            // 
            // mItemGestionOutils_Parametres
            // 
            this.mItemGestionOutils_Parametres.Name = "mItemGestionOutils_Parametres";
            this.mItemGestionOutils_Parametres.Size = new System.Drawing.Size(133, 22);
            this.mItemGestionOutils_Parametres.Text = "Paramètres";
            // 
            // mItemGestionOutils_Aide
            // 
            this.mItemGestionOutils_Aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionOutils_Apropos,
            this.mItemGestionOutils_SigneInterrogation});
            this.mItemGestionOutils_Aide.Name = "mItemGestionOutils_Aide";
            this.mItemGestionOutils_Aide.Size = new System.Drawing.Size(43, 20);
            this.mItemGestionOutils_Aide.Text = "Aide";
            // 
            // mItemGestionOutils_Apropos
            // 
            this.mItemGestionOutils_Apropos.Name = "mItemGestionOutils_Apropos";
            this.mItemGestionOutils_Apropos.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionOutils_Apropos.Text = "à propos de nous";
            // 
            // mItemGestionOutils_SigneInterrogation
            // 
            this.mItemGestionOutils_SigneInterrogation.Name = "mItemGestionOutils_SigneInterrogation";
            this.mItemGestionOutils_SigneInterrogation.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionOutils_SigneInterrogation.Text = "?";
            // 
            // panelGestionOutils_ListeOutils
            // 
            this.panelGestionOutils_ListeOutils.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionOutils_ListeOutils.Controls.Add(this.dgGestionOutils_ListeOutils);
            this.panelGestionOutils_ListeOutils.Controls.Add(this.lblGestionOutils_ListeOutils);
            this.panelGestionOutils_ListeOutils.Location = new System.Drawing.Point(10, 36);
            this.panelGestionOutils_ListeOutils.Name = "panelGestionOutils_ListeOutils";
            this.panelGestionOutils_ListeOutils.Size = new System.Drawing.Size(762, 276);
            this.panelGestionOutils_ListeOutils.TabIndex = 2;
            // 
            // dgGestionOutils_ListeOutils
            // 
            this.dgGestionOutils_ListeOutils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionOutils_ListeOutils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdOutil,
            this.columnIdCategorie,
            this.columnNumSerie,
            this.columnNomOutil,
            this.columnDescription,
            this.columnPrixLocation,
            this.columnDateAcquisition});
            this.dgGestionOutils_ListeOutils.Location = new System.Drawing.Point(18, 42);
            this.dgGestionOutils_ListeOutils.Name = "dgGestionOutils_ListeOutils";
            this.dgGestionOutils_ListeOutils.Size = new System.Drawing.Size(731, 209);
            this.dgGestionOutils_ListeOutils.TabIndex = 1;
            // 
            // columnIdOutil
            // 
            this.columnIdOutil.HeaderText = "ID";
            this.columnIdOutil.Name = "columnIdOutil";
            this.columnIdOutil.ReadOnly = true;
            // 
            // columnIdCategorie
            // 
            this.columnIdCategorie.HeaderText = "Categorie";
            this.columnIdCategorie.Name = "columnIdCategorie";
            // 
            // columnNumSerie
            // 
            this.columnNumSerie.HeaderText = "NumeroSerie";
            this.columnNumSerie.Name = "columnNumSerie";
            // 
            // columnNomOutil
            // 
            this.columnNomOutil.HeaderText = "Nom";
            this.columnNomOutil.Name = "columnNomOutil";
            this.columnNomOutil.ToolTipText = "Nom";
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.Name = "columnDescription";
            // 
            // columnPrixLocation
            // 
            this.columnPrixLocation.HeaderText = "PrixLocation";
            this.columnPrixLocation.Name = "columnPrixLocation";
            // 
            // columnDateAcquisition
            // 
            this.columnDateAcquisition.HeaderText = "DateAcquisition";
            this.columnDateAcquisition.Name = "columnDateAcquisition";
            // 
            // lblGestionOutils_ListeOutils
            // 
            this.lblGestionOutils_ListeOutils.AutoSize = true;
            this.lblGestionOutils_ListeOutils.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_ListeOutils.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionOutils_ListeOutils.Location = new System.Drawing.Point(304, 20);
            this.lblGestionOutils_ListeOutils.Name = "lblGestionOutils_ListeOutils";
            this.lblGestionOutils_ListeOutils.Size = new System.Drawing.Size(143, 19);
            this.lblGestionOutils_ListeOutils.TabIndex = 0;
            this.lblGestionOutils_ListeOutils.Text = "Liste des outils";
            // 
            // panelGestionOutils_InfoOutil
            // 
            this.panelGestionOutils_InfoOutil.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionOutils_InfoOutil.Controls.Add(this.btnGestionOutils_Rechercher);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.btnGestionOutils_Supprimer);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.btnGestionOutils_Modifier);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.btnGestionOutils_Ajouter);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_DateAcquisition);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_NumeroSerie);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_IdCategorie);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_PrixLocation);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_Description);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_Nom);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_DateAcquisition);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_NumeroSerie);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_IdCategorie);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_PrixLocation);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_Description);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_Nom);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.tbGestionOutils_Id);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_Id);
            this.panelGestionOutils_InfoOutil.Controls.Add(this.lblGestionOutils_InfoOutils);
            this.panelGestionOutils_InfoOutil.Location = new System.Drawing.Point(10, 318);
            this.panelGestionOutils_InfoOutil.Name = "panelGestionOutils_InfoOutil";
            this.panelGestionOutils_InfoOutil.Size = new System.Drawing.Size(762, 237);
            this.panelGestionOutils_InfoOutil.TabIndex = 3;
            // 
            // btnGestionOutils_Rechercher
            // 
            this.btnGestionOutils_Rechercher.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGestionOutils_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionOutils_Rechercher.Image")));
            this.btnGestionOutils_Rechercher.Location = new System.Drawing.Point(411, 180);
            this.btnGestionOutils_Rechercher.Name = "btnGestionOutils_Rechercher";
            this.btnGestionOutils_Rechercher.Size = new System.Drawing.Size(50, 30);
            this.btnGestionOutils_Rechercher.TabIndex = 22;
            this.btnGestionOutils_Rechercher.UseVisualStyleBackColor = false;
            this.btnGestionOutils_Rechercher.Click += new System.EventHandler(this.btnGestionOutils_Rechercher_Click);
            // 
            // btnGestionOutils_Supprimer
            // 
            this.btnGestionOutils_Supprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnGestionOutils_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionOutils_Supprimer.Image")));
            this.btnGestionOutils_Supprimer.Location = new System.Drawing.Point(621, 180);
            this.btnGestionOutils_Supprimer.Name = "btnGestionOutils_Supprimer";
            this.btnGestionOutils_Supprimer.Size = new System.Drawing.Size(50, 30);
            this.btnGestionOutils_Supprimer.TabIndex = 21;
            this.btnGestionOutils_Supprimer.UseVisualStyleBackColor = false;
            this.btnGestionOutils_Supprimer.Click += new System.EventHandler(this.btnGestionOutils_Supprimer_Click);
            // 
            // btnGestionOutils_Modifier
            // 
            this.btnGestionOutils_Modifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGestionOutils_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionOutils_Modifier.Image")));
            this.btnGestionOutils_Modifier.Location = new System.Drawing.Point(556, 180);
            this.btnGestionOutils_Modifier.Name = "btnGestionOutils_Modifier";
            this.btnGestionOutils_Modifier.Size = new System.Drawing.Size(50, 30);
            this.btnGestionOutils_Modifier.TabIndex = 20;
            this.btnGestionOutils_Modifier.UseVisualStyleBackColor = false;
            this.btnGestionOutils_Modifier.Click += new System.EventHandler(this.btnGestionOutils_Modifier_Click);
            // 
            // btnGestionOutils_Ajouter
            // 
            this.btnGestionOutils_Ajouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGestionOutils_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionOutils_Ajouter.Image")));
            this.btnGestionOutils_Ajouter.Location = new System.Drawing.Point(483, 180);
            this.btnGestionOutils_Ajouter.Name = "btnGestionOutils_Ajouter";
            this.btnGestionOutils_Ajouter.Size = new System.Drawing.Size(50, 30);
            this.btnGestionOutils_Ajouter.TabIndex = 19;
            this.btnGestionOutils_Ajouter.UseVisualStyleBackColor = false;
            this.btnGestionOutils_Ajouter.Click += new System.EventHandler(this.btnGestionOutils_Ajouter_Click);
            // 
            // tbGestionOutils_DateAcquisition
            // 
            this.tbGestionOutils_DateAcquisition.Location = new System.Drawing.Point(556, 93);
            this.tbGestionOutils_DateAcquisition.Name = "tbGestionOutils_DateAcquisition";
            this.tbGestionOutils_DateAcquisition.Size = new System.Drawing.Size(157, 20);
            this.tbGestionOutils_DateAcquisition.TabIndex = 18;
            // 
            // tbGestionOutils_NumeroSerie
            // 
            this.tbGestionOutils_NumeroSerie.Location = new System.Drawing.Point(556, 62);
            this.tbGestionOutils_NumeroSerie.Name = "tbGestionOutils_NumeroSerie";
            this.tbGestionOutils_NumeroSerie.ReadOnly = true;
            this.tbGestionOutils_NumeroSerie.Size = new System.Drawing.Size(157, 20);
            this.tbGestionOutils_NumeroSerie.TabIndex = 17;
            // 
            // tbGestionOutils_IdCategorie
            // 
            this.tbGestionOutils_IdCategorie.Location = new System.Drawing.Point(148, 93);
            this.tbGestionOutils_IdCategorie.Name = "tbGestionOutils_IdCategorie";
            this.tbGestionOutils_IdCategorie.ReadOnly = true;
            this.tbGestionOutils_IdCategorie.Size = new System.Drawing.Size(67, 20);
            this.tbGestionOutils_IdCategorie.TabIndex = 16;
            // 
            // tbGestionOutils_PrixLocation
            // 
            this.tbGestionOutils_PrixLocation.Location = new System.Drawing.Point(148, 184);
            this.tbGestionOutils_PrixLocation.Name = "tbGestionOutils_PrixLocation";
            this.tbGestionOutils_PrixLocation.Size = new System.Drawing.Size(202, 20);
            this.tbGestionOutils_PrixLocation.TabIndex = 14;
            // 
            // tbGestionOutils_Description
            // 
            this.tbGestionOutils_Description.Location = new System.Drawing.Point(148, 155);
            this.tbGestionOutils_Description.Name = "tbGestionOutils_Description";
            this.tbGestionOutils_Description.Size = new System.Drawing.Size(202, 20);
            this.tbGestionOutils_Description.TabIndex = 13;
            // 
            // tbGestionOutils_Nom
            // 
            this.tbGestionOutils_Nom.Location = new System.Drawing.Point(148, 124);
            this.tbGestionOutils_Nom.Name = "tbGestionOutils_Nom";
            this.tbGestionOutils_Nom.Size = new System.Drawing.Size(202, 20);
            this.tbGestionOutils_Nom.TabIndex = 12;
            // 
            // lblGestionOutils_DateAcquisition
            // 
            this.lblGestionOutils_DateAcquisition.AutoSize = true;
            this.lblGestionOutils_DateAcquisition.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_DateAcquisition.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_DateAcquisition.Location = new System.Drawing.Point(392, 97);
            this.lblGestionOutils_DateAcquisition.Name = "lblGestionOutils_DateAcquisition";
            this.lblGestionOutils_DateAcquisition.Size = new System.Drawing.Size(141, 16);
            this.lblGestionOutils_DateAcquisition.TabIndex = 11;
            this.lblGestionOutils_DateAcquisition.Text = "DATE D\'ACQUISITION :";
            // 
            // lblGestionOutils_NumeroSerie
            // 
            this.lblGestionOutils_NumeroSerie.AutoSize = true;
            this.lblGestionOutils_NumeroSerie.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_NumeroSerie.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_NumeroSerie.Location = new System.Drawing.Point(392, 66);
            this.lblGestionOutils_NumeroSerie.Name = "lblGestionOutils_NumeroSerie";
            this.lblGestionOutils_NumeroSerie.Size = new System.Drawing.Size(127, 16);
            this.lblGestionOutils_NumeroSerie.TabIndex = 10;
            this.lblGestionOutils_NumeroSerie.Text = "NUMÉRO DE SERIE :";
            // 
            // lblGestionOutils_IdCategorie
            // 
            this.lblGestionOutils_IdCategorie.AutoSize = true;
            this.lblGestionOutils_IdCategorie.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_IdCategorie.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_IdCategorie.Location = new System.Drawing.Point(15, 95);
            this.lblGestionOutils_IdCategorie.Name = "lblGestionOutils_IdCategorie";
            this.lblGestionOutils_IdCategorie.Size = new System.Drawing.Size(85, 16);
            this.lblGestionOutils_IdCategorie.TabIndex = 9;
            this.lblGestionOutils_IdCategorie.Text = "CATÉGORIE :";
            // 
            // lblGestionOutils_PrixLocation
            // 
            this.lblGestionOutils_PrixLocation.AutoSize = true;
            this.lblGestionOutils_PrixLocation.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_PrixLocation.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_PrixLocation.Location = new System.Drawing.Point(15, 188);
            this.lblGestionOutils_PrixLocation.Name = "lblGestionOutils_PrixLocation";
            this.lblGestionOutils_PrixLocation.Size = new System.Drawing.Size(128, 16);
            this.lblGestionOutils_PrixLocation.TabIndex = 7;
            this.lblGestionOutils_PrixLocation.Text = "PRIX DE LOCATION :";
            // 
            // lblGestionOutils_Description
            // 
            this.lblGestionOutils_Description.AutoSize = true;
            this.lblGestionOutils_Description.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_Description.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_Description.Location = new System.Drawing.Point(15, 159);
            this.lblGestionOutils_Description.Name = "lblGestionOutils_Description";
            this.lblGestionOutils_Description.Size = new System.Drawing.Size(98, 16);
            this.lblGestionOutils_Description.TabIndex = 6;
            this.lblGestionOutils_Description.Text = "DESCRIPTION :";
            // 
            // lblGestionOutils_Nom
            // 
            this.lblGestionOutils_Nom.AutoSize = true;
            this.lblGestionOutils_Nom.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_Nom.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_Nom.Location = new System.Drawing.Point(15, 128);
            this.lblGestionOutils_Nom.Name = "lblGestionOutils_Nom";
            this.lblGestionOutils_Nom.Size = new System.Drawing.Size(42, 16);
            this.lblGestionOutils_Nom.TabIndex = 5;
            this.lblGestionOutils_Nom.Text = "NOM :";
            // 
            // tbGestionOutils_Id
            // 
            this.tbGestionOutils_Id.Location = new System.Drawing.Point(148, 62);
            this.tbGestionOutils_Id.Name = "tbGestionOutils_Id";
            this.tbGestionOutils_Id.ReadOnly = true;
            this.tbGestionOutils_Id.Size = new System.Drawing.Size(67, 20);
            this.tbGestionOutils_Id.TabIndex = 4;
            // 
            // lblGestionOutils_Id
            // 
            this.lblGestionOutils_Id.AutoSize = true;
            this.lblGestionOutils_Id.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_Id.ForeColor = System.Drawing.Color.White;
            this.lblGestionOutils_Id.Location = new System.Drawing.Point(15, 66);
            this.lblGestionOutils_Id.Name = "lblGestionOutils_Id";
            this.lblGestionOutils_Id.Size = new System.Drawing.Size(28, 16);
            this.lblGestionOutils_Id.TabIndex = 3;
            this.lblGestionOutils_Id.Text = "ID :";
            // 
            // lblGestionOutils_InfoOutils
            // 
            this.lblGestionOutils_InfoOutils.AutoSize = true;
            this.lblGestionOutils_InfoOutils.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionOutils_InfoOutils.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionOutils_InfoOutils.Location = new System.Drawing.Point(264, 20);
            this.lblGestionOutils_InfoOutils.Name = "lblGestionOutils_InfoOutils";
            this.lblGestionOutils_InfoOutils.Size = new System.Drawing.Size(214, 19);
            this.lblGestionOutils_InfoOutils.TabIndex = 2;
            this.lblGestionOutils_InfoOutils.Text = "Information sur l\'outil";
            // 
            // errorProviderOutil
            // 
            this.errorProviderOutil.ContainerControl = this;
            // 
            // GestionOutilsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelGestionOutils_InfoOutil);
            this.Controls.Add(this.panelGestionOutils_ListeOutils);
            this.Controls.Add(this.menuGestionOutils);
            this.MainMenuStrip = this.menuGestionOutils;
            this.Name = "GestionOutilsForm";
            this.Text = "Gestion Outils";
            this.menuGestionOutils.ResumeLayout(false);
            this.menuGestionOutils.PerformLayout();
            this.panelGestionOutils_ListeOutils.ResumeLayout(false);
            this.panelGestionOutils_ListeOutils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionOutils_ListeOutils)).EndInit();
            this.panelGestionOutils_InfoOutil.ResumeLayout(false);
            this.panelGestionOutils_InfoOutil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOutil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGestionOutils;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Accueil;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Connexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Deconnexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Quitter;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Options;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Parametres;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Aide;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Apropos;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_SigneInterrogation;
        private System.Windows.Forms.Panel panelGestionOutils_ListeOutils;
        private System.Windows.Forms.DataGridView dgGestionOutils_ListeOutils;
        private System.Windows.Forms.Label lblGestionOutils_ListeOutils;
        private System.Windows.Forms.Panel panelGestionOutils_InfoOutil;
        private System.Windows.Forms.Button btnGestionOutils_Rechercher;
        private System.Windows.Forms.Button btnGestionOutils_Supprimer;
        private System.Windows.Forms.Button btnGestionOutils_Modifier;
        private System.Windows.Forms.Button btnGestionOutils_Ajouter;
        private System.Windows.Forms.TextBox tbGestionOutils_DateAcquisition;
        private System.Windows.Forms.TextBox tbGestionOutils_NumeroSerie;
        private System.Windows.Forms.TextBox tbGestionOutils_IdCategorie;
        private System.Windows.Forms.TextBox tbGestionOutils_PrixLocation;
        private System.Windows.Forms.TextBox tbGestionOutils_Description;
        private System.Windows.Forms.TextBox tbGestionOutils_Nom;
        private System.Windows.Forms.Label lblGestionOutils_DateAcquisition;
        private System.Windows.Forms.Label lblGestionOutils_NumeroSerie;
        private System.Windows.Forms.Label lblGestionOutils_IdCategorie;
        private System.Windows.Forms.Label lblGestionOutils_PrixLocation;
        private System.Windows.Forms.Label lblGestionOutils_Description;
        private System.Windows.Forms.Label lblGestionOutils_Nom;
        private System.Windows.Forms.TextBox tbGestionOutils_Id;
        private System.Windows.Forms.Label lblGestionOutils_Id;
        private System.Windows.Forms.Label lblGestionOutils_InfoOutils;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdOutil;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNomOutil;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrixLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateAcquisition;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionOutils_Gestionnaire;
        private System.Windows.Forms.ErrorProvider errorProviderOutil;
    }
}