using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLcationOutils_front_end.util;
using CentreLocationOutils.dto;
using CentreLocationOutils.facade;
using CentreLocationOutils.exception.dto;

namespace CentreLcationOutils_front_end
{
    public class CentreLocationOutils
    {
        private static CentreLocationOutilsCreateur gestionCentreOutils;
        private static double POURCENTAGE_DEPOT = 0.25;
        private static int NB_JOUR_LOCATION = 7;
        private static int NB_JOUR_RESERVATION = 3;
        public void inscrireClient(string[] champsClient)
        {
            //TODO vérifier dateInscription pas dans le futur => event sur le Time picker

            gestionCentreOutils.beginTransaction();
            string nomClient = champsClient[0];
            string prenomClient = champsClient[1];
            string telephoneClient = champsClient[2];
            string email = champsClient[3];
            string dateInscription = champsClient[4];
            string limiteLocationsClient = champsClient[5];
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Nom = nomClient;
            clientDTO.Prenom = prenomClient;
            clientDTO.Telephone = telephoneClient;
            clientDTO.LimiteLocations = limiteLocationsClient;
            clientDTO.NbLocations = "0";
            clientDTO.DateInscription = dateInscription;

            //gestionCentreOutils.ClientFacade.

            gestionCentreOutils.commitTransaction();
        }

        public void attribuerAdresse(string[] champsAdresse)
        {
            //TODO 
        }

        private void effectuerLocation(string[] faireLocation)
        {
            gestionCentreOutils.beginTransaction();

            string idClient = faireLocation[0];
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }

            string idOutil = faireLocation[1];
            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("L'outil " + idOutil + " n'existe pas");
            }
            string idEmploye = faireLocation[2];
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

        private void terminerLocation(string[] finirLocation)
        {
            gestionCentreOutils.beginTransaction();
            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = finirLocation[0];
            LocationDTO locationDTO = new LocationDTO();
            locationDTO.OutilDTO = outilDTO;
            List<LocationDTO> locations = gestionCentreOutils.LocationFacade.findByOutil(gestionCentreOutils.MaConnection, locationDTO);
            if (locations.Count == 0)
            {
                throw new MissingDTOException();
            }
            locationDTO = locations[0];
            gestionCentreOutils.LocationFacade.terminerLocation(gestionCentreOutils.MaConnection, locationDTO);
            gestionCentreOutils.commitTransaction();

        }

        private void engagerEmploye(string[] hireEmploy)
        {
            gestionCentreOutils.beginTransaction();
            EmployeDTO employeDTO = new EmployeDTO();
            employeDTO.Nom = hireEmploy[0];
            employeDTO.Prenom = hireEmploy[1];
            employeDTO.Telephone = hireEmploy[2];
            employeDTO.Email = hireEmploy[3];
            employeDTO.DateRecrutement = hireEmploy[4];
            employeDTO.Poste = hireEmploy[5];
            gestionCentreOutils.EmployeFacade.inscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

        }
        private void supprimerEmploye(string[] deleteEmploy)
        {
            gestionCentreOutils.beginTransaction();
            string idEmploye = deleteEmploy[0];
            EmployeDTO employeDTO = gestionCentreOutils.EmployeFacade.getEmploye(gestionCentreOutils.MaConnection, idEmploye);
            if (employeDTO == null)
            {
                throw new MissingDTOException("L'employé " + idEmploye + " n'existe pas");
            }
            gestionCentreOutils.EmployeFacade.desinscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

        }

        private void effectuerReservation(string[] faireReservation)
        {
            gestionCentreOutils.beginTransaction();

            string idClient = faireReservation[0];
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }

            string idOutil = faireReservation[1];
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

        private void annulerReservation(string[] cancelReservation)
        {

            gestionCentreOutils.beginTransaction();

            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = cancelReservation[0];
            ReservationDTO reservationDTO = new ReservationDTO();
            reservationDTO.OutilDTO = outilDTO;
            List<ReservationDTO> reservations = 
                gestionCentreOutils.ReservationFacade.findByOutil(gestionCentreOutils.MaConnection, reservationDTO);
            if (reservations.Count == 0)
            {
                throw new MissingDTOException();
            }
            reservationDTO = reservations[0];
            gestionCentreOutils.ReservationFacade.annulerReservation(
                gestionCentreOutils.MaConnection, reservationDTO);
            gestionCentreOutils.commitTransaction();
        }

        private void utiliserReservation(string[] useIt) {

            gestionCentreOutils.beginTransaction();

            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = useIt[0];
            ReservationDTO reservationDTO = new ReservationDTO();
            reservationDTO.OutilDTO = outilDTO;
            List<ReservationDTO> reservations = 
                gestionCentreOutils.ReservationFacade.findByOutil(gestionCentreOutils.MaConnection, reservationDTO);
            if(reservations.Count == 0){
                throw new MissingDTOException();
            }
            reservationDTO = reservations[0];
            gestionCentreOutils.ReservationFacade.utiliserReservation(
                gestionCentreOutils.MaConnection, reservationDTO);
            gestionCentreOutils.commitTransaction();
        }

    }
}
