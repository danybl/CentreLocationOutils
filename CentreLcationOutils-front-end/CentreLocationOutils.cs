using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils_front_end.util;
using CentreLocationOutils.dto;
using CentreLocationOutils.facade;
using CentreLocationOutils.exception.dto;
using System.Collections;

namespace CentreLocationOutils_front_end
{
    public class CentreLocationOutils
    {
        private static CentreLocationOutilsCreateur gestionCentreOutils;
        private static CentreLocationOutils centreLocationOutil;
        private static double POURCENTAGE_DEPOT = 0.25;
        private static int NB_JOUR_LOCATION = 7;
        private static int NB_JOUR_RESERVATION = 3;

        public CentreLocationOutils() : base() { gestionCentreOutils = new CentreLocationOutilsCreateur("local", "location", "tiger")}

        public static CentreLocationOutils getInstance()
        {
            lock(typeof(CentreLocationOutils))
            {
                if (centreLocationOutil == null)
                {
                    centreLocationOutil = new CentreLocationOutils();
                }
            }
            return centreLocationOutil;
        }

        public void rollbackTransaction()
        {
                    gestionCentreOutils.rollbackTransaction();
                }            

        private void attribuerAdresse(Hashtable champsAdresse)
        {
            //TODO 
        }
        #region Commandes location
        public void effectuerLocation(Hashtable champsLocation)
        {
            gestionCentreOutils.beginTransaction();

            string idClient = champsLocation["idClient"].ToString();
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }

            string idOutil = champsLocation["idOutil"].ToString();
            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("L'outil " + idOutil + " n'existe pas");
            }
            string idEmploye = champsLocation["idEmploye"].ToString();
            EmployeDTO employeDTO = gestionCentreOutils.EmployeFacade.getEmploye(gestionCentreOutils.MaConnection, idEmploye);
            if (employeDTO == null)
            {
                throw new MissingDTOException("L'employé " + idEmploye + " n'existe pas");
            }
            LocationDTO locationDTO = new LocationDTO();
            locationDTO.ClientDTO = clientDTO;
            locationDTO.OutilDTO = outilDTO;
            locationDTO.EmployeDTO = employeDTO;
            locationDTO.Depot = (double.Parse(outilDTO.PrixLocation) * CentreLocationOutils.POURCENTAGE_DEPOT).ToString();
            locationDTO.DateLocation = DateTime.Now.Ticks.ToString();
            locationDTO.DateRetour = null;
            locationDTO.DateLimite = (DateTime.Now.Ticks + CentreLocationOutils.NB_JOUR_LOCATION).ToString();
            gestionCentreOutils.LocationFacade.commencerLocation(gestionCentreOutils.MaConnection, locationDTO);
            gestionCentreOutils.commitTransaction();
        }

        public void terminerLocation(Hashtable champsLocation)
        {
            gestionCentreOutils.beginTransaction();
            string idOutil = champsLocation["idOutil"].ToString();
            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("L'outil " + idOutil + "n'existe pas");
            }
            LocationDTO locationDTO = new LocationDTO();
            locationDTO.OutilDTO = outilDTO;
            List<LocationDTO> locations = gestionCentreOutils.LocationFacade.findByOutil(gestionCentreOutils.MaConnection, locationDTO);
            if (locations == null)
            {
                throw new MissingDTOException("Aucune location pour l'outil " + idOutil);
            }
            locationDTO = locations[0];
            gestionCentreOutils.LocationFacade.terminerLocation(gestionCentreOutils.MaConnection, locationDTO);
            gestionCentreOutils.commitTransaction();

        }

        public void renouvelerLocation(Hashtable champsLocation)
        {
            gestionCentreOutils.beginTransaction();
            string idLocation = champsLocation["idLocation"].ToString();
            LocationDTO locationDTO = gestionCentreOutils.LocationFacade.getLocation(gestionCentreOutils.MaConnection, idLocation);
            if (locationDTO == null)
            {
                throw new MissingDTOException("La location " + idLocation + " n'existe pas");
            }
            locationDTO.DateLimite = champsLocation["dateLimite"].ToString();
            gestionCentreOutils.LocationFacade.renouvelerLocation(gestionCentreOutils.MaConnection, locationDTO);
            gestionCentreOutils.commitTransaction();
            
        }
        #endregion fin commande location

        #region Commandes employé
        public void engagerEmploye(Hashtable champsEmploye)
        {
            gestionCentreOutils.beginTransaction();
            EmployeDTO employeDTO = new EmployeDTO();
            employeDTO.Nom = champsEmploye["nom"].ToString();
            employeDTO.Prenom = champsEmploye["prenom"].ToString();
            employeDTO.Telephone = champsEmploye["telephone"].ToString();
            employeDTO.Email = champsEmploye["email"].ToString();
            employeDTO.DateRecrutement = champsEmploye["dateRecrutement"].ToString();
            employeDTO.Poste = champsEmploye["poste"].ToString();
            gestionCentreOutils.EmployeFacade.inscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

        }
        public void supprimerEmploye(Hashtable champsEmploye)
        {
            gestionCentreOutils.beginTransaction();
            string idEmploye = champsEmploye["idEmploye"].ToString();
            EmployeDTO employeDTO = gestionCentreOutils.EmployeFacade.getEmploye(gestionCentreOutils.MaConnection, idEmploye);
            if (employeDTO == null)
            {
                throw new MissingDTOException("L'employé " + idEmploye + " n'existe pas");
            }
            gestionCentreOutils.EmployeFacade.desinscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

        }
        #endregion

        #region commandes Réservation
        public void effectuerReservation(Hashtable champsReservation)
        {
            gestionCentreOutils.beginTransaction();

            string idClient = champsReservation["idClient"].ToString();
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }

            string idOutil = champsReservation["idOutil"].ToString();
            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("L'outil " + idOutil + " n'existe pas");
            }

            ReservationDTO reservationDTO = new ReservationDTO();
            reservationDTO.ClientDTO = clientDTO;
            reservationDTO.OutilDTO = outilDTO;
            reservationDTO.DateReservation = DateTime.Now.Ticks.ToString();
            reservationDTO.DateLimite = (DateTime.Now.Ticks + CentreLocationOutils.NB_JOUR_RESERVATION).ToString();
            gestionCentreOutils.ReservationFacade.placerReservation(gestionCentreOutils.MaConnection, reservationDTO);
            gestionCentreOutils.commitTransaction();
        }

        public void annulerReservation(Hashtable champsReservation)
        {

            gestionCentreOutils.beginTransaction();
            string idOutil = champsReservation["idOutil"].ToString();
            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = idOutil;
            ReservationDTO reservationDTO = new ReservationDTO();
            reservationDTO.OutilDTO = outilDTO;
            List<ReservationDTO> reservations = 
                gestionCentreOutils.ReservationFacade.findByOutil(gestionCentreOutils.MaConnection, reservationDTO);
            if (reservations.Count == 0)
            {
                throw new MissingDTOException("Aucune réservation pour l'outil " + idOutil);
            }
            reservationDTO = reservations[0];
            gestionCentreOutils.ReservationFacade.annulerReservation(
                gestionCentreOutils.MaConnection, reservationDTO);
            gestionCentreOutils.commitTransaction();
        }

        public void utiliserReservation(Hashtable champsReservation)
        {

            gestionCentreOutils.beginTransaction();
            string idOutil = champsReservation["idOutil"].ToString();
            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = idOutil;
            ReservationDTO reservationDTO = new ReservationDTO();
            reservationDTO.OutilDTO = outilDTO;
            List<ReservationDTO> reservations = 
                gestionCentreOutils.ReservationFacade.findByOutil(gestionCentreOutils.MaConnection, reservationDTO);
            if(reservations.Count == 0){
                throw new MissingDTOException("Aucune réservation pour l'outil " + idOutil);
            }
            reservationDTO = reservations[0];
            gestionCentreOutils.ReservationFacade.utiliserReservation(
                gestionCentreOutils.MaConnection, reservationDTO);
            gestionCentreOutils.commitTransaction();
        }
        #endregion Fin commande réservation

        #region Commandes pour clients
        public void inscrireClient(Hashtable champsClient)
        {
            gestionCentreOutils.beginTransaction();
            string nomClient = champsClient["nomClient"].ToString();
            string prenomClient = champsClient["prenomClient"].ToString();
            string telephoneClient = champsClient["telephoneClient"].ToString();
            string email = champsClient["email"].ToString();
            string dateInscription = champsClient["dateInscription"].ToString();
            string limiteLocationsClient = champsClient["limiteLocation"].ToString();
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Nom = nomClient;
            clientDTO.Prenom = prenomClient;
            clientDTO.Telephone = telephoneClient;
            clientDTO.LimiteLocations = limiteLocationsClient;
            clientDTO.NbLocations = "0";
            clientDTO.DateInscription = dateInscription;
            gestionCentreOutils.ClientFacade.inscrire(gestionCentreOutils.MaConnection, clientDTO);
            gestionCentreOutils.commitTransaction();
        }

        public void updateClient(Hashtable champsClient)
        {

            gestionCentreOutils.beginTransaction();
            string idClient = champsClient["idClient"].ToString();
            string nomClient = champsClient["nomClient"].ToString();
            string prenomClient = champsClient["prenomClient"].ToString();
            string telephoneClient = champsClient["telephoneClient"].ToString();
            string email = champsClient["email"].ToString();
            string limiteLocationsClient = champsClient["limiteLocation"].ToString();
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }
            clientDTO.Nom = nomClient;
            clientDTO.Prenom = prenomClient;
            clientDTO.Telephone = telephoneClient;
            clientDTO.LimiteLocations = limiteLocationsClient;
            clientDTO.NbLocations = "0";
            gestionCentreOutils.ClientFacade.mettreAJourClient(gestionCentreOutils.MaConnection, clientDTO);
            gestionCentreOutils.commitTransaction();
        }

        public ClientDTO findClientById(Hashtable champsClient)
        {
            gestionCentreOutils.beginTransaction();
            string idClient = champsClient["idClient"].ToString();
            gestionCentreOutils.beginTransaction();
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + "n'existe pas");
            }
            gestionCentreOutils.commitTransaction();
            return clientDTO;
        }

        public List<ClientDTO> getAllClients()
        {
            gestionCentreOutils.beginTransaction();
            List<ClientDTO> clients = new List<ClientDTO>();
            clients = gestionCentreOutils.ClientFacade.getAllClients(gestionCentreOutils.MaConnection, ClientDTO.ID_CLIENT_COLUMN_NAME);
            gestionCentreOutils.commitTransaction();
            return clients;
        }

        public void desinscrireClient(Hashtable champsClient)
        {
            gestionCentreOutils.beginTransaction();
            string idClient = champsClient["idClient"].ToString();
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }
            gestionCentreOutils.ClientFacade.desinscrire(gestionCentreOutils.MaConnection, clientDTO);
            gestionCentreOutils.commitTransaction();
        }

         #endregion


        #region Commandes pour OUTILS

        public OutilDTO findOutilById(Hashtable champsOutil)
        {
            string idOutil = champsOutil["idOutil"].ToString();
            gestionCentreOutils.beginTransaction();

            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("Le outil " + idOutil + "n'existe pas");
            }
            return outilDTO;
        }

        public void ajouterOutil(Hashtable champOutil)
        {
                gestionCentreOutils.beginTransaction();
                string idOutil = champOutil["idOutil"].ToString();
                string idCategorie = champOutil["idCategorie"].ToString();
                string nom = champOutil["nom"].ToString();
                string numSerie = champOutil["numSerie"].ToString();
                string dateAcquisiton = champOutil["dateAcquisition"].ToString();
                string prixLocation = champOutil["prixLocation"].ToString();
                string description = champOutil["description"].ToString();
                //TODO image

                CategorieDTO categorieDTO = gestionCentreOutils.CategorieFacade.getCategorie(gestionCentreOutils.MaConnection, idCategorie);
                if (categorieDTO == null)
                {
                    throw new MissingDTOException("La catégorie " + idCategorie + " n'existe pas");
                }

                OutilDTO outilDTO = new OutilDTO();
                outilDTO.CategorieDTO = categorieDTO;
                outilDTO.Nom = nom;
                outilDTO.NumSerie = numSerie;
                outilDTO.DateAcquisition = dateAcquisiton;
                outilDTO.PrixLocation = prixLocation;
                outilDTO.Description = description;
                //outilDTO.image

                gestionCentreOutils.OutilFacade.acquerirOutil(gestionCentreOutils.MaConnection, outilDTO);
                gestionCentreOutils.commitTransaction();

        }

        public void modifierOutil(Hashtable champOutil)
        {
                gestionCentreOutils.beginTransaction();
                string idOutil = champOutil["idOutil"].ToString();
                string idCategorie = champOutil["idCategorie"].ToString();
                string nom = champOutil["nom"].ToString();
                string numSerie = champOutil["numSerie"].ToString();
                string dateAcquisiton = champOutil["dateAcquisition"].ToString();
                string prixLocation = champOutil["prixLocation"].ToString();
                string description = champOutil["description"].ToString();
                //TODO image

                CategorieDTO categorieDTO = gestionCentreOutils.CategorieFacade.getCategorie(gestionCentreOutils.MaConnection, idCategorie);
                if (categorieDTO == null)
                {
                    throw new MissingDTOException("La catégorie " + idCategorie + " n'existe pas");
                }

                OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
                outilDTO.CategorieDTO = categorieDTO;
                outilDTO.Nom = nom;
                outilDTO.NumSerie = numSerie;
                outilDTO.DateAcquisition = dateAcquisiton;
                outilDTO.PrixLocation = prixLocation;
                outilDTO.Description = description;
                //outilDTO.image

                gestionCentreOutils.OutilFacade.updateOutil(gestionCentreOutils.MaConnection, outilDTO);
                gestionCentreOutils.commitTransaction();
        }

        public void supprimerOutil(Hashtable champsOutil)
        {
            string idOutil = champsOutil["idOutil"].ToString();
            gestionCentreOutils.beginTransaction();

            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("Le outil " + idOutil + "n'existe pas");
            }

            gestionCentreOutils.OutilFacade.deleteOutil(gestionCentreOutils.MaConnection, outilDTO);


        }

        #endregion

    }
}
