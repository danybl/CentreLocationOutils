using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.service.implementations
{
    public class ClientService : CentreLocationOutils.service.interfaces.IClientService
    {
        private IClientDAO clientDAO;
        private IReservationDAO reservationDAO;
        
        public ClientService(IClientDAO clientDAO,IReservationDAO reservationDAO) : base()
        {
          if(clientDAO == null) {
              throw new InvalidDAOException("Le DAO de Client ne peut être null");
        }
        if(reservationDAO == null) {
            throw new InvalidDAOException("Le DAO de réservation ne peut être null");
        }
        setClientDAO(clientDAO);
        setReservationDAO(reservationDAO);
        }

        private IClientDAO getClientDAO()
        {
            return this.clientDAO;
        }

        private void setClientDAO(IClientDAO clientDAO)
        {
            this.clientDAO = clientDAO;
        }

        private IReservationDAO getReservationDAO()
        {
            return this.reservationDAO;
        }

        private void setReservationDAO(IReservationDAO reservationDAO)
        {
            this.reservationDAO = reservationDAO;
        }

        public void add(Connection connection,
        ClientDTO clientDTO)
        {
        try {
             getClientDAO().add(connection,clientDTO);
        } catch (DAOException daoException){
        throw new ServiceException(daoException.ToString());
        }
        }
        
        public ClientDTO get(Connection connection,String idClient){
        try {
            return (ClientDTO)getClientDAO().get(connection,idClient); 
        }
        catch (DAOException daoException)
        {
            throw new ServiceException(daoException.ToString());
        }
        } 

        public void update(Connection connection,
        ClientDTO clientDTO)
        {
            try
            {
                getClientDAO().update(connection, clientDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.ToString());
            }
        }

        public void delete(Connection connection,
        ClientDTO clientDTO)
        {
            try
            {
                getClientDAO().delete(connection, clientDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.ToString());
            }
        }
      public List<ClientDTO> getAll(Connection connection,String sortByPropertyName)
        {
            try
            {
                return (List<ClientDTO>)getClientDAO().getAll(connection,sortByPropertyName); 
         }
         catch (DAOException daoException) 
            {
                throw new ServiceException(daoException.ToString());
            }
        } 

        public List<ClientDTO> findByNom(Connection connection,String nom,String sortByPropertyName){
         try {
         return getClientDAO().findByNom(connection,
                nom,
                sortByPropertyName);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.ToString());
        }
        }
    }
}