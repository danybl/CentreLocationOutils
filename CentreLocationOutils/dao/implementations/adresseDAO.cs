using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.dao.implementations;
using System.Data;
using CentreLocationOutils.dto;
using System.Data.Common;
using System.Data.OracleClient;
using System.Runtime.Serialization;
using CentreLocationOutils.dao.interfaces;

namespace CentreLocationOutils.dao.implementations
{
    public class AdresseDAO : DAO, IAdresseDAO
    {

        private static const String CREATE_PRIMARY_KEY = "SELECT SEQ_ADRESSE_ID.NEXTVAL "
        + "FROM DUAL";

        private static const String ADD_REQUEST = "INSERT INTO adresse (idAdresse, numero, rue, appartement, codePostal, ville, province, pays) "
            + "VALUES (:idAdresse, :numero, :rue, :appartement, :codePostal, :ville, :province, :pays";

        private static const String READ_REQUEST = "SELECT idAdresse, numero, rue, appartement, codePostal, ville, province, pays "
            + "FROM adresse "
            + "WHERE idAdresse = :idAdresse";

        private static const String UPDATE_REQUEST = "UPDATE adresse "
            + "SET numero = :numero, rue = :rue, appartement = :appartement, codePostal = :codePostal, ville = :ville, province = :province, pays = :pays "
            + "WHERE idAdresse = :idAdresse";

        private static const String DELETE_REQUEST = "DELETE FROM adresse "
            + "WHERE idAdresse = :idAdresse";

        private static const String GET_ALL_REQUEST = "SELECT idAdresse, numero, rue, appartement, codePostal, ville, province, pays "
            + "FROM adresse";

        /// <summary>
        /// Crée le DAO de la table adresse
        /// </summary>
        /// <param name="reservationDTOClass">La classe de réservationDTO à utiliser</param>
        public AdresseDAO(AdresseDTO adresseDTOClass) : base(adresseDTOClass) { }

        /// <inheritdoc />
        private static String getPrimaryKey(Connection connection)
        {
            return DAO.getPrimaryKey(connection,
                AdresseDAO.CREATE_PRIMARY_KEY);
        }

        /// <inheritdoc />
        public override void add(Connection connection, AdresseDTO adresseDTO)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (adresseDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //EmployeDTO employeDTO = employeDTO;//(EmployeDTO) dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = AdresseDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":idAdresse", adresseDTO.IdAdresse));
                command.Parameters.Add(new OracleParameter(":numero", adresseDTO.Numero));
                command.Parameters.Add(new OracleParameter(":rue", adresseDTO.Rue));
                command.Parameters.Add(new OracleParameter(":appartement", adresseDTO.Appartement));
                command.Parameters.Add(new OracleParameter(":codePostal", adresseDTO.CodePostal));
                command.Parameters.Add(new OracleParameter(":ville", adresseDTO.Ville));
                command.Parameters.Add(new OracleParameter(":province", adresseDTO.Province));
                command.Parameters.Add(new OracleParameter(":pays", adresseDTO.Pays));

                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }


        /// <inheritdoc />
        public override AdresseDTO get(Connection connection, ISerializable primaryKey)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (primaryKey == null)
            {
                throw new InvalidPrimaryKeyException("La clef primaire ne peut être null");
            }
            string idReservation = primaryKey.ToString();
            AdresseDTO adresseDTO = null;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = AdresseDAO.READ_REQUEST;
                command.Parameters.Add(new OracleParameter(":idReservation", idReservation));

                DbDataReader dataReader = command.ExecuteReader();
                if (dataReader.NextResult())
                {
                    adresseDTO = new AdresseDTO();
                    adresseDTO.IdAdresse = dataReader.GetString(1);
                    adresseDTO.Numero = dataReader.GetString(2);
                    adresseDTO.Rue = dataReader.GetString(3);
                    adresseDTO.Appartement = dataReader.GetString(4);
                    adresseDTO.CodePostal = dataReader.GetString(5);
                    adresseDTO.Ville = dataReader.GetString(6);
                    adresseDTO.Province = dataReader.GetString(7);
                    adresseDTO.Pays = dataReader.GetString(8);

                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return adresseDTO;
        }

        /// <inheritdoc />
        public override void update(Connection connection, AdresseDTO adresseDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (adresseDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //EmployeDTO employeDTO = (EmployeDTO)dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = AdresseDAO.UPDATE_REQUEST;
                command.Parameters.Add(new OracleParameter(":numero", adresseDTO.Numero));
                command.Parameters.Add(new OracleParameter(":rue", adresseDTO.Rue));
                command.Parameters.Add(new OracleParameter(":appartement", adresseDTO.Appartement));
                command.Parameters.Add(new OracleParameter(":codePostal", adresseDTO.CodePostal));
                command.Parameters.Add(new OracleParameter(":ville", adresseDTO.Ville));
                command.Parameters.Add(new OracleParameter(":province", adresseDTO.Province));
                command.Parameters.Add(new OracleParameter(":pays", adresseDTO.Pays));

                command.Parameters.Add(new OracleParameter(":idAdresse", adresseDTO.IdAdresse));

                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        /// <inheritdoc />
        public override void delete(Connection connexion, DTO dto)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public List<AdresseDTO> getAll(Connection connection, string sortByPropertyName)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (sortByPropertyName == null)
            {
                throw new InvalidSortByPropertyException("La propriété utilisée pour classer ne peut être null");
            }
            List<AdresseDTO> adresses = new List<AdresseDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = AdresseDAO.GET_ALL_REQUEST;

                DbDataReader dataReader = command.ExecuteReader();
                AdresseDTO adresseDTO= null;

                if (dataReader.NextResult())
                {
                    adresseDTO = new AdresseDTO();
                    do
                    {
                        adresseDTO = new AdresseDTO();
                    adresseDTO.IdAdresse = dataReader.GetString(1);
                    adresseDTO.Numero = dataReader.GetString(2);
                    adresseDTO.Rue = dataReader.GetString(3);
                    adresseDTO.Appartement = dataReader.GetString(4);
                    adresseDTO.CodePostal = dataReader.GetString(5);
                    adresseDTO.Ville = dataReader.GetString(6);
                    adresseDTO.Province = dataReader.GetString(7);
                    adresseDTO.Pays = dataReader.GetString(8);

                        adresses.Add(adresseDTO);
                    }
                    while (dataReader.NextResult());
                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return adresses;
        }
        
    }
}
