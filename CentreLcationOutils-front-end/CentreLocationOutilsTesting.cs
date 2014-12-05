using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLcationOutils_front_end.util;
using System.IO;
using CentreLocationOutils.exception;
using CentreLocationOutils.dto;

namespace CentreLcationOutils_front_end
{
    public class CentreLocationOutilsTesting
    {

        private static CentreLocationOutilsCreateur gestionCentreOutils;

        public CentreLocationOutilsTesting()
            : base()
        {
            startReading();

        }

        private void startReading()
        {
            StringReader streamReader = (StringReader)Console.In;

            gestionCentreOutils = new CentreLocationOutilsCreateur("local", "location", "tiger");
        }

        private string lireTransaction(StringReader stringReader)
        {
            Console.Write("> ");
            string transaction = stringReader.ReadLine();
            Console.WriteLine(transaction);
            return transaction;
        }

        private void traiterTransaction(StringReader stringReader)
        {
            //AfficherAide()
            string transaction = lireTransaction(stringReader);
            while (!finTransaction(transaction))
            {
                List<string> splitter = transaction.Split(' ').ToList<string>();
                if (splitter.Count > 0)
                {
                    executerTransaction(splitter);
                }
            }
        }


        private bool finTransaction(string transaction)
        {
            if (transaction == null)
            {
                return true;
            }
            List<string> splitter = transaction.Split(' ').ToList<string>();
            if (splitter.Count == 0)
            {
                return false;
            }
            string commande = splitter.First<string>().ToLower();
            splitter.RemoveAt(0);
            if (commande.Equals("exit"))
            {
                return true;
            }
            return false;
        }

        private void executerTransaction(List<string> splitter)
        {
            try
            {
                string commande = splitter.First<string>().ToLower();
                splitter.RemoveAt(0);
                switch (commande)
                {
                    case "aide": afficherAide();
                        break;
                    case "louer": effectuerLocation(splitter);
                }
            }
            catch (NullReferenceException nullRefException)
            {
                throw new CentreLocationOutilsException(nullRefException.Message);
            }
        }

        private void afficherAide()
        {
            Console.WriteLine();
            Console.WriteLine("Chaque transaction comporte un nom et une liste d'arguments");
            Console.WriteLine("separes par des espaces. La liste peut etre vide.");
            Console.WriteLine(" Les dates sont en format yyyy-mm-dd.");
            Console.WriteLine("");
            Console.WriteLine("Les transactions sont:");
            Console.WriteLine("  aide");
            Console.WriteLine("  exit");
            Console.WriteLine("  louer <idOutil> <idMembre>");
            Console.WriteLine("  renouveler <idLocation>");
            Console.WriteLine("  terminer <idLocation>");
            Console.WriteLine("  inscrire <nom> <prenom> <telephone> <email> <limiteLocation>");
            Console.WriteLine("  desinscrire <idClient>");
            Console.WriteLine("  reserver <idOutil> <idClient>");
            Console.WriteLine("  utiliser <idReservation>");
            Console.WriteLine("  annulerReservation <idReservation>");
        }

        private void effectuerLocation(List<string> splitter){
            try
            {
                gestionCentreOutils.beginTransaction();

                string idMembre = readString(splitter);
                //ClientDTO clientDTO = gestionCentreOutils.ClientFacade.

                string idOutil = readString(splitter);
                //OutilDTO outilDTO = gestionCentreOutils.OutilFacade.
                
            }
        }

        private void engagerEmploye(List<string> splitter)
        {
            try
            {
                gestionCentreOutils.beginTransaction();
                EmployeDTO employeDTO = new EmployeDTO();
                employeDTO.Nom = readString(splitter);
                employeDTO.Prenom = readString(splitter);
                employeDTO.Telephone = readString(splitter);
                employeDTO.Email = readString(splitter);
                employeDTO.DateRecrutement = readDate(splitter);
                employeDTO.Poste = readString(splitter);
                gestionCentreOutils.EmployeFacade.inscrireEmploye(gestionCentreOutils.Connection, employeDTO);
            }
        }

        public string readString(List<string> splitter)
        {
            string lecture = ""; 
            if (splitter.Count > 0)
            {
                lecture = splitter.First<string>().ToLower();
                splitter.RemoveAt(0);
                return lecture;
            }
            throw new CentreLocationOutilsException("autre paramètre attendu");
        }

        public DateTime readDate(List<string> splitter)
        {
            DateTime lecture;
            if (splitter.Count > 0)
            {
                try
                {
                    lecture = DateTime.Parse(splitter.First<string>().ToLower());
                }
                catch (FormatException formatException)
                {
                    throw new CentreLocationOutilsException("Date en format AAAA-MM-JJ attendue "+ formatException);
                }
                return lecture;
            }
            throw new CentreLocationOutilsException("autre paramètre attendu");
        }
    } 
}
