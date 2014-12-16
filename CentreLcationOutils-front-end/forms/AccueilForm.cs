using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CentreLcationOutils_front_end.forms
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void btnAccueil_GestionClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionClientForm gestionClientsForm = new GestionClientForm();
            gestionClientsForm.Show();
        }

        private void btnAccueil_GestionOutils_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionOutilsForm gestionOutilsForm = new GestionOutilsForm();
            gestionOutilsForm.Show();
        }

        private void btnAccueil_GestionReservations_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionReservationsForm gestionReservationsForm = new GestionReservationsForm();
            gestionReservationsForm.Show();
        }

        private void btnAccueil_GestionFactures_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnAccueil_GestionLocations_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionLocationsForm gestionLocationsForm = new GestionLocationsForm();
            gestionLocationsForm.Show();
        }
    }
}
