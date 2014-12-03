using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.dao.implementations;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.db;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.util;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.service.interfaces;
using CentreLocationOutils.service.implementations;
using CentreLocationOutils.facade.implementations;

namespace CentreLcationOutils_front_end.util
{
    public class CentreLocationOutilsCreateur
    {
        public Connection Connection { get; private set; }
        public IClientFacade ClientFacade { get; private set; }
        public IEmployeFacade EmployeFacade { get; private set; }
        public IReservationFacade ReservationFacade { get; private set; }
        public ILocationFacade LocationFacade { get; private set; }
        public IOutilFacade OutilFacade { get; private set; }
        public IAdresseFacade AdresseFacade { get; private set; }
        public IFacturationFacade FacturationFacade { get; private set; }

        public CentreLocationOutilsCreateur()
        {
            try
            {
                IClientDAO clientDAO = new ClientDAO();
                IEmployeDAO employeDAO = new EmployeDAO();
                IReservationDAO reservationDAO = new ReservationDAO();
                ILocationDAO locationDAO = new LocationDAO();
                IOutilDAO outilDAO = new OutilDAO();
                IAdresseDAO adresseDAO = new AdresseDAO();
                IFacturationDAO facturationDAO= new FacturationDAO();

                IClientService clientService = new ClientService(clientDAO);
                IEmployeService employeService = new EmployeService(employeDAO);
                IReservationService reservationService = new ReservationService(reservationDAO, locationDAO);
                ILocationService locationService = new LocationService(locationDAO, reservationDAO);
                IOutilService outilService = new OutilService(outilDAO);
                IAdresseService adresseService = new AdresseService(adresseDAO);
                IFacturationService facturationService = new FacturationService(facturationDAO);

                ClientFacade = new ClientFacade(clientService);
                EmployeFacade = new EmployeFacade(employeService);
                ReservationFacade = new ReservationFacade(reservationService);
                LocationFacade = new LocationFacade(locationService);
                OutilFacade = new OutilFacade(outilService);
                AdresseFacade = new AdresseFacade(adresseService);
                FacturationFacade = new FacturationFacade(facturationService);
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

        public void commit()
        {
            try
            {
                Con
            }
        }
    }
}
