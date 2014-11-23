using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.dao.implementations;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Runtime.Serialization;

namespace CentreLocationOutils.dao.implementations
{
    public class LocationDAO : CentreLocationOutils.dao.implementations.DAO, CentreLocationOutils.dao.interfaces.ILocationDAO
    {
        #region THE QUERIES

        private static const string ADD_REQUEST = "INSERT INTO location (idlocation, idclient, idemploye, idoutil, depot, datelocation, datelimite, dateretour) "
                                                + "VALUES (:idlocation, :idclient, :idemploye, :idoutil, :depot, :datelocation, :datelimite, :dateretour)";

        private static const string READ_REQUEST = "SELECT idlocation, idclient, idemploye, idoutil, depot, datelocation, datelimite, dateretour "
                                                 + "FROM location "
                                                 + "WHERE idlocation = :idlocation";

        private static const string UPDATE_REQUEST = "UPDATE location "
                                                   + "SET idclient = :idclient, idemploye = :idemploye, idoutil = :idoutil, depot = :depot, datelocation = :datelocation, datelimite = :datelimite, dateretour = :dateretour "
                                                   + "WHERE idlocation = :idlocation";

        private static const string DELETE_REQUEST = "DELETE FROM location "
                                                   + "WHERE idlocation = :idlocation";

        private static const string GET_ALL_REQUEST = "SELECT idlocation, idclient, idemploye, idoutil, depot, datelocation, datelimite, dateretour "
                                                    + "FROM location";


        private static const string CREATE_PRIMARY_KEY = "SELECT SEQ_ID_LOCATION.NEXTVAL from DUAL";

        #endregion

        /// <summary>
        /// Crée le DAO de la table Location <code>location</code>
        /// </summary>
        /// <param name="locationDTOClass">La classe de membre DTO à utiliser</param>
        public LocationDAO(LocationDTO locationDTOClass) : base(locationDTOClass) { }

        /// <summary>
        /// Crée une nouvelle clef primaire pour la table <code>location</code>.
        /// </summary>
        /// <param name="connexion">La connexion à utiliser</param>
        /// <returns>La nouvelle clef primaire</returns>

        private static String getPrimaryKey(Connection connection)
        {
            return DAO.getPrimaryKey(connection,
                LocationDAO.CREATE_PRIMARY_KEY);
        }

        #region CRUD
        /// <inheritdoc />
        public void add(Connection connection,
        LocationDTO locationDTO)
        {
            if (connection == null)
            {
                throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (locationDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //LocationDTO locationDTO = (LocationDTO)dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = LocationDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":idlocation", locationDTO.IdLocation));
                command.Parameters.Add(new OracleParameter(":idclient", locationDTO.IdClient));
                command.Parameters.Add(new OracleParameter(":idemploye", locationDTO.IdEmploye));
                command.Parameters.Add(new OracleParameter(":idoutil", locationDTO.IdOutils));
                command.Parameters.Add(new OracleParameter("depot", locationDTO.Depot));
                command.Parameters.Add(new OracleParameter("datelocation", locationDTO.DateLocation));
                command.Parameters.Add(new OracleParameter("datelimite", locationDTO.DateLimite));
                command.Parameters.Add(new OracleParameter("dateretour", locationDTO.DateRetour));

                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        /// <inheritdoc />
        public LocationDTO get(Connection connection,
        ISerializable primaryKey)
        {
            if (connection == null)
            {
                throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (primaryKey == null)
            {
                throw new InvalidPrimaryKeyException("La clef primaire ne peut être null");
            }
            string idLocation = primaryKey.ToString();
            LocationDTO locationDTO = null;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = LocationDAO.READ_REQUEST;
                command.Parameters.Add(new OracleParameter(":idlocation", idLocation));

                DbDataReader dataReader = command.ExecuteReader();
                if (dataReader.NextResult())
                {
                    locationDTO = new LocationDTO();
                    locationDTO.IdLocation = dataReader.GetString(1);
                    locationDTO.IdClient = dataReader.GetString(2);
                    locationDTO.IdEmploye = dataReader.GetString(3);
                    locationDTO.IdOutils = dataReader.GetString(4);
                    locationDTO.Depot = dataReader.GetString(5);
                    locationDTO.DateLocation = dataReader.GetDateTime(6);
                    locationDTO.DateLimite = dataReader.GetDateTime(7);
                    locationDTO.DateRetour = dataReader.GetDateTime(8);

                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return locationDTO;
        }

        /// <inheritdoc />
        public void update(Connection connection,
         LocationDTO locationDTO)
        {
            if (connection == null)
            {
                throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (locationDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //LocationDTO locationDTO = (LocationDTO)dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = LocationDAO.UPDATE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idlocation", locationDTO.IdLocation));
                command.Parameters.Add(new OracleParameter(":idclient", locationDTO.IdClient));
                command.Parameters.Add(new OracleParameter(":idemploye", locationDTO.IdEmploye));
                command.Parameters.Add(new OracleParameter(":idoutil", locationDTO.IdOutils));
                command.Parameters.Add(new OracleParameter("depot", locationDTO.Depot));
                command.Parameters.Add(new OracleParameter("datelocation", locationDTO.DateLocation));
                command.Parameters.Add(new OracleParameter("datelimite", locationDTO.DateLimite));
                command.Parameters.Add(new OracleParameter("dateretour", locationDTO.DateRetour));
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        /// <inheritdoc />
        public void delete(Connection connection,
        LocationDTO locationDTO)
        {
            if (connection == null)
            {
                throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (locationDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            // LocationDTO locationDTO = (LocationDTO)dto;

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = LocationDAO.DELETE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idlocation", locationDTO.IdLocation));

            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }
        #endregion

        /// <inheritdoc />
        public List<LocationDTO> getAll(Connection connection,
        string sortByPropertyName)
        {
            if (connection == null)
            {
                throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (sortByPropertyName == null)
            {
                throw new InvalidSortByPropertyException("La propriété utilisée pour classer ne peut être null");
            }

            List<LocationDTO> locations = new List<LocationDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = LocationDAO.GET_ALL_REQUEST;

                DbDataReader dataReader = command.ExecuteReader();
                LocationDTO locationDTO = null;

                if (dataReader.NextResult())
                {
                    locationDTO = new LocationDTO();
                    do
                    {
                        locationDTO.IdLocation= dataReader.GetString(1);
                        locationDTO.IdClient = dataReader.GetString(2);
                        locationDTO.IdEmploye = dataReader.GetString(3);
                        locationDTO.IdOutils = dataReader.GetString(4);
                        locationDTO.Depot = dataReader.GetString(5);
                        locationDTO.DateLocation = dataReader.GetDateTime(6);
                        locationDTO.DateLimite = dataReader.GetDateTime(7);
                        locationDTO.DateRetour = dataReader.GetDateTime(8);
                        locations.Add(locationDTO);
                    }
                    while (dataReader.NextResult());
                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return locations;
        }
    }
}
