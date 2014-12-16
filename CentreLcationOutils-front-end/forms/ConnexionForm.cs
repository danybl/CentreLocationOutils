using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CentreLocationOutils_front_end.forms
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void controlConnexion_connexionEchec(object sender, EventArgs e)
        {
            lblResultatConnexion.Text = "Échec de connexion";
        }

        private void controlConnexion_connexionReussie(object sender, EventArgs e)
        {
            lblResultatConnexion.Text = "Connexion Reussie!";
            this.Hide();
            AccueilForm accueilForm = new AccueilForm();
            accueilForm.Show();
        }
    }
}
