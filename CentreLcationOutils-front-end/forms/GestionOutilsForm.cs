using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CentreLocationOutils;
using System.Collections;
using CentreLocationOutils.dto;
namespace CentreLcationOutils_front_end.forms
{
    public partial class GestionOutilsForm : Form
    {
        CentreLocationOutils centreLocationOutils = new CentreLocationOutils();
        public GestionOutilsForm()
        {
            InitializeComponent();
        }

        private void btnGestionOutils_Rechercher_Click(object sender, EventArgs e)
        {
            if (tbGestionOutils_Id.Text.Length > 0)
            {
                errorProviderOutil.SetError(null, "");

                string idOuitl = tbGestionOutils_Id.Text;
                Hashtable champsOutil = new Hashtable();
                champsOutil.Add("idOutil", idOuitl);
                OutilDTO outilDTO = centreLocationOutils.findOutilById(champsOutil);

                tbGestionOutils_IdCategorie.Text = outilDTO.CategorieDTO.IdCategorie;
                tbGestionOutils_Nom.Text = outilDTO.Nom;
                tbGestionOutils_Description.Text = outilDTO.Description;
                tbGestionOutils_PrixLocation.Text = outilDTO.PrixLocation;
                tbGestionOutils_NumeroSerie.Text = outilDTO.NumSerie;
                tbGestionOutils_DateAcquisition.Text = outilDTO.DateAcquisition;
             
            }
            else
            {
                errorProviderOutil.SetError(tbGestionOutils_Id, "Ce champ doit contenir une valeur numérique positive");
            }

        }

        private bool champVide()
        {
            bool aucunChampVide = true;
            if (tbGestionOutils_IdCategorie.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_IdCategorie, "Ce champ est obligatoire");
            }
            else {
                errorProviderOutil.SetError(null, "");
            }
            if (tbGestionOutils_Nom.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_Nom, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderOutil.SetError(null, "");
            }
            if (tbGestionOutils_Description.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_Description, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderOutil.SetError(null, "");
            }
            if (tbGestionOutils_PrixLocation.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_PrixLocation, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderOutil.SetError(null, "");
            }
            if (tbGestionOutils_NumeroSerie.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_NumeroSerie, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderOutil.SetError(null, "");
            }
            if (tbGestionOutils_DateAcquisition.TextLength == 0)
            {
                aucunChampVide = false;
                errorProviderOutil.SetError(tbGestionOutils_DateAcquisition, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderOutil.SetError(null, "");
            }

            return aucunChampVide;
        } 
        private void btnGestionOutils_Ajouter_Click(object sender, EventArgs e)
        {
            bool aucunChampVide = champVide();

            if (aucunChampVide)
            {
                string idCatgegorie = tbGestionOutils_IdCategorie.Text;
                string nomOutil = tbGestionOutils_Nom.Text;
                string description = tbGestionOutils_Description.Text;
                string prixLocation = tbGestionOutils_PrixLocation.Text;
                string numeroSerie = tbGestionOutils_NumeroSerie.Text;
                string dateAcquisition = tbGestionOutils_DateAcquisition.Text;

                Hashtable champsOutil = new Hashtable();
                    champsOutil.Add("idCatgegorie", idCatgegorie);
                    champsOutil.Add("nomOutil", nomOutil);
                    champsOutil.Add("description", description);
                    champsOutil.Add("prixLocation", prixLocation);
                    champsOutil.Add("numeroSerie", numeroSerie);
                    champsOutil.Add("dateAcquisition", dateAcquisition);
                centreLocationOutils.ajouterOutil(champsOutil);

            }

        }

        private void btnGestionOutils_Modifier_Click(object sender, EventArgs e)
        {
            bool aucunChampVide = champVide();

            if (aucunChampVide)
            {
                string idCatgegorie = tbGestionOutils_IdCategorie.Text;
                string nomOutil = tbGestionOutils_Nom.Text;
                string description = tbGestionOutils_Description.Text;
                string prixLocation = tbGestionOutils_PrixLocation.Text;
                string numeroSerie = tbGestionOutils_NumeroSerie.Text;
                string dateAcquisition = tbGestionOutils_DateAcquisition.Text;

                Hashtable champsOutil = new Hashtable();
                champsOutil.Add("idCatgegorie", idCatgegorie);
                champsOutil.Add("nomOutil", nomOutil);
                champsOutil.Add("description", description);
                champsOutil.Add("prixLocation", prixLocation);
                champsOutil.Add("numeroSerie", numeroSerie);
                champsOutil.Add("dateAcquisition", dateAcquisition);
                centreLocationOutils.ajouterOutil(champsOutil);

            }
        }

        private void btnGestionOutils_Supprimer_Click(object sender, EventArgs e)
        {
            if (tbGestionOutils_Id.Text.Length > 0)
            {
                errorProviderOutil.SetError(null, "");

                string idOuitl = tbGestionOutils_Id.Text;
                Hashtable champsOutil = new Hashtable();
                champsOutil.Add("idOutil", idOuitl);
            }
            else
            {
                errorProviderOutil.SetError(tbGestionOutils_Id, "Ce champ doit contenir une valeur numérique positive");
            }
        }
    }
}
