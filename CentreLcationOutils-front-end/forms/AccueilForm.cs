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
    }
}
