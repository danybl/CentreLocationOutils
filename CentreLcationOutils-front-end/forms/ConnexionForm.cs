using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using CentreLocationOutils.dto;

namespace CentreLocationOutils_front_end.forms
{
    public partial class ConnexionForm : Form
    {
        private CentreLocationOutils centreLocationOutils;
        public ConnexionForm()
        {
            InitializeComponent();
            centreLocationOutils = CentreLocationOutils.getInstance();
        }

        private void controlConnexion_connexionEchec(object sender, EventArgs e)
        {
            lblResultatConnexion.Text = "Échec de connexion";
        }

        private void controlConnexion_connexionReussie(object sender, EventArgs e)
        {
            Hashtable champsConnexion = new Hashtable();
            champsConnexion.Add("idEmploye",controlConnexion.labelUsername);
            champsConnexion.Add("password",controlConnexion.labelPassword);
            EmployeDTO employeDTO = centreLocationOutils.getEmploye(champsConnexion);
            if (employeDTO != null)
            {
                lblResultatConnexion.Text = "Connexion Reussie!";
                this.Dispose();
                AccueilForm accueilForm = new AccueilForm();
                accueilForm.Show();
            }
            lblResultatConnexion.Text = "Échec de connexion";
        }
    }
}
