using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.exception.db;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using System.Data.Common;

namespace CentreLocationOutils.service.implementations
{
    class CategorieService
    {
        private IAdresseDAO adresseDAO;
        private ICategorieDAO categorieDAO;
        private IClientDAO clientDAO;
        private IEmployeDAO employeDAO;
        private IFacturationDAO facturationDAO;
        private ILocationDAO locationDAO;
        private IOutilDAO outilDAO;
        private IReservationDAO reservationDAO;

        public CategorieService(IAdresseDAO adresseDAO, ICategorieDAO categorieDAO, IClientDAO clientDAO,
            IEmployeDAO employeDAO, IFacturationDAO facturationDAO, ILocationDAO locationDAO, IOutilDAO outilDAO,
            IReservationDAO reservationDAO) {

                if (adresseDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de adresse ne peut être null");
                }
                if (categorieDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de categorie ne peut être null");
                }
                if (clientDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de client ne peut être null");
                }
                if (employeDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de employe ne peut être null");
                }
                if (facturationDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de facturation ne peut être null");
                }
                if (locationDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de location ne peut être null");
                }
                if (outilDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de outil ne peut être null");
                }
                if (reservationDAO == null)
                {
                    throw new InvalidDAOException("Le DAO de réservation ne peut être null");
                }
                setAdresseDAO(adresseDAO);
                setCategorieDAO(categorieDAO);
                setClientDAO(clientDAO);
                setEmployeDAO(employeDAO);
                setFacturationDAO(facturationDAO);
                setLocationDAO(locationDAO);
                setOutilDAO(outilDAO);
                setReservationDAO(reservationDAO);
        }
        private IAdresseDAO getAdresseDAO()
        {
            return this.adresseDAO;
        }
        private ICategorieDAO getCategorieDAO()
        {
            return this.categorieDAO;
        }
        private IClientDAO getClientDAO()
        {
            return this.clientDAO;
        }
        private IEmployeDAO getEmployeDAO()
        {
            return this.employeDAO;
        }
        private IFacturationDAO getFacturationDAO()
        {
            return this.facturationDAO;
        }
        private ILocationDAO getLocationDAO()
        {
            return this.locationDAO;
        }
        private IOutilDAO getOulilDAO()
        {
            return this.outilDAO;
        }
        private IReservationDAO getReservationDAO()
        {
            return this.reservationDAO;
        }
        private void setAdresseDAO(IAdresseDAO adresseDAO)
        {
            this.adresseDAO = adresseDAO;
        }
        private void setCategorieDAO(ICategorieDAO categorieDAO)
        {
            this.categorieDAO = categorieDAO;
        }
        private void setClientDAO(IClientDAO clientDAO)
        {
            this.clientDAO = clientDAO;
        }
        private void setEmployeDAO(IEmployeDAO employeDAO)
        {
            this.employeDAO = employeDAO;
        }
        private void setFacturationDAO(IFacturationDAO facturationDAO)
        {
            this.facturationDAO = facturationDAO;
        }
        private void setLocationDAO(ILocationDAO locationDAO)
        {
            this.locationDAO = locationDAO;
        }
        private void setOutilDAO(IOutilDAO outilDAO)
        {
            this.outilDAO = outilDAO;
        }
        private void setReservationDAO(IReservationDAO reservationDAO)
        {
            this.reservationDAO = reservationDAO;
        }
    
    //Ajout d'un livre
    public void add(Connection connection,
        CategorieDTO categorieDTO) {
        try {
            getCategorieDAO().add(connection,
                categorieDTO);
        }
        catch (DbException dbException)
        {
            throw new DAOException(dbException);
        }
    }
    }
}
