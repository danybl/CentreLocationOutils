using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CentreLocationOutils
{
    public partial class accueil : Form
    {
        private TabControl tabControl1;
        private TabPage tpCreerLocation;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem connexionToolStripMenuItem;
        private ToolStripMenuItem deconnexionToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem paramètresToolStripMenuItem;
        private ToolStripMenuItem àProposDeNousToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private TabPage tpCreerReservation;
        private TabPage tpGestionOutils;
        private ToolStripContainer toolStripContainer2;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblDateRetour;
        private Label lblDateLimite;
        private Label lblDateLocation;
        private Label lblDepot;
        private Label lblIdOutil;
        private Label lblIdEmploye;
        private Label lblIdClient;
        private Label lblIdLocation;
        private Button btnRechercherOutil;
        private Button btnAnnulerLocation;
        private Button btnSaveLocation;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRechercherOutil2;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TabPage tpInfoClient;
        private SplitContainer splitContainer1;
        private Label lblNbJours;
        private NumericUpDown numUDnbJours;
        private Button btnAnnulerReservation;
        private Button btnSaveReservation;
        private Button btnSupprimerClient;
        private Button btnModifierClient;
        private Button btnAjouterClient;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer2;
        private Button btnSupprimerOutil;
        private Button btnModifierOutil;
        private Button btnAjouterOutil;
        private DataGridView dataGridView2;
        private Button btnRechercherClient;
        private DataGridViewTextBoxColumn columnIdClient;
        private DataGridViewTextBoxColumn columnNomClient;
        private DataGridViewTextBoxColumn columnPrenomClient;
        private DataGridViewTextBoxColumn columnTelephoneClient;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnNumero;
        private DataGridViewTextBoxColumn columnRue;
        private DataGridViewTextBoxColumn columnAppartement;
        private DataGridViewTextBoxColumn columnCodePostal;
        private DataGridViewTextBoxColumn columnVille;
        private DataGridViewTextBoxColumn columnProvince;
        private DataGridViewTextBoxColumn columnPays;
        private Button btnRechercherOutil3;
        private DataGridViewTextBoxColumn columIdOutil;
        private DataGridViewTextBoxColumn columnCategorie;
        private DataGridViewTextBoxColumn columnNom;
        private DataGridViewTextBoxColumn columnNumSerie;
        private DataGridViewTextBoxColumn columnDateAcquisition;
        private DataGridViewTextBoxColumn columnPrixLocationParJour;
        private DataGridViewTextBoxColumn columnDescription;
        private MenuStrip menuStrip1;
    
        public accueil()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCreerLocation = new System.Windows.Forms.TabPage();
            this.lblNbJours = new System.Windows.Forms.Label();
            this.numUDnbJours = new System.Windows.Forms.NumericUpDown();
            this.btnAnnulerLocation = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnRechercherOutil = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblDateLimite = new System.Windows.Forms.Label();
            this.lblDateLocation = new System.Windows.Forms.Label();
            this.lblDepot = new System.Windows.Forms.Label();
            this.lblIdOutil = new System.Windows.Forms.Label();
            this.lblIdEmploye = new System.Windows.Forms.Label();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblIdLocation = new System.Windows.Forms.Label();
            this.tpCreerReservation = new System.Windows.Forms.TabPage();
            this.btnAnnulerReservation = new System.Windows.Forms.Button();
            this.btnSaveReservation = new System.Windows.Forms.Button();
            this.btnRechercherOutil2 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInfoClient = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpGestionOutils = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSupprimerOutil = new System.Windows.Forms.Button();
            this.btnModifierOutil = new System.Windows.Forms.Button();
            this.btnAjouterOutil = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposDeNousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.columnIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelephoneClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAppartement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columIdOutil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNumSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPrixLocationParJour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRechercherClient = new System.Windows.Forms.Button();
            this.btnRechercherOutil3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCreerLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDnbJours)).BeginInit();
            this.tpCreerReservation.SuspendLayout();
            this.tpInfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpGestionOutils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCreerLocation);
            this.tabControl1.Controls.Add(this.tpCreerReservation);
            this.tabControl1.Controls.Add(this.tpInfoClient);
            this.tabControl1.Controls.Add(this.tpGestionOutils);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCreerLocation
            // 
            this.tpCreerLocation.Controls.Add(this.lblNbJours);
            this.tpCreerLocation.Controls.Add(this.numUDnbJours);
            this.tpCreerLocation.Controls.Add(this.btnAnnulerLocation);
            this.tpCreerLocation.Controls.Add(this.btnSaveLocation);
            this.tpCreerLocation.Controls.Add(this.btnRechercherOutil);
            this.tpCreerLocation.Controls.Add(this.textBox8);
            this.tpCreerLocation.Controls.Add(this.textBox7);
            this.tpCreerLocation.Controls.Add(this.textBox6);
            this.tpCreerLocation.Controls.Add(this.textBox5);
            this.tpCreerLocation.Controls.Add(this.textBox4);
            this.tpCreerLocation.Controls.Add(this.textBox3);
            this.tpCreerLocation.Controls.Add(this.textBox2);
            this.tpCreerLocation.Controls.Add(this.textBox1);
            this.tpCreerLocation.Controls.Add(this.lblDateRetour);
            this.tpCreerLocation.Controls.Add(this.lblDateLimite);
            this.tpCreerLocation.Controls.Add(this.lblDateLocation);
            this.tpCreerLocation.Controls.Add(this.lblDepot);
            this.tpCreerLocation.Controls.Add(this.lblIdOutil);
            this.tpCreerLocation.Controls.Add(this.lblIdEmploye);
            this.tpCreerLocation.Controls.Add(this.lblIdClient);
            this.tpCreerLocation.Controls.Add(this.lblIdLocation);
            this.tpCreerLocation.Location = new System.Drawing.Point(4, 22);
            this.tpCreerLocation.Name = "tpCreerLocation";
            this.tpCreerLocation.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreerLocation.Size = new System.Drawing.Size(768, 406);
            this.tpCreerLocation.TabIndex = 1;
            this.tpCreerLocation.Text = "Créer Location";
            this.tpCreerLocation.UseVisualStyleBackColor = true;
            // 
            // lblNbJours
            // 
            this.lblNbJours.AutoSize = true;
            this.lblNbJours.Location = new System.Drawing.Point(476, 192);
            this.lblNbJours.Name = "lblNbJours";
            this.lblNbJours.Size = new System.Drawing.Size(84, 13);
            this.lblNbJours.TabIndex = 20;
            this.lblNbJours.Text = "Nombre de jours";
            // 
            // numUDnbJours
            // 
            this.numUDnbJours.Location = new System.Drawing.Point(566, 189);
            this.numUDnbJours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDnbJours.Name = "numUDnbJours";
            this.numUDnbJours.Size = new System.Drawing.Size(120, 20);
            this.numUDnbJours.TabIndex = 19;
            this.numUDnbJours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAnnulerLocation
            // 
            this.btnAnnulerLocation.Location = new System.Drawing.Point(607, 315);
            this.btnAnnulerLocation.Name = "btnAnnulerLocation";
            this.btnAnnulerLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerLocation.TabIndex = 18;
            this.btnAnnulerLocation.Text = "Annuler";
            this.btnAnnulerLocation.UseVisualStyleBackColor = true;
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(514, 315);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(87, 23);
            this.btnSaveLocation.TabIndex = 17;
            this.btnSaveLocation.Text = "Save";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            // 
            // btnRechercherOutil
            // 
            this.btnRechercherOutil.Location = new System.Drawing.Point(479, 95);
            this.btnRechercherOutil.Name = "btnRechercherOutil";
            this.btnRechercherOutil.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherOutil.TabIndex = 16;
            this.btnRechercherOutil.Text = "Rechercher";
            this.btnRechercherOutil.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(360, 278);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(360, 233);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(360, 189);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(360, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(289, 279);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(65, 13);
            this.lblDateRetour.TabIndex = 7;
            this.lblDateRetour.Text = "Date Retour";
            // 
            // lblDateLimite
            // 
            this.lblDateLimite.AutoSize = true;
            this.lblDateLimite.Location = new System.Drawing.Point(292, 236);
            this.lblDateLimite.Name = "lblDateLimite";
            this.lblDateLimite.Size = new System.Drawing.Size(60, 13);
            this.lblDateLimite.TabIndex = 6;
            this.lblDateLimite.Text = "Date Limite";
            // 
            // lblDateLocation
            // 
            this.lblDateLocation.AutoSize = true;
            this.lblDateLocation.Location = new System.Drawing.Point(280, 192);
            this.lblDateLocation.Name = "lblDateLocation";
            this.lblDateLocation.Size = new System.Drawing.Size(74, 13);
            this.lblDateLocation.TabIndex = 5;
            this.lblDateLocation.Text = "Date Location";
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(140, 135);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDepot.Size = new System.Drawing.Size(36, 13);
            this.lblDepot.TabIndex = 4;
            this.lblDepot.Text = "Dêpot";
            // 
            // lblIdOutil
            // 
            this.lblIdOutil.AutoSize = true;
            this.lblIdOutil.Location = new System.Drawing.Point(316, 100);
            this.lblIdOutil.Name = "lblIdOutil";
            this.lblIdOutil.Size = new System.Drawing.Size(38, 13);
            this.lblIdOutil.TabIndex = 3;
            this.lblIdOutil.Text = "Outil #";
            // 
            // lblIdEmploye
            // 
            this.lblIdEmploye.AutoSize = true;
            this.lblIdEmploye.Location = new System.Drawing.Point(297, 57);
            this.lblIdEmploye.Name = "lblIdEmploye";
            this.lblIdEmploye.Size = new System.Drawing.Size(57, 13);
            this.lblIdEmploye.TabIndex = 2;
            this.lblIdEmploye.Text = "Employe #";
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.Location = new System.Drawing.Point(132, 97);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIdClient.Size = new System.Drawing.Size(46, 13);
            this.lblIdClient.TabIndex = 1;
            this.lblIdClient.Text = " Client #";
            // 
            // lblIdLocation
            // 
            this.lblIdLocation.AutoSize = true;
            this.lblIdLocation.Location = new System.Drawing.Point(120, 57);
            this.lblIdLocation.Name = "lblIdLocation";
            this.lblIdLocation.Size = new System.Drawing.Size(58, 13);
            this.lblIdLocation.TabIndex = 0;
            this.lblIdLocation.Text = "Location #";
            // 
            // tpCreerReservation
            // 
            this.tpCreerReservation.Controls.Add(this.btnAnnulerReservation);
            this.tpCreerReservation.Controls.Add(this.btnSaveReservation);
            this.tpCreerReservation.Controls.Add(this.btnRechercherOutil2);
            this.tpCreerReservation.Controls.Add(this.textBox13);
            this.tpCreerReservation.Controls.Add(this.textBox12);
            this.tpCreerReservation.Controls.Add(this.textBox11);
            this.tpCreerReservation.Controls.Add(this.textBox10);
            this.tpCreerReservation.Controls.Add(this.textBox9);
            this.tpCreerReservation.Controls.Add(this.label5);
            this.tpCreerReservation.Controls.Add(this.label4);
            this.tpCreerReservation.Controls.Add(this.label3);
            this.tpCreerReservation.Controls.Add(this.label2);
            this.tpCreerReservation.Controls.Add(this.label1);
            this.tpCreerReservation.Location = new System.Drawing.Point(4, 22);
            this.tpCreerReservation.Name = "tpCreerReservation";
            this.tpCreerReservation.Size = new System.Drawing.Size(768, 406);
            this.tpCreerReservation.TabIndex = 7;
            this.tpCreerReservation.Text = "Créer Réservation";
            this.tpCreerReservation.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerReservation
            // 
            this.btnAnnulerReservation.Location = new System.Drawing.Point(484, 289);
            this.btnAnnulerReservation.Name = "btnAnnulerReservation";
            this.btnAnnulerReservation.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerReservation.TabIndex = 12;
            this.btnAnnulerReservation.Text = "Annuler";
            this.btnAnnulerReservation.UseVisualStyleBackColor = true;
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Location = new System.Drawing.Point(403, 289);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveReservation.TabIndex = 11;
            this.btnSaveReservation.Text = "Save";
            this.btnSaveReservation.UseVisualStyleBackColor = true;
            // 
            // btnRechercherOutil2
            // 
            this.btnRechercherOutil2.Location = new System.Drawing.Point(315, 149);
            this.btnRechercherOutil2.Name = "btnRechercherOutil2";
            this.btnRechercherOutil2.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherOutil2.TabIndex = 10;
            this.btnRechercherOutil2.Text = "Rechercher";
            this.btnRechercherOutil2.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(199, 250);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 9;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(199, 202);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(199, 151);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(199, 102);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(199, 54);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Limite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Reservation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Outil #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation #";
            // 
            // tpInfoClient
            // 
            this.tpInfoClient.Controls.Add(this.splitContainer1);
            this.tpInfoClient.Location = new System.Drawing.Point(4, 22);
            this.tpInfoClient.Name = "tpInfoClient";
            this.tpInfoClient.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfoClient.Size = new System.Drawing.Size(768, 406);
            this.tpInfoClient.TabIndex = 2;
            this.tpInfoClient.Text = "Info Client";
            this.tpInfoClient.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRechercherClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnSupprimerClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnModifierClient);
            this.splitContainer1.Panel1.Controls.Add(this.btnAjouterClient);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(762, 400);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(88, 195);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerClient.TabIndex = 2;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(88, 126);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(75, 23);
            this.btnModifierClient.TabIndex = 1;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(88, 58);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterClient.TabIndex = 0;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdClient,
            this.columnNomClient,
            this.columnPrenomClient,
            this.columnTelephoneClient,
            this.columnEmail,
            this.columnNumero,
            this.columnRue,
            this.columnAppartement,
            this.columnCodePostal,
            this.columnVille,
            this.columnProvince,
            this.columnPays});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpGestionOutils
            // 
            this.tpGestionOutils.Controls.Add(this.splitContainer2);
            this.tpGestionOutils.Location = new System.Drawing.Point(4, 22);
            this.tpGestionOutils.Name = "tpGestionOutils";
            this.tpGestionOutils.Size = new System.Drawing.Size(768, 406);
            this.tpGestionOutils.TabIndex = 8;
            this.tpGestionOutils.Text = "Gestion Outils";
            this.tpGestionOutils.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnRechercherOutil3);
            this.splitContainer2.Panel1.Controls.Add(this.btnSupprimerOutil);
            this.splitContainer2.Panel1.Controls.Add(this.btnModifierOutil);
            this.splitContainer2.Panel1.Controls.Add(this.btnAjouterOutil);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(768, 406);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSupprimerOutil
            // 
            this.btnSupprimerOutil.Location = new System.Drawing.Point(86, 183);
            this.btnSupprimerOutil.Name = "btnSupprimerOutil";
            this.btnSupprimerOutil.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerOutil.TabIndex = 5;
            this.btnSupprimerOutil.Text = "Supprimer";
            this.btnSupprimerOutil.UseVisualStyleBackColor = true;
            // 
            // btnModifierOutil
            // 
            this.btnModifierOutil.Location = new System.Drawing.Point(86, 114);
            this.btnModifierOutil.Name = "btnModifierOutil";
            this.btnModifierOutil.Size = new System.Drawing.Size(75, 23);
            this.btnModifierOutil.TabIndex = 4;
            this.btnModifierOutil.Text = "Modifier";
            this.btnModifierOutil.UseVisualStyleBackColor = true;
            // 
            // btnAjouterOutil
            // 
            this.btnAjouterOutil.Location = new System.Drawing.Point(86, 46);
            this.btnAjouterOutil.Name = "btnAjouterOutil";
            this.btnAjouterOutil.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterOutil.TabIndex = 3;
            this.btnAjouterOutil.Text = "Ajouter";
            this.btnAjouterOutil.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIdOutil,
            this.columnCategorie,
            this.columnNom,
            this.columnNumSerie,
            this.columnDateAcquisition,
            this.columnPrixLocationParJour,
            this.columnDescription});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(502, 348);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.deconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposDeNousToolStripMenuItem,
            this.toolStripMenuItem2});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposDeNousToolStripMenuItem
            // 
            this.àProposDeNousToolStripMenuItem.Name = "àProposDeNousToolStripMenuItem";
            this.àProposDeNousToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.àProposDeNousToolStripMenuItem.Text = "À propos de nous";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem2.Text = "?";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(776, 373);
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 27);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(776, 398);
            this.toolStripContainer2.TabIndex = 2;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // columnIdClient
            // 
            this.columnIdClient.HeaderText = "";
            this.columnIdClient.Name = "columnIdClient";
            this.columnIdClient.ReadOnly = true;
            // 
            // columnNomClient
            // 
            this.columnNomClient.HeaderText = "";
            this.columnNomClient.Name = "columnNomClient";
            // 
            // columnPrenomClient
            // 
            this.columnPrenomClient.HeaderText = "";
            this.columnPrenomClient.Name = "columnPrenomClient";
            // 
            // columnTelephoneClient
            // 
            this.columnTelephoneClient.HeaderText = "";
            this.columnTelephoneClient.Name = "columnTelephoneClient";
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "";
            this.columnEmail.Name = "columnEmail";
            // 
            // columnNumero
            // 
            this.columnNumero.HeaderText = "";
            this.columnNumero.Name = "columnNumero";
            // 
            // columnRue
            // 
            this.columnRue.HeaderText = "";
            this.columnRue.Name = "columnRue";
            // 
            // columnAppartement
            // 
            this.columnAppartement.HeaderText = "";
            this.columnAppartement.Name = "columnAppartement";
            // 
            // columnCodePostal
            // 
            this.columnCodePostal.HeaderText = "";
            this.columnCodePostal.Name = "columnCodePostal";
            // 
            // columnVille
            // 
            this.columnVille.HeaderText = "";
            this.columnVille.Name = "columnVille";
            // 
            // columnProvince
            // 
            this.columnProvince.HeaderText = "";
            this.columnProvince.Name = "columnProvince";
            // 
            // columnPays
            // 
            this.columnPays.HeaderText = "";
            this.columnPays.Name = "columnPays";
            // 
            // columIdOutil
            // 
            this.columIdOutil.HeaderText = "";
            this.columIdOutil.Name = "columIdOutil";
            this.columIdOutil.ReadOnly = true;
            // 
            // columnCategorie
            // 
            this.columnCategorie.HeaderText = "";
            this.columnCategorie.Name = "columnCategorie";
            // 
            // columnNom
            // 
            this.columnNom.HeaderText = "";
            this.columnNom.Name = "columnNom";
            // 
            // columnNumSerie
            // 
            this.columnNumSerie.HeaderText = "";
            this.columnNumSerie.Name = "columnNumSerie";
            // 
            // columnDateAcquisition
            // 
            this.columnDateAcquisition.HeaderText = "";
            this.columnDateAcquisition.Name = "columnDateAcquisition";
            this.columnDateAcquisition.ReadOnly = true;
            // 
            // columnPrixLocationParJour
            // 
            this.columnPrixLocationParJour.HeaderText = "";
            this.columnPrixLocationParJour.Name = "columnPrixLocationParJour";
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "";
            this.columnDescription.Name = "columnDescription";
            // 
            // btnRechercherClient
            // 
            this.btnRechercherClient.Location = new System.Drawing.Point(88, 252);
            this.btnRechercherClient.Name = "btnRechercherClient";
            this.btnRechercherClient.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherClient.TabIndex = 3;
            this.btnRechercherClient.Text = "Rechercher";
            this.btnRechercherClient.UseVisualStyleBackColor = true;
            // 
            // btnRechercherOutil3
            // 
            this.btnRechercherOutil3.Location = new System.Drawing.Point(86, 241);
            this.btnRechercherOutil3.Name = "btnRechercherOutil3";
            this.btnRechercherOutil3.Size = new System.Drawing.Size(75, 23);
            this.btnRechercherOutil3.TabIndex = 6;
            this.btnRechercherOutil3.Text = "Rechercher";
            this.btnRechercherOutil3.UseVisualStyleBackColor = true;
            // 
            // accueil
            // 
            this.ClientSize = new System.Drawing.Size(776, 428);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "accueil";
            this.Text = "Accueil";
            this.tabControl1.ResumeLayout(false);
            this.tpCreerLocation.ResumeLayout(false);
            this.tpCreerLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDnbJours)).EndInit();
            this.tpCreerReservation.ResumeLayout(false);
            this.tpCreerReservation.PerformLayout();
            this.tpInfoClient.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpGestionOutils.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
