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
    public class LocationService : Service, ILocationService
    {
        private ILocationDAO locationDAO;
       

        /// <summary>
        /// Crée le service de la table <code>location</code>.
        /// </summary>
        /// <param name="locationDAO">Le DAO de la table <code>location</code></param>
        public LocationService(ILocationDAO locationDAO) : base()
        {
            if (locationDAO == null)
            {
                throw new InvalidDAOException("Le DAO de location ne peut être null");
            }

            setLocationDAO(locationDAO);
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
