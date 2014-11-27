using CentreLocationOutils.dao.implementations;
using CentreLocationOutils.dao.interfaces;
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
    /// Service de la table <code>location</code>.
    /// </summary>
    class LocationService : Service, ILocationService
    {
        private ILocationDAO locationDAO;
        private IClientDAO clientDAO;
        private IEmployeDAO employeDAO;
        private IOutilDAO outilDAO;

        /// <summary>
        /// Crée le service de la table <code>location</code>.
        /// </summary>
        /// <param name="locationDAO">Le DAO de la table <code>location</code></param>
        /// <param name="clientDAO">Le DAO de la table <code>client</code></param>
        /// <param name="employeDAO">Le DAO de la table <code>employe</code></param>
        /// <param name="outilDAO">Le DAO de la table <code>outil</code></param>
        public LocationService(ILocationDAO locationDAO, IClientDAO clientDAO, 
            IEmployeDAO employeDAO, OutilDAO outilDAO) : base()
        {
            if (locationDAO == null)
            {
                throw new InvalidDAOException("Le DAO de location ne peut être null");
            }
            if (clientDAO == null)
            {
                throw new InvalidDAOException("Le DAO de client ne peut être null");
            }
            if (employeDAO == null)
            {
                throw new InvalidDAOException("Le DAO d'employe ne peut être null");
            }
            if (outilDAO == null)
            {
                throw new InvalidDAOException("Le DAO d'outil ne peut être null");
            }
            setLocationDAO(locationDAO);
            setClientDAO(clientDAO);
            setEmployeDAO(employeDAO);
            setOutilDAO(outilDAO);
        }

        #region Getters & Setters

        /// <summary>
        /// Getter de la variable d'instance <code>this.locationDAO</code>.
        /// </summary>
        /// <returns>La variable d'instance <code>this.locationDAO</code></returns>
        private ILocationDAO getLocationDAO()
        {
            return this.locationDAO;
        }

        /// <summary>
        /// Setter de la variable d'instance <code>this.locationDAO</code>.
        /// </summary>
        /// <param name="locationDAO">La valeur à utiliser pour la variable d'instance <code>this.locationDAO</code></param>
        private void setLocationDAO(ILocationDAO locationDAO)
        {
            this.locationDAO = locationDAO;
        }

        /// <summary>
        /// Getter de la variable d'instance <code>this.clientDAO</code>.
        /// </summary>
        /// <returns>La variable d'instance <code>this.clientDAO</code></returns>
        private IClientDAO getClientDAO()
        {
            return this.clientDAO;
        }

        /// <summary>
        /// Setter de la variable d'instance <code>this.clientDAO</code>.
        /// </summary>
        /// <param name="clientDAO">La valeur à utiliser pour la variable d'instance <code>this.clientDAO</code></param>
        private void setClientDAO(IClientDAO clientDAO)
        {
            this.clientDAO = clientDAO;
        }

        /// <summary>
        /// Getter de la variable d'instance <code>this.employeDAO</code>.
        /// </summary>
        /// <returns>La variable d'instance <code>this.employeDAO</code></returns>
        private IEmployeDAO getEmployeDAO()
        {
            return this.employeDAO;
        }

        /// <summary>
        /// Setter de la variable d'instance <code>this.employeDAO</code>.
        /// </summary>
        /// <param name="employeDAO">La valeur à utiliser pour la variable d'instance <code>this.employeDAO</code></param>
        private void setEmployeDAO(IEmployeDAO employeDAO)
        {
            this.employeDAO = employeDAO;
        }

        /// <summary>
        /// Getter de la variable d'instance <code>this.outilDAO</code>.
        /// </summary>
        /// <returns>La variable d'instance <code>this.outilDAO</code></returns>
        private IOutilDAO getOulilDAO()
        {
            return this.outilDAO;
        }

        /// <summary>
        /// Setter de la variable d'instance <code>this.outilDAO</code>.
        /// </summary>
        /// <param name="outilDAO">La valeur à utiliser pour la variable d'instance <code>this.outilDAO</code></param>
        private void setOutilDAO(IOutilDAO outilDAO)
        {
            this.outilDAO = outilDAO;
        }

        #endregion

        #region CRUD


        /// <inheritdoc />
        public override void add(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationDAO().add(connection, locationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        /// <inheritdoc />
        public override LocationDTO get(Connection connection, String idLocation)
        {
            try
            {
                return (LocationDTO) getLocationDAO().get(connection, idLocation);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        /// <inheritdoc />
        public override void update(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationDAO().update(connection, locationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        /// <inheritdoc />
        public override void delete(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationDAO().delete(connection, locationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        /// <inheritdoc />
        public override List<LocationDTO> getall(Connection connection, String sortByPropertyName)
        {
            try
            {
                return (List<LocationDTO>)getLocationDAO().getAll(connection, sortByPropertyName);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("Il y a eu un erreur : " + daoException);
            }
        }

        #endregion
    }
}
