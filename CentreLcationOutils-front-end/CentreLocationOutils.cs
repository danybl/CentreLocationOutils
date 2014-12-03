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
        private CentreLocationOutilsCreateur centreLocationOutilsCreateur;

        public void creerClient(string[] argsLocation, DateTime dateInscription)
        {
            //TODO vérifier dateInscription pas dans le futur => event sur le Time picker
            string nomClient = argsLocation[0];
            string prenomClient = argsLocation[1];
            string telephoneClient = argsLocation[2];
            string email = argsLocation[3];
            string limiteLocationsClient = argsLocation[4];
            ClientDTO clientDTO = new ClientDTO();
            clientDTO.Nom = nomClient;
            clientDTO.Prenom = prenomClient;
            clientDTO.Telephone = telephoneClient;
            clientDTO.LimiteLocations = limiteLocationsClient;
            clientDTO.NbLocations = "0";
            
            //TODO centreOutilCreateur.getFacadeXXXXX...

        }
    }
}
