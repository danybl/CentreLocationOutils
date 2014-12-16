using CentreLocationOutils_front_end.util;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.db;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception.facade;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using CentreLocationOutils.exception.dao;

namespace CentreLocationOutils_front_end.forms
{
    public partial class GestionClientForm : Form
    {
        private CentreLocationOutils centreLocationOutils;
        public GestionClientForm()
        {
            InitializeComponent();
            centreLocationOutils = CentreLocationOutils.getInstance();
            tbGestionClients_DateInscription.Text = System.DateTime.Now.Ticks.ToString();
            tbGestionClients_Nom.TextChanged += new EventHandler(resetErrorProviderNom);
            tbGestionClients_Prenom.TextChanged += new EventHandler(resetErrorProviderPrenom);
            tbGestionClients_Telephone.TextChanged += new EventHandler(resetErrorProviderTelephone);
            tbGestionClients_Email.TextChanged += new EventHandler(resetErrorProviderEmail);
            tbGestionClients_Id.TextChanged += new EventHandler(resetErrorProviderId);
            tbGestionClients_LimiteLocations.TextChanged += new EventHandler(resetErrorProviderLimiteLocation);
        }

        private void resetErrorProviderLimiteLocation(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderLimiteLocation.SetError(null, "");
        }

        private void resetErrorProviderId(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderId.SetError(null, "");
        }

        private void resetErrorProviderEmail(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderEmail.SetError(null, "");
        }

        private void resetErrorProviderTelephone(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderTelephone.SetError(null, "");
        }

        private void resetErrorProviderPrenom(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderPrenom.SetError(null, "");
        }

        private void resetErrorProviderNom(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            errorProviderNom.SetError(null, "");
        }

        private void btnGestionAccueil_Rechercher_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            dgGestionClients_ListeClients.Rows.Clear();
            bool aucunChampVide = true;
            if (tbGestionClients_Nom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Id, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (aucunChampVide)
            {
                string idClient = tbGestionClients_Id.Text;
                Hashtable champsClient = new Hashtable();
                champsClient.Add("idClient", idClient);

                ClientDTO clientDTO = centreLocationOutils.findClientById(champsClient);
                if (clientDTO != null)
                {
                    dgGestionClients_ListeClients.Rows.Clear();
                    dgGestionClients_ListeClients.Rows.Add(clientDTO.IdClient, clientDTO.Nom, clientDTO.Prenom, clientDTO.Telephone, clientDTO.Email, clientDTO.NbLocations, clientDTO.LimiteLocations);
                }
            }
        }

        private void btnGestionAccueil_Ajouter_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            bool aucunChampVide = true;
            if (tbGestionClients_Nom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Nom, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (tbGestionClients_Prenom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Prenom, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (tbGestionClients_Telephone.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Telephone, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (tbGestionClients_Email.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Email, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (tbGestionClients_LimiteLocations.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_LimiteLocations, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }

            if (aucunChampVide)
            {
                try
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
                catch (MissingDTOException missingDTOException)
                {
                    lblMessage.Text = missingDTOException.Message;
                }
            }
        }

        public void listerClient()
        {
            lblMessage.Text = "";
            dgGestionClients_ListeClients.Rows.Clear();
            try{
            List<ClientDTO> clients = centreLocationOutils.getAllClients();
                dgGestionClients_ListeClients.Rows.Clear();
                if(clients.Count != 0){
            foreach (ClientDTO clientDTO in clients)
            {
                dgGestionClients_ListeClients.Rows.Add(clientDTO.IdClient, clientDTO.Nom, clientDTO.Prenom, clientDTO.Telephone, clientDTO.Email, clientDTO.NbLocations, clientDTO.LimiteLocations);
            }
                }
            }
            catch (InvalidConnectionException invalidConnectionException)
            {
                centreLocationOutils.rollbackTransaction();
                lblMessage.Text = invalidConnectionException.Message;
            }
            catch (InvalidSortByPropertyException invalidSortByPropertyName)
            {
                centreLocationOutils.rollbackTransaction();
                lblMessage.Text = invalidSortByPropertyName.Message;
            }
        }

        private void btnGestionAccueil_Modifier_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
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
                try
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
                catch (MissingDTOException missingDTOException)
                {
                    lblMessage.Text = missingDTOException.Message;
                }
                catch (ConnectionException connection)
                {
                    lblMessage.Text = connection.Message;
                }
                catch (FacadeException facadeException)
                {
                    lblMessage.Text = facadeException.Message;
                }
            }
        }

        private void btnGestionAccueil_Supprimer_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            bool aucunChampVide = true;
            if (tbGestionClients_Nom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Nom, Constants.CHAMP_OBLIGATOIRE);
                aucunChampVide = false;
            }
            if (aucunChampVide)
            {
                string idClient = tbGestionClients_Id.Text;
                ConfirmationSuppression confirmationSuppression = new ConfirmationSuppression();
                confirmationSuppression.Message = Constants.DEMANDE_CONFIRMATION_SUPPRESSION_CLIENT + idClient + " ?";
                DialogResult result = confirmationSuppression.ShowDialog();
                if (result.Equals(DialogResult.OK))
                {
                    try
                    {

                        Hashtable champsClient = new Hashtable();
                        champsClient.Add("idClient", idClient);
                        centreLocationOutils.desinscrireClient(champsClient);
                        lblMessage.Text = Constants.CONFIRMATION_SUPPRESSION;
                    }
                    catch (MissingDTOException missingDTOException)
                    {
                        lblMessage.Text = missingDTOException.Message;
                    }
                    catch (ConnectionException connection)
                    {
                        lblMessage.Text = connection.Message;
                    }
                    catch (FacadeException facadeException)
                    {
                        lblMessage.Text = facadeException.Message;
                    }
                }
                else { lblMessage.Text = Constants.ANNULATION_SUPPRESSION; }
            }
        }

        private void btnGestionAccueil_Lister_Click(object sender, EventArgs e)
        {
            listerClient();
        }

    }
}