namespace CentreLcationOutils_front_end.forms
{
    partial class GestionClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientForm));
            this.menuGestionClients = new System.Windows.Forms.MenuStrip();
            this.mItemGestionClients_Accueil = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Gestionnaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Aide = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_Apropos = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGestionClients_SigneInterrogation = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGestionClients_ListeClients = new System.Windows.Forms.Panel();
            this.dgGestionClients_ListeClients = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateInscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNbLocations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLimiteLocations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGestionClients_ListeClients = new System.Windows.Forms.Label();
            this.panelGestionClients_InfoClient = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGestionAccueil_Rechercher = new System.Windows.Forms.Button();
            this.btnGestionAccueil_Supprimer = new System.Windows.Forms.Button();
            this.btnGestionAccueil_Modifier = new System.Windows.Forms.Button();
            this.btnGestionAccueil_Ajouter = new System.Windows.Forms.Button();
            this.tbGestionClients_LimiteLocations = new System.Windows.Forms.TextBox();
            this.tbGestionClients_NbLocations = new System.Windows.Forms.TextBox();
            this.tbGestionClients_DateInscription = new System.Windows.Forms.TextBox();
            this.tbGestionClients_Email = new System.Windows.Forms.TextBox();
            this.tbGestionClients_Telephone = new System.Windows.Forms.TextBox();
            this.tbGestionClients_Prenom = new System.Windows.Forms.TextBox();
            this.tbGestionClients_Nom = new System.Windows.Forms.TextBox();
            this.lblGestionClient_LimiteLocations = new System.Windows.Forms.Label();
            this.lblGestionClient_NbLocations = new System.Windows.Forms.Label();
            this.lblGestionClient_DateInscription = new System.Windows.Forms.Label();
            this.lblGestionClient_Email = new System.Windows.Forms.Label();
            this.lblGestionClient_Telephone = new System.Windows.Forms.Label();
            this.lblGestionClient_Prenom = new System.Windows.Forms.Label();
            this.lblGestionClient_Nom = new System.Windows.Forms.Label();
            this.tbGestionClients_Id = new System.Windows.Forms.TextBox();
            this.lblGestionClient_Id = new System.Windows.Forms.Label();
            this.lblGestionClients_InfoClient = new System.Windows.Forms.Label();
            this.errorProviderClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuGestionClients.SuspendLayout();
            this.panelGestionClients_ListeClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionClients_ListeClients)).BeginInit();
            this.panelGestionClients_InfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).BeginInit();
            this.SuspendLayout();
            // 
            // menuGestionClients
            // 
            this.menuGestionClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionClients_Accueil,
            this.mItemGestionClients_Option,
            this.mItemGestionClients_Aide});
            this.menuGestionClients.Location = new System.Drawing.Point(0, 0);
            this.menuGestionClients.Name = "menuGestionClients";
            this.menuGestionClients.Size = new System.Drawing.Size(784, 24);
            this.menuGestionClients.TabIndex = 0;
            this.menuGestionClients.Text = "menuStrip1";
            // 
            // mItemGestionClients_Accueil
            // 
            this.mItemGestionClients_Accueil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionClients_Gestionnaire,
            this.mItemGestionClients_Connexion,
            this.mItemGestionClients_Deconnexion,
            this.mItemGestionClients_Quitter});
            this.mItemGestionClients_Accueil.Name = "mItemGestionClients_Accueil";
            this.mItemGestionClients_Accueil.Size = new System.Drawing.Size(58, 20);
            this.mItemGestionClients_Accueil.Text = "Accueil";
            // 
            // mItemGestionClients_Gestionnaire
            // 
            this.mItemGestionClients_Gestionnaire.Name = "mItemGestionClients_Gestionnaire";
            this.mItemGestionClients_Gestionnaire.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionClients_Gestionnaire.Text = "Gestionnaire";
            // 
            // mItemGestionClients_Connexion
            // 
            this.mItemGestionClients_Connexion.Name = "mItemGestionClients_Connexion";
            this.mItemGestionClients_Connexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionClients_Connexion.Text = "Connexion";
            // 
            // mItemGestionClients_Deconnexion
            // 
            this.mItemGestionClients_Deconnexion.Name = "mItemGestionClients_Deconnexion";
            this.mItemGestionClients_Deconnexion.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionClients_Deconnexion.Text = "Deconnexion";
            // 
            // mItemGestionClients_Quitter
            // 
            this.mItemGestionClients_Quitter.Name = "mItemGestionClients_Quitter";
            this.mItemGestionClients_Quitter.Size = new System.Drawing.Size(143, 22);
            this.mItemGestionClients_Quitter.Text = "Quitter";
            // 
            // mItemGestionClients_Option
            // 
            this.mItemGestionClients_Option.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionClients_Parametres});
            this.mItemGestionClients_Option.Name = "mItemGestionClients_Option";
            this.mItemGestionClients_Option.Size = new System.Drawing.Size(61, 20);
            this.mItemGestionClients_Option.Text = "Options";
            // 
            // mItemGestionClients_Parametres
            // 
            this.mItemGestionClients_Parametres.Name = "mItemGestionClients_Parametres";
            this.mItemGestionClients_Parametres.Size = new System.Drawing.Size(133, 22);
            this.mItemGestionClients_Parametres.Text = "Paramètres";
            // 
            // mItemGestionClients_Aide
            // 
            this.mItemGestionClients_Aide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGestionClients_Apropos,
            this.mItemGestionClients_SigneInterrogation});
            this.mItemGestionClients_Aide.Name = "mItemGestionClients_Aide";
            this.mItemGestionClients_Aide.Size = new System.Drawing.Size(43, 20);
            this.mItemGestionClients_Aide.Text = "Aide";
            // 
            // mItemGestionClients_Apropos
            // 
            this.mItemGestionClients_Apropos.Name = "mItemGestionClients_Apropos";
            this.mItemGestionClients_Apropos.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionClients_Apropos.Text = "à propos de nous";
            // 
            // mItemGestionClients_SigneInterrogation
            // 
            this.mItemGestionClients_SigneInterrogation.Name = "mItemGestionClients_SigneInterrogation";
            this.mItemGestionClients_SigneInterrogation.Size = new System.Drawing.Size(165, 22);
            this.mItemGestionClients_SigneInterrogation.Text = "?";
            // 
            // panelGestionClients_ListeClients
            // 
            this.panelGestionClients_ListeClients.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionClients_ListeClients.Controls.Add(this.dgGestionClients_ListeClients);
            this.panelGestionClients_ListeClients.Controls.Add(this.lblGestionClients_ListeClients);
            this.panelGestionClients_ListeClients.Location = new System.Drawing.Point(8, 30);
            this.panelGestionClients_ListeClients.Name = "panelGestionClients_ListeClients";
            this.panelGestionClients_ListeClients.Size = new System.Drawing.Size(762, 276);
            this.panelGestionClients_ListeClients.TabIndex = 1;
            // 
            // dgGestionClients_ListeClients
            // 
            this.dgGestionClients_ListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGestionClients_ListeClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnNom,
            this.columnPrenom,
            this.columnTelephone,
            this.columnEmail,
            this.columnDateInscription,
            this.columnNbLocations,
            this.columnLimiteLocations});
            this.dgGestionClients_ListeClients.Location = new System.Drawing.Point(18, 48);
            this.dgGestionClients_ListeClients.Name = "dgGestionClients_ListeClients";
            this.dgGestionClients_ListeClients.Size = new System.Drawing.Size(731, 209);
            this.dgGestionClients_ListeClients.TabIndex = 1;
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            // 
            // columnNom
            // 
            this.columnNom.HeaderText = "Nom";
            this.columnNom.Name = "columnNom";
            this.columnNom.ToolTipText = "Nom";
            // 
            // columnPrenom
            // 
            this.columnPrenom.HeaderText = "Prénom";
            this.columnPrenom.Name = "columnPrenom";
            this.columnPrenom.ToolTipText = "Prénom";
            // 
            // columnTelephone
            // 
            this.columnTelephone.HeaderText = "Telephone";
            this.columnTelephone.Name = "columnTelephone";
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            // 
            // columnDateInscription
            // 
            this.columnDateInscription.HeaderText = "DateInscription";
            this.columnDateInscription.Name = "columnDateInscription";
            // 
            // columnNbLocations
            // 
            this.columnNbLocations.HeaderText = "NbLocations";
            this.columnNbLocations.Name = "columnNbLocations";
            // 
            // columnLimiteLocations
            // 
            this.columnLimiteLocations.HeaderText = "LimiteLocations";
            this.columnLimiteLocations.Name = "columnLimiteLocations";
            // 
            // lblGestionClients_ListeClients
            // 
            this.lblGestionClients_ListeClients.AutoSize = true;
            this.lblGestionClients_ListeClients.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClients_ListeClients.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionClients_ListeClients.Location = new System.Drawing.Point(304, 20);
            this.lblGestionClients_ListeClients.Name = "lblGestionClients_ListeClients";
            this.lblGestionClients_ListeClients.Size = new System.Drawing.Size(151, 19);
            this.lblGestionClients_ListeClients.TabIndex = 0;
            this.lblGestionClients_ListeClients.Text = "Liste des clients";
            // 
            // panelGestionClients_InfoClient
            // 
            this.panelGestionClients_InfoClient.BackColor = System.Drawing.Color.DimGray;
            this.panelGestionClients_InfoClient.Controls.Add(this.lblMessage);
            this.panelGestionClients_InfoClient.Controls.Add(this.btnGestionAccueil_Rechercher);
            this.panelGestionClients_InfoClient.Controls.Add(this.btnGestionAccueil_Supprimer);
            this.panelGestionClients_InfoClient.Controls.Add(this.btnGestionAccueil_Modifier);
            this.panelGestionClients_InfoClient.Controls.Add(this.btnGestionAccueil_Ajouter);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_LimiteLocations);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_NbLocations);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_DateInscription);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_Email);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_Telephone);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_Prenom);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_Nom);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_LimiteLocations);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_NbLocations);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_DateInscription);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_Email);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_Telephone);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_Prenom);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_Nom);
            this.panelGestionClients_InfoClient.Controls.Add(this.tbGestionClients_Id);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClient_Id);
            this.panelGestionClients_InfoClient.Controls.Add(this.lblGestionClients_InfoClient);
            this.panelGestionClients_InfoClient.Location = new System.Drawing.Point(8, 312);
            this.panelGestionClients_InfoClient.Name = "panelGestionClients_InfoClient";
            this.panelGestionClients_InfoClient.Size = new System.Drawing.Size(762, 237);
            this.panelGestionClients_InfoClient.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(40, 14);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 18);
            this.lblMessage.TabIndex = 23;
            // 
            // btnGestionAccueil_Rechercher
            // 
            this.btnGestionAccueil_Rechercher.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGestionAccueil_Rechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionAccueil_Rechercher.Image")));
            this.btnGestionAccueil_Rechercher.Location = new System.Drawing.Point(373, 180);
            this.btnGestionAccueil_Rechercher.Name = "btnGestionAccueil_Rechercher";
            this.btnGestionAccueil_Rechercher.Size = new System.Drawing.Size(50, 30);
            this.btnGestionAccueil_Rechercher.TabIndex = 22;
            this.btnGestionAccueil_Rechercher.UseVisualStyleBackColor = false;
            this.btnGestionAccueil_Rechercher.Click += new System.EventHandler(this.btnGestionAccueil_Rechercher_Click);
            // 
            // btnGestionAccueil_Supprimer
            // 
            this.btnGestionAccueil_Supprimer.BackColor = System.Drawing.Color.LightCoral;
            this.btnGestionAccueil_Supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionAccueil_Supprimer.Image")));
            this.btnGestionAccueil_Supprimer.Location = new System.Drawing.Point(593, 180);
            this.btnGestionAccueil_Supprimer.Name = "btnGestionAccueil_Supprimer";
            this.btnGestionAccueil_Supprimer.Size = new System.Drawing.Size(50, 30);
            this.btnGestionAccueil_Supprimer.TabIndex = 21;
            this.btnGestionAccueil_Supprimer.UseVisualStyleBackColor = false;
            this.btnGestionAccueil_Supprimer.Click += new System.EventHandler(this.btnGestionAccueil_Supprimer_Click);
            // 
            // btnGestionAccueil_Modifier
            // 
            this.btnGestionAccueil_Modifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGestionAccueil_Modifier.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionAccueil_Modifier.Image")));
            this.btnGestionAccueil_Modifier.Location = new System.Drawing.Point(519, 180);
            this.btnGestionAccueil_Modifier.Name = "btnGestionAccueil_Modifier";
            this.btnGestionAccueil_Modifier.Size = new System.Drawing.Size(50, 30);
            this.btnGestionAccueil_Modifier.TabIndex = 20;
            this.btnGestionAccueil_Modifier.UseVisualStyleBackColor = false;
            this.btnGestionAccueil_Modifier.Click += new System.EventHandler(this.btnGestionAccueil_Modifier_Click);
            // 
            // btnGestionAccueil_Ajouter
            // 
            this.btnGestionAccueil_Ajouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGestionAccueil_Ajouter.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionAccueil_Ajouter.Image")));
            this.btnGestionAccueil_Ajouter.Location = new System.Drawing.Point(446, 180);
            this.btnGestionAccueil_Ajouter.Name = "btnGestionAccueil_Ajouter";
            this.btnGestionAccueil_Ajouter.Size = new System.Drawing.Size(50, 30);
            this.btnGestionAccueil_Ajouter.TabIndex = 19;
            this.btnGestionAccueil_Ajouter.UseVisualStyleBackColor = false;
            this.btnGestionAccueil_Ajouter.Click += new System.EventHandler(this.btnGestionAccueil_Ajouter_Click);
            // 
            // tbGestionClients_LimiteLocations
            // 
            this.tbGestionClients_LimiteLocations.Location = new System.Drawing.Point(519, 124);
            this.tbGestionClients_LimiteLocations.Name = "tbGestionClients_LimiteLocations";
            this.tbGestionClients_LimiteLocations.Size = new System.Drawing.Size(157, 20);
            this.tbGestionClients_LimiteLocations.TabIndex = 18;
            // 
            // tbGestionClients_NbLocations
            // 
            this.tbGestionClients_NbLocations.Location = new System.Drawing.Point(519, 93);
            this.tbGestionClients_NbLocations.Name = "tbGestionClients_NbLocations";
            this.tbGestionClients_NbLocations.ReadOnly = true;
            this.tbGestionClients_NbLocations.Size = new System.Drawing.Size(157, 20);
            this.tbGestionClients_NbLocations.TabIndex = 17;
            // 
            // tbGestionClients_DateInscription
            // 
            this.tbGestionClients_DateInscription.Location = new System.Drawing.Point(519, 62);
            this.tbGestionClients_DateInscription.Name = "tbGestionClients_DateInscription";
            this.tbGestionClients_DateInscription.ReadOnly = true;
            this.tbGestionClients_DateInscription.Size = new System.Drawing.Size(157, 20);
            this.tbGestionClients_DateInscription.TabIndex = 16;
            // 
            // tbGestionClients_Email
            // 
            this.tbGestionClients_Email.Location = new System.Drawing.Point(116, 184);
            this.tbGestionClients_Email.Name = "tbGestionClients_Email";
            this.tbGestionClients_Email.Size = new System.Drawing.Size(202, 20);
            this.tbGestionClients_Email.TabIndex = 15;
            // 
            // tbGestionClients_Telephone
            // 
            this.tbGestionClients_Telephone.Location = new System.Drawing.Point(116, 153);
            this.tbGestionClients_Telephone.Name = "tbGestionClients_Telephone";
            this.tbGestionClients_Telephone.Size = new System.Drawing.Size(202, 20);
            this.tbGestionClients_Telephone.TabIndex = 14;
            // 
            // tbGestionClients_Prenom
            // 
            this.tbGestionClients_Prenom.Location = new System.Drawing.Point(116, 124);
            this.tbGestionClients_Prenom.Name = "tbGestionClients_Prenom";
            this.tbGestionClients_Prenom.Size = new System.Drawing.Size(202, 20);
            this.tbGestionClients_Prenom.TabIndex = 13;
            // 
            // tbGestionClients_Nom
            // 
            this.tbGestionClients_Nom.Location = new System.Drawing.Point(116, 93);
            this.tbGestionClients_Nom.Name = "tbGestionClients_Nom";
            this.tbGestionClients_Nom.Size = new System.Drawing.Size(202, 20);
            this.tbGestionClients_Nom.TabIndex = 12;
            // 
            // lblGestionClient_LimiteLocations
            // 
            this.lblGestionClient_LimiteLocations.AutoSize = true;
            this.lblGestionClient_LimiteLocations.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_LimiteLocations.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_LimiteLocations.Location = new System.Drawing.Point(355, 128);
            this.lblGestionClient_LimiteLocations.Name = "lblGestionClient_LimiteLocations";
            this.lblGestionClient_LimiteLocations.Size = new System.Drawing.Size(148, 16);
            this.lblGestionClient_LimiteLocations.TabIndex = 11;
            this.lblGestionClient_LimiteLocations.Text = "LIMITE DE LOCATIONS :";
            // 
            // lblGestionClient_NbLocations
            // 
            this.lblGestionClient_NbLocations.AutoSize = true;
            this.lblGestionClient_NbLocations.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_NbLocations.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_NbLocations.Location = new System.Drawing.Point(355, 97);
            this.lblGestionClient_NbLocations.Name = "lblGestionClient_NbLocations";
            this.lblGestionClient_NbLocations.Size = new System.Drawing.Size(158, 16);
            this.lblGestionClient_NbLocations.TabIndex = 10;
            this.lblGestionClient_NbLocations.Text = "NOMBRE DE LOCATIONS :";
            // 
            // lblGestionClient_DateInscription
            // 
            this.lblGestionClient_DateInscription.AutoSize = true;
            this.lblGestionClient_DateInscription.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_DateInscription.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_DateInscription.Location = new System.Drawing.Point(355, 66);
            this.lblGestionClient_DateInscription.Name = "lblGestionClient_DateInscription";
            this.lblGestionClient_DateInscription.Size = new System.Drawing.Size(131, 16);
            this.lblGestionClient_DateInscription.TabIndex = 9;
            this.lblGestionClient_DateInscription.Text = "DATE INSCRIPTION :";
            // 
            // lblGestionClient_Email
            // 
            this.lblGestionClient_Email.AutoSize = true;
            this.lblGestionClient_Email.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_Email.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_Email.Location = new System.Drawing.Point(15, 188);
            this.lblGestionClient_Email.Name = "lblGestionClient_Email";
            this.lblGestionClient_Email.Size = new System.Drawing.Size(48, 16);
            this.lblGestionClient_Email.TabIndex = 8;
            this.lblGestionClient_Email.Text = "EMAL :";
            // 
            // lblGestionClient_Telephone
            // 
            this.lblGestionClient_Telephone.AutoSize = true;
            this.lblGestionClient_Telephone.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_Telephone.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_Telephone.Location = new System.Drawing.Point(15, 157);
            this.lblGestionClient_Telephone.Name = "lblGestionClient_Telephone";
            this.lblGestionClient_Telephone.Size = new System.Drawing.Size(89, 16);
            this.lblGestionClient_Telephone.TabIndex = 7;
            this.lblGestionClient_Telephone.Text = "TELEPHONE :";
            // 
            // lblGestionClient_Prenom
            // 
            this.lblGestionClient_Prenom.AutoSize = true;
            this.lblGestionClient_Prenom.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_Prenom.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_Prenom.Location = new System.Drawing.Point(15, 128);
            this.lblGestionClient_Prenom.Name = "lblGestionClient_Prenom";
            this.lblGestionClient_Prenom.Size = new System.Drawing.Size(67, 16);
            this.lblGestionClient_Prenom.TabIndex = 6;
            this.lblGestionClient_Prenom.Text = "PRÉNOM :";
            // 
            // lblGestionClient_Nom
            // 
            this.lblGestionClient_Nom.AutoSize = true;
            this.lblGestionClient_Nom.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_Nom.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_Nom.Location = new System.Drawing.Point(15, 97);
            this.lblGestionClient_Nom.Name = "lblGestionClient_Nom";
            this.lblGestionClient_Nom.Size = new System.Drawing.Size(42, 16);
            this.lblGestionClient_Nom.TabIndex = 5;
            this.lblGestionClient_Nom.Text = "NOM :";
            // 
            // tbGestionClients_Id
            // 
            this.tbGestionClients_Id.Location = new System.Drawing.Point(116, 62);
            this.tbGestionClients_Id.Name = "tbGestionClients_Id";
            this.tbGestionClients_Id.ReadOnly = true;
            this.tbGestionClients_Id.Size = new System.Drawing.Size(67, 20);
            this.tbGestionClients_Id.TabIndex = 4;
            // 
            // lblGestionClient_Id
            // 
            this.lblGestionClient_Id.AutoSize = true;
            this.lblGestionClient_Id.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClient_Id.ForeColor = System.Drawing.Color.White;
            this.lblGestionClient_Id.Location = new System.Drawing.Point(15, 66);
            this.lblGestionClient_Id.Name = "lblGestionClient_Id";
            this.lblGestionClient_Id.Size = new System.Drawing.Size(28, 16);
            this.lblGestionClient_Id.TabIndex = 3;
            this.lblGestionClient_Id.Text = "ID :";
            // 
            // lblGestionClients_InfoClient
            // 
            this.lblGestionClients_InfoClient.AutoSize = true;
            this.lblGestionClients_InfoClient.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClients_InfoClient.ForeColor = System.Drawing.Color.Gold;
            this.lblGestionClients_InfoClient.Location = new System.Drawing.Point(264, 20);
            this.lblGestionClients_InfoClient.Name = "lblGestionClients_InfoClient";
            this.lblGestionClients_InfoClient.Size = new System.Drawing.Size(231, 19);
            this.lblGestionClients_InfoClient.TabIndex = 2;
            this.lblGestionClients_InfoClient.Text = "Information sur le client";
            // 
            // errorProviderClient
            // 
            this.errorProviderClient.ContainerControl = this;
            // 
            // GestionClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelGestionClients_InfoClient);
            this.Controls.Add(this.panelGestionClients_ListeClients);
            this.Controls.Add(this.menuGestionClients);
            this.MainMenuStrip = this.menuGestionClients;
            this.Name = "GestionClientForm";
            this.Text = "Gestion Clients";
            this.menuGestionClients.ResumeLayout(false);
            this.menuGestionClients.PerformLayout();
            this.panelGestionClients_ListeClients.ResumeLayout(false);
            this.panelGestionClients_ListeClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGestionClients_ListeClients)).EndInit();
            this.panelGestionClients_InfoClient.ResumeLayout(false);
            this.panelGestionClients_InfoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGestionClients;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Accueil;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Option;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Aide;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Connexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Deconnexion;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Quitter;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Parametres;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Apropos;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_SigneInterrogation;
        private System.Windows.Forms.Panel panelGestionClients_ListeClients;
        private System.Windows.Forms.DataGridView dgGestionClients_ListeClients;
        private System.Windows.Forms.Label lblGestionClients_ListeClients;
        private System.Windows.Forms.Panel panelGestionClients_InfoClient;
        private System.Windows.Forms.Label lblGestionClient_Id;
        private System.Windows.Forms.Label lblGestionClients_InfoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateInscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNbLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLimiteLocations;
        private System.Windows.Forms.TextBox tbGestionClients_Id;
        private System.Windows.Forms.TextBox tbGestionClients_LimiteLocations;
        private System.Windows.Forms.TextBox tbGestionClients_NbLocations;
        private System.Windows.Forms.TextBox tbGestionClients_DateInscription;
        private System.Windows.Forms.TextBox tbGestionClients_Email;
        private System.Windows.Forms.TextBox tbGestionClients_Telephone;
        private System.Windows.Forms.TextBox tbGestionClients_Prenom;
        private System.Windows.Forms.TextBox tbGestionClients_Nom;
        private System.Windows.Forms.Label lblGestionClient_LimiteLocations;
        private System.Windows.Forms.Label lblGestionClient_NbLocations;
        private System.Windows.Forms.Label lblGestionClient_DateInscription;
        private System.Windows.Forms.Label lblGestionClient_Email;
        private System.Windows.Forms.Label lblGestionClient_Telephone;
        private System.Windows.Forms.Label lblGestionClient_Prenom;
        private System.Windows.Forms.Label lblGestionClient_Nom;
        private System.Windows.Forms.Button btnGestionAccueil_Supprimer;
        private System.Windows.Forms.Button btnGestionAccueil_Modifier;
        private System.Windows.Forms.Button btnGestionAccueil_Ajouter;
        private System.Windows.Forms.Button btnGestionAccueil_Rechercher;
        private System.Windows.Forms.ToolStripMenuItem mItemGestionClients_Gestionnaire;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ErrorProvider errorProviderClient;
    }
}