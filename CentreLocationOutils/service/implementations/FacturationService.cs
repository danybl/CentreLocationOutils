﻿using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.service.implementations
{
    /// <summary>
    /// Service de la table <code>facturation</code>.
    /// </summary>
    public class FacturationService : Service, IFacturationService
    {
        private IFacturationDAO facturationDAO;

        public FacturationService(IFacturationDAO facturationDAO)
            : base()
        {
            if (facturationDAO == null)
            {
                throw new InvalidDAOException("Le DAO de la facturation ne peut être null");
            }
            setFacturationDAO(facturationDAO);
        }

        #region Getters & Setters

            /// <summary>
            /// Getter de la variable d'instance <code>this.facturationDAO</code>.
            /// </summary>
            /// <returns>La variable d'instance <code>this.facturationDAO</code></returns>
            private IFacturationDAO getFacturationDAO()
            {
                return this.facturationDAO;
            }

            /// <summary>
            /// Setter de la variable d'instance <code>this.facturationDAO</code>.
            /// </summary>
            /// <param name="facturationDAO">La valeur à utiliser pour la variable d'instance <code>this.facturationDAO</code></param>
            private void setFacturationDAO(IFacturationDAO facturationDAO)
            {
                this.facturationDAO = facturationDAO;
            }

        #endregion

        #region CRUD
            /// <inheritdoc />
            public override void add(Connection connection, FacturationDTO facturationDTO)
                {
                    try
                    {
                        getFacturationDAO().add(connection, facturationDTO);
                    }
                    catch (DAOException daoException)
                    {
                        throw new ServiceException("Il y a eu un erreur : " + daoException);
                    }
                }

            /// <inheritdoc />
            public override FacturationDTO get(Connection connection, string idFacturation)
                {
                    try
                    {
                        return getFacturationDAO().get(connection, idFacturation);
                    }
                    catch (DAOException daoException)
                    {
                        throw new ServiceException("Il y a eu un erreur : " + daoException);
                    }
                }

            /// <inheritdoc />
            public override void update(Connection connection, FacturationDTO facturationDTO)
            {
                try
                {
                    getFacturationDAO().update(connection, facturationDTO);
                }
                catch (DAOException daoException)
                {
                    throw new ServiceException("Il y a eu un erreur : " + daoException);
                }
            }

            /// <inheritdoc />
            public override void delete(Connection connection, FacturationDTO facturationDTO)
            {
                try
                {
                    getFacturationDAO().delete(connection, facturationDTO);
                }
                catch (DAOException daoException)
                {
                    throw new ServiceException("Il y a eu un erreur : " + daoException);
                }
            }

        #endregion

        #region AUTRES
        /// <inheritdoc />
        public override List<FacturationDTO> getall(Connection connection, string sortByPropertyName)
        {
            try
            {
                return (List<FacturationDTO>)getFacturationDAO().getAll(connection, sortByPropertyName);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }


        /// <inheritdoc />
        public override List<FacturationDTO> findByClient(Connection connection, string idClient, string sortByPropertyName)
        {
            try
            {
                return (List<FacturationDTO>)getFacturationDAO().findByClient(connection, idClient, sortByPropertyName);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        /// <inheritdoc />
        public override List<FacturationDTO> findByEmploye(Connection connection, string idEmploye, string sortByPropertyName)
        {
            try
            {
                return (List<FacturationDTO>)getFacturationDAO().findByEmploye(connection, idEmploye, sortByPropertyName);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }
        #endregion
    }
}
