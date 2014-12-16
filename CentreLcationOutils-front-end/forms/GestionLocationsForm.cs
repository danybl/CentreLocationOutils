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
using CentreLocationOutils_front_end.util;

namespace CentreLocationOutils_front_end.forms
{
    public partial class GestionLocationsForm : Form
    {
        private CentreLocationOutils centreLocationOutil;
        public GestionLocationsForm()
        {
            InitializeComponent();
            centreLocationOutil = CentreLocationOutils.getInstance();
            tbGestionLocations_IdLocation.TextChanged += new EventHandler(resetErrorProviderIdLocation);
            tbGestionLocations_IdClient.TextChanged += new EventHandler(resetErrorProviderIdClient);
            tbGestionLocations_IdOutil.TextChanged += new EventHandler(resetErrorProviderIdOutil);
            tbGestionLocations_IdEmploye.TextChanged += new EventHandler(resetErrorProviderIdEmploye);
            tbGestionLocations_Depot.TextChanged += new EventHandler(resetErrorProviderDepot);
            //tbGestionLocations_DateRetour.TextChanged += new EventHandler(resetErrorProviderDateRetour);

        }

        private void resetErrorProviderDepot(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderDepot.SetError(null, "");
        }

        private void resetErrorProviderIdEmploye(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderEmploye.SetError(null, "");
        }

        private void resetErrorProviderIdOutil(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderOutil.SetError(null, "");
        }

        private void resetErrorProviderIdClient(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderClient.SetError(null, "");
        }

        private void resetErrorProviderIdLocation(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderId.SetError(null, "");
        }

        private void btnGestionLocations_Rechercher_Click(object sender, EventArgs e)
        {
            bool aucunChampVide = true;
            if (tbGestionLocations_IdLocation.TextLength == 0)
            {
                errorProviderId.SetError(tbGestionLocations_IdLocation, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (aucunChampVide)
            {
                
                Hashtable champsLocation = new Hashtable();
                champsLocation.Add("idLocation", idLocation);
                LocationDTO lcoationDTO = CentreLocationOutils

            }
        }

        private void btnGestionLocations_Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionLocations_Renouveler_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionLocations_Annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
