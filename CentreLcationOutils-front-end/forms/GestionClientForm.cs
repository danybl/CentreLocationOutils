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
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception.db;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;

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
                errorProviderNom.SetError(tbGestionClients_Nom, "Ce champ est obligatoire");
                aucunChampVide = false;
            }
            if (tbGestionClients_Prenom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Prenom, "Ce champ est obligatoire");
                aucunChampVide = false;
            }
            if (tbGestionClients_Telephone.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Telephone, "Ce champ est obligatoire");
                aucunChampVide = false;
            }
            if (tbGestionClients_Email.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Email, "Ce champ est obligatoire");
                aucunChampVide = false;
            }
            if (tbGestionClients_LimiteLocations.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_LimiteLocations, "Ce champ est obligatoire");
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
                }catch(MissingDTOException missingDTOException){
                    lblMessage.Text = missingDTOException.Message;
                }
            }
        }

        public void listerClient()
        {
            //dgGestionClients_ListeClients.DataSource = centreLocationOutils.
        }

        private void btnGestionAccueil_Modifier_Click(object sender, EventArgs e)
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
            bool aucunChampVide = true;
            if (tbGestionClients_Nom.TextLength == 0)
            {
                errorProviderNom.SetError(tbGestionClients_Nom, "Ce champ est obligatoire");
                aucunChampVide = false;
            }
            if (aucunChampVide)
            {
                string idClient = tbGestionClients_Id.Text;
            ConfirmationSuppression confirmationSuppression = new ConfirmationSuppression();
            confirmationSuppression.Message = "Supprimer le client " + idClient + " ?";
            DialogResult result = confirmationSuppression.ShowDialog();
                if(result.Equals(DialogResult.OK)){
                    try
                    {

                        Hashtable champsClient = new Hashtable();
                        champsClient.Add("idClient", idClient);
                        centreLocationOutils.desinscrireClient(champsClient);
                        lblMessage.Text = "Suppression effectuée";
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
                else { lblMessage.Text = "Suppression annulée"; }
            }
        }

    }
}