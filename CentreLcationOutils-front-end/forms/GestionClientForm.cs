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

namespace CentreLcationOutils_front_end.forms
{
    public partial class GestionClientForm : Form
    {
        private CentreLocationOutils centreLocationOutils;
        public GestionClientForm()
        {
            InitializeComponent();
            centreLocationOutils = new CentreLocationOutils();
            tbGestionClients_DateInscription.Text = System.DateTime.Now.Ticks.ToString();
        }

        private void btnGestionAccueil_Rechercher_Click(object sender, EventArgs e)
        {
            if (tbGestionClients_Id.Text.Length > 0)
            {
                string idClient = tbGestionClients_Id.Text;
                Hashtable champsClient = new Hashtable();
                champsClient.Add("idClient", idClient);
                ClientDTO clientDTO = centreLocationOutils.findClientById(champsClient);

                tbGestionClients_Id.Text = clientDTO.IdClient;
                tbGestionClients_Nom.Text = clientDTO.Nom;
                tbGestionClients_Prenom.Text = clientDTO.Prenom;
                tbGestionClients_Telephone.Text = clientDTO.Telephone;
                tbGestionClients_Email.Text = clientDTO.Email;
                tbGestionClients_NbLocations.Text = clientDTO.NbLocations;
                tbGestionClients_LimiteLocations.Text = clientDTO.LimiteLocations;
            }
            else
            {

            }
        }

        private void btnGestionAccueil_Ajouter_Click(object sender, EventArgs e)
        {
            bool aucunChampVide = true;
            if (tbGestionClients_Nom.TextLength == 0)
            {
                //TODO ajouter un warning a cote du champ
                aucunChampVide = false;
            }
            if (tbGestionClients_Prenom.TextLength == 0)
            {

                aucunChampVide = false;
            }
            if (tbGestionClients_Telephone.TextLength == 0)
            {

                aucunChampVide = false;
            }
            if (tbGestionClients_Email.TextLength == 0)
            {

                aucunChampVide = false;
            }
            if (tbGestionClients_LimiteLocations.TextLength == 0)
            {

                aucunChampVide = false;
            }

            if (aucunChampVide)
            {
                string nom = tbGestionClients_Nom.Text;
                string prenom = tbGestionClients_Prenom.Text;
                string telephone = tbGestionClients_Telephone.Text;
                string email = tbGestionClients_Email.Text;
                string limiteLocation = tbGestionClients_LimiteLocations.Text;
                string dateInscription = tbGestionClients_DateInscription.Text;
                Hashtable champsClient = new Hashtable();
                champsClient.Add("nom", nom);
                champsClient.Add("prenom", prenom);
                champsClient.Add("telephone", telephone);
                champsClient.Add("email", email);
                champsClient.Add("limiteLocation", limiteLocation);
                champsClient.Add("dateInscription", dateInscription);
                centreLocationOutils.inscrireClient(champsClient);

            }
        }

        public void listerClient()
        {
            //dgGestionClients_ListeClients.DataSource = centreLocationOutils.
        }
    }
}
