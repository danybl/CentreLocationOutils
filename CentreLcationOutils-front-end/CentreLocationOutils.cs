using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLcationOutils_front_end.util;
using CentreLocationOutils.dto;
using CentreLocationOutils.facade;

namespace CentreLcationOutils_front_end
{
    public class CentreLocationOutils
    {
        private static CentreLocationOutilsCreateur gestionCentreOutils;

        public void inscrireClient(string[] champsClient, DateTime dateInscription)
        {
            //TODO vérifier dateInscription pas dans le futur => event sur le Time picker

            gestionCentreOutils.beginTransaction();
            string nomClient = champsClient[0];
            string prenomClient = champsClient[1];
            string telephoneClient = champsClient[2];
            string email = champsClient[3];
            string limiteLocationsClient = champsClient[4];
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
    }
}
