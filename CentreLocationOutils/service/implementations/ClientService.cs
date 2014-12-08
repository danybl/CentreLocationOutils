using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.service.interfaces;
using System;
using System.Collections.Generic;

namespace CentreLocationOutils.service.implementations
{
    public class ClientService : IClientService
    {
        private IClientDAO clientDAO;
        
        public ClientService(IClientDAO clientDAO) : base()
        {
          if(clientDAO == null) {
              throw new InvalidDAOException("Le DAO de client ne peut être null");
        }
        setClientDAO(clientDAO);
        }

        //set et get
        private IClientDAO getClientDAO()
        {
            return this.clientDAO;
        }

        private void setClientDAO(IClientDAO clientDAO)
        {
            this.clientDAO = clientDAO;
        }

        //Ajout d'un client
        public void add(Connection connection,
        ClientDTO clientDTO)
        {
        try {
             getClientDAO().add(connection,clientDTO);
        }
        catch (DAOException daoException)
        {
            throw new ServiceException(daoException.Message);
        }
        }

        //Lecture des clients
        public   ClientDTO get(Connection connection,String idClient){
        try {
            return (ClientDTO)getClientDAO().get(connection,idClient); 
        }
        catch (DAOException daoException)
        {
            throw new ServiceException(daoException.Message);
        }
        }

        //Mise à jour d'un client
        public   void update(Connection connection,
        ClientDTO clientDTO)
        {
            try
            {
                getClientDAO().update(connection, clientDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

        //Suppression d'un client
        public   void delete(Connection connection,
        ClientDTO clientDTO)
        {
            try
            {
                getClientDAO().delete(connection, clientDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

      //Lecture de toutes les clients
        public   List<ClientDTO> getAll(Connection connection, String sortByPropertyName)
        {
            try
            {
                return (List<ClientDTO>)getClientDAO().getAll(connection,sortByPropertyName); 
         }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

        //Trouver un client par son nom
        public   List<ClientDTO> findByNom(Connection connection, String nom, String sortByPropertyName)
        {
         try {
         return getClientDAO().findByNom(connection,
                nom,
                sortByPropertyName);
        } 
         catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
            }


        public List<ClientDTO> inscrire(Connection connection, ClientDTO clientDTO)
        {
            //TODO inscrire
        }
    }
}
