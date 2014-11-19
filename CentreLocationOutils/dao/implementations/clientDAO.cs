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
    public class ClientDAO : CentreLocationOutils.dao.implementations.DAO<dynamic>, CentreLocationOutils.dao.interfaces.IClientDAO
    {

        private static const String ADD_REQUEST = "INSERT INTO Client (idClient, nom, prenom, telephone, email, dateInscription) "
       + "VALUES (:idClient, :nom, :prenom, :telephone, :email, :dateInscription)";

        private static const String READ_REQUEST = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM client "
            + "WHERE idClient = :chosenIdClient";

        private static const String UPDATE_REQUEST = "UPDATE client "
            + "SET nom = :nom, prenom = :prenom, telephone = :telephone, email = :email "
            + "WHERE idMembre = :idClient";

        private static const String DELETE_REQUEST = "DELETE FROM client "
            + "WHERE idClient = :idClient";

        private static const String GET_ALL_REQUEST = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM client";

        private static const String FIND_BY_NOM = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM membre "
            + "where nom like :nom";

        //private static const String FIND_BY_TEL = "SELECT idClient, nom, telephone, limitePret, nbpret"
        //    + " FROM membre"
        //    + " where telephone = ?";

        private static const String CREATE_PRIMARY_KEY = "SELECT SEQ_ID_CLIENT.NEXTVAL from DUAL";

        public ClientDAO(ClientDTO clientDTOClass) : base(clientDTOClass) { }

        public void add(Connection connection,
        ClientDTO clientDTO)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (clientDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //ClientDTO clientDTO = clientDTO;//(ClientDTO) dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ClientDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":nom", clientDTO.Nom));
                command.Parameters.Add(new OracleParameter(":prenom", clientDTO.Prenom));
                command.Parameters.Add(new OracleParameter(":telephone", clientDTO.Telephone));
                command.Parameters.Add(new OracleParameter(":email", clientDTO.Email));
                command.Parameters.Add(new OracleParameter("idClient", clientDTO.IdClient));

                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public ClientDTO get(Connection connection,
        ISerializable primaryKey)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (primaryKey == null)
            {
                throw new InvalidPrimaryKeyException("La clef primaire ne peut être null");
            }
            string idClient = primaryKey.ToString();
            ClientDTO clientDTO = null;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ClientDAO.READ_REQUEST;
                command.Parameters.Add(new OracleParameter(":idClient", idClient));

                    DbDataReader dataReader = command.ExecuteReader();
                    if (dataReader.NextResult())
                    {
                        clientDTO = new ClientDTO();
                        clientDTO.IdClient = dataReader.GetString(1);
                        clientDTO.Nom = dataReader.GetString(2);
                        clientDTO.Prenom = dataReader.GetString(3); 
                        clientDTO.Telephone = dataReader.GetString(4);
                        clientDTO.Email = dataReader.GetString(5);
                        clientDTO.DateInscription = dataReader.GetDateTime(6);

                    }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return clientDTO;
        }

        public void update(Connection connection,
        ClientDTO clientDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (clientDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
            //ClientDTO clientDTO = (ClientDTO)dto;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ClientDAO.UPDATE_REQUEST;
                command.Parameters.Add(new OracleParameter("idClient", clientDTO.IdClient));
                command.Parameters.Add(new OracleParameter(":nom", clientDTO.Nom));
                command.Parameters.Add(new OracleParameter(":prenom", clientDTO.Prenom));
                command.Parameters.Add(new OracleParameter(":telephone", clientDTO.Telephone));
                command.Parameters.Add(new OracleParameter(":email", clientDTO.Email));
                command.Parameters.Add(new OracleParameter(":dateInscription", clientDTO.DateInscription));
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public void delete(Connection connection,
        ClientDTO clientDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (clientDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
           // ClientDTO clientDTO = (ClientDTO)dto;

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ClientDAO.DELETE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idClient", clientDTO.IdClient));

            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        
        public List<ClientDTO> getAll(Connection connection,
        String sortByPropertyName)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (sortByPropertyName == null)
            {
                throw new InvalidSortByPropertyException("La propriété utilisée pour classer ne peut être null");
            }
            List<ClientDTO> clients = new List<ClientDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ClientDAO.GET_ALL_REQUEST;

                DbDataReader dataReader = command.ExecuteReader();
                ClientDTO clientDTO= null;

                if (dataReader.NextResult())
                {
                    clientDTO = new ClientDTO();
                    do{
                        clientDTO.IdClient = dataReader.GetString(1);
                        clientDTO.Nom = dataReader.GetString(2);
                        clientDTO.Prenom = dataReader.GetString(3);
                        clientDTO.Telephone = dataReader.GetString(4);
                        clientDTO.Email = dataReader.GetString(5);
                        clientDTO.DateInscription = dataReader.GetDateTime(6);
                    }
                        while(dataReader.NextResult());
                    }
                }catch(DbException dbException){
                    throw new DAOException(dbException);
                }
            return clients;
        }










    }
}
