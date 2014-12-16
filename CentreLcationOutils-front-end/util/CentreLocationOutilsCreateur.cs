using CentreLocationOutils.dao.implementations;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.exception.db;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.exception.util;
using CentreLocationOutils.facade.implementations;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.service.implementations;
using CentreLocationOutils.service.interfaces;
using System.Data.Common;
using Oracle.DataAccess.Client;

namespace CentreLocationOutils_front_end.util
{
    public class CentreLocationOutilsCreateur
    {
        public Connection MaConnection { get; private set; }
        public IClientFacade ClientFacade { get; private set; }
        public IEmployeFacade EmployeFacade { get; private set; }
        public IReservationFacade ReservationFacade { get; private set; }
        public ILocationFacade LocationFacade { get; private set; }
        public IOutilFacade OutilFacade { get; private set; }
        public IAdresseFacade AdresseFacade { get; private set; }
        public IFacturationFacade FacturationFacade { get; private set; }
        public ICategorieFacade CategorieFacade { get; set; }

        public OracleTransaction Transaction;
        //public ADODB._Connection testConnection;
        //public ADO

        public CentreLocationOutilsCreateur(string typeServeur,
            //string schema,
        string nomUtilisateur,
        string motPasse)
        {
            try
            {
                //testConnection = new ADODB.Connection();
                //testConnection.
                MaConnection = new Connection(typeServeur, nomUtilisateur, motPasse);
                MaConnection.ConnectionOracle.Open();

                IClientDAO clientDAO = new ClientDAO();
                IEmployeDAO employeDAO = new EmployeDAO();
                IReservationDAO reservationDAO = new ReservationDAO();
                ILocationDAO locationDAO = new LocationDAO();
                IOutilDAO outilDAO = new OutilDAO();
                IAdresseDAO adresseDAO = new AdresseDAO();
                IFacturationDAO facturationDAO = new FacturationDAO();
                ICategorieDAO categorieDAO = new CategorieDAO();

                IClientService clientService = new ClientService(clientDAO);
                IEmployeService employeService = new EmployeService(employeDAO);
                IReservationService reservationService = new ReservationService(reservationDAO, locationDAO);
                ILocationService locationService = new LocationService(locationDAO, reservationDAO);
                IOutilService outilService = new OutilService(outilDAO);
                IAdresseService adresseService = new AdresseService(adresseDAO);
                IFacturationService facturationService = new FacturationService(facturationDAO);
                ICategorieService categorieService = new CategorieService(categorieDAO);

                ClientFacade = new ClientFacade(clientService);
                EmployeFacade = new EmployeFacade(employeService);
                ReservationFacade = new ReservationFacade(reservationService);
                LocationFacade = new LocationFacade(locationService);
                OutilFacade = new OutilFacade(outilService);
                AdresseFacade = new AdresseFacade(adresseService);
                FacturationFacade = new FacturationFacade(facturationService);
                CategorieFacade = new CategorieFacade(categorieService);
            }
            catch (ConnectionException connectionException)
            {
                throw new CentreCreateurException("", connectionException);
            }
            catch (InvalidDAOException invalidDAOException)
            {
                throw new CentreCreateurException("", invalidDAOException);
            }
            catch (InvalidServiceException invalidServiceException)
            {
                throw new CentreCreateurException("", invalidServiceException);
            }
        }

        public void beginTransaction()
        {
            try
            {
                Transaction = MaConnection.ConnectionOracle.BeginTransaction();
            }
            catch (OracleException oracleException)
            {
                throw new CentreCreateurException("", oracleException);
            }
        }

        public void commitTransaction()
        {
            try
            {
                Transaction.Commit();
                close();
            }
            catch (OracleException oracleException)
            {
                throw new CentreCreateurException("", oracleException);
            }
        }

        public void rollbackTransaction()
        {
            try
            {
                Transaction.Rollback();
                close();
            }
            catch (OracleException oracleException)
            {
                throw new CentreCreateurException("", oracleException);
            }
        }

        public void close()
        {
            try
            {
                Transaction.Dispose();
            }
            catch (OracleException oracleException)
            {
                throw new CentreCreateurException("", oracleException);
            }
        }
        public void closeConnection()
        {
            MaConnection.close();
        }

    }
}

