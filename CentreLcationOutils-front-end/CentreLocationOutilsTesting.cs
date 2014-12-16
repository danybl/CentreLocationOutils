using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils_front_end.util;
using System.IO;
using CentreLocationOutils.exception;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.exception.facade;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace CentreLocationOutils_front_end
{
    public class CentreLocationOutilsTesting
    {
        private static CentreLocationOutilsCreateur gestionCentreOutils;
        private static double POURCENTAGE_DEPOT = 0.25;
        private static int NB_JOUR_LOCATION = 7;

        public CentreLocationOutilsTesting()
            : base()
        {
           startReading();

        }

        private void startReading()
        {
            try
            {
                
                //Console.WriteLine("path: " + Application.StartupPath + @"\ress\test.txt");
                
                //string path = Path.GetFullPath(Properties.Resources.test);
                Console.WriteLine("path: " + Application.StartupPath + @"\ress\test.txt");
                StreamReader reader = new StreamReader(Application.StartupPath + @"\ress\test.txt");
                gestionCentreOutils = new CentreLocationOutilsCreateur("local", "location", "tiger");
                traiterTransaction(reader);
            }
            catch (IOException ioException)
            {
                Console.WriteLine("ERREUUUUUUURRR: " + ioException.Message );
            }

        }

        private string lireTransaction(StreamReader reader)
        {
            Console.Write(">");
            string transaction = reader.ReadLine();
            //Console.WriteLine(transaction);
            return transaction;
        }

        private void traiterTransaction(StreamReader reader)
        {
            //AfficherAide()
            string transaction = lireTransaction(reader);
            while (!finTransaction(transaction))
            {
                List<string> splitter = transaction.Split(' ').ToList<string>();
                if (splitter.Count > 0)
                {
                    executerTransaction(splitter);
                    splitter.RemoveAt(0);
                }
                transaction = lireTransaction(reader);
            }
        }


        private bool finTransaction(string transaction)
        {
            if (transaction == null)
            {
                return true;
            }
            List<string> splitter = transaction.Split(' ').ToList<string>();
            if (splitter.Count >0)
            {
                return false;
            }
            string commande = splitter.First<string>().ToLower();
            //splitter.RemoveAt(0);
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
                        break;
                    case "engageremploye": engagerEmploye(splitter);
                        break;
                    case "updatecategorie": updateCategorie(splitter);
                        break;

                }
            }
            catch (NullReferenceException nullRefException)
            {
                gestionCentreOutils.rollbackTransaction();
                Console.WriteLine(nullRefException);
                //throw new CentreLocationOutilsException(nullRefException.Message);
            }
            catch (InvalidDTOException invalidDTOException)
            {
                gestionCentreOutils.rollbackTransaction();
                Console.WriteLine(invalidDTOException);
            }
            catch (FacadeException facadeException)
            {
                gestionCentreOutils.rollbackTransaction();
                Console.WriteLine(facadeException);
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
            Console.WriteLine("  louer <idOutil> <idMembre> <idEmployé>");
            Console.WriteLine("  renouveler <idLocation>");
            Console.WriteLine("  terminer <idLocation>");
            Console.WriteLine("  inscrire <nom> <prenom> <telephone> <email> <limiteLocation>");
            Console.WriteLine("  desinscrire <idClient>");
            Console.WriteLine("  reserver <idOutil> <idClient>");
            Console.WriteLine("  utiliser <idReservation>");
            Console.WriteLine("  annulerReservation <idReservation>");
        }

        public void updateCategorie(List<string> splitter)
        {
            gestionCentreOutils.beginTransaction();
            string nom = readString(splitter);
            List<CategorieDTO> categories = gestionCentreOutils.CategorieFacade.findByNom(gestionCentreOutils.MaConnection, nom, CategorieDTO.NOM_COLUMN_NAME);
            if (categories.Count == 0)
            {

            }
        }
        private void effectuerLocation(List<string> splitter)
        {
            gestionCentreOutils.beginTransaction();

            string idClient = readString(splitter);
            ClientDTO clientDTO = gestionCentreOutils.ClientFacade.getClient(gestionCentreOutils.MaConnection, idClient);
            if (clientDTO == null)
            {
                throw new MissingDTOException("Le client " + idClient + " n'existe pas");
            }

            string idOutil = readString(splitter);
            OutilDTO outilDTO = gestionCentreOutils.OutilFacade.getOutil(gestionCentreOutils.MaConnection, idOutil);
            if (outilDTO == null)
            {
                throw new MissingDTOException("L'outil " + idOutil + " n'existe pas");
            }
            string idEmploye = readDate(splitter);
            EmployeDTO employeDTO = gestionCentreOutils.EmployeFacade.getEmploye(gestionCentreOutils.MaConnection, idEmploye);
            if (employeDTO == null)
            {
                throw new MissingDTOException("L'employé " + idEmploye + " n'existe pas");
            }
            LocationDTO locationDTO = new LocationDTO();
            locationDTO.ClientDTO = clientDTO;
            locationDTO.OutilDTO = outilDTO;
            locationDTO.EmployeDTO = employeDTO;
            locationDTO.Depot = (double.Parse(outilDTO.PrixLocation) * CentreLocationOutilsTesting.POURCENTAGE_DEPOT).ToString();
            locationDTO.DateLocation = DateTime.Now.Ticks.ToString();
            locationDTO.DateRetour = null;
            locationDTO.DateLimite = (DateTime.Now.Ticks + CentreLocationOutilsTesting.NB_JOUR_LOCATION).ToString();
            gestionCentreOutils.LocationFacade.commencerLocation(gestionCentreOutils.MaConnection, locationDTO);
            gestionCentreOutils.commitTransaction();
        }

        private void terminerLocation(List<string> splitter)
        {
            gestionCentreOutils.beginTransaction();
            OutilDTO outilDTO = new OutilDTO();
            outilDTO.IdOutil = readString(splitter);
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

        private void engagerEmploye(List<string> splitter)
        {
            gestionCentreOutils.beginTransaction();
            EmployeDTO employeDTO = new EmployeDTO();
            employeDTO.Nom = readString(splitter);
            employeDTO.Prenom = readString(splitter);
            employeDTO.Telephone = readString(splitter);
            employeDTO.Email = readString(splitter);
            employeDTO.DateRecrutement = readDate(splitter);
            employeDTO.Poste = readString(splitter);
            gestionCentreOutils.EmployeFacade.inscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

        }
        private void supprimerEmploye(List<string> splitter)
        {
            gestionCentreOutils.beginTransaction();
            string idEmploye = readString(splitter);
            EmployeDTO employeDTO = gestionCentreOutils.EmployeFacade.getEmploye(gestionCentreOutils.MaConnection, idEmploye);
            if (employeDTO == null)
            {
                throw new MissingDTOException("L'employé " + idEmploye + " n'existe pas");
            }
            gestionCentreOutils.EmployeFacade.desinscrireEmploye(gestionCentreOutils.MaConnection, employeDTO);
            gestionCentreOutils.commitTransaction();

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

        public string readDate(List<string> splitter)
        {
            string lecture;
            if (splitter.Count > 0)
            {
                try
                {
                    lecture = DateTime.Parse(splitter.First<string>().ToLower()).ToString();
                }
                catch (FormatException formatException)
                {
                    throw new CentreLocationOutilsException("Date en format AAAA-MM-JJ attendue " + formatException);
                }
                return lecture;
            }
            throw new CentreLocationOutilsException("autre paramètre attendu");
        }
    }
}
