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

namespace CentreLocationOutils.dao.implementations
{
    public class EmployeDAO :IEmployeDAO
    {
        private static const string ADD_REQUEST = "INSERT INTO Employe (idEmploye, nom, prenom, telephone, email, dateRecrutement) "
      + "VALUES (:idEmploye, :nom, :prenom, :telephone, :email, :dateRecrutement)";

        private static const string READ_REQUEST = "SELECT idEmploye, nom, prenom, telephone, email, dateRecrutement "
           + "FROM employe "
           + "WHERE idEmploye = :idEmploye";

        private static const string UPDATE_REQUEST = "UPDATE employe "
            + "SET nom = :nom, prenom = :prenom, telephone = :telephone, email = :email "
            + "WHERE idEmploye = :idEmploye";

        private static const string DELETE_REQUEST = "DELETE FROM employe "
            + "WHERE idEmploye = :idEmploye";

        private static const string GET_ALL_REQUEST = "SELECT idEmploye, nom, prenom, telephone, email, dateRecrutement "
            + "FROM employe";

        private static const string FIND_BY_NOM = "SELECT idEmploye, nom, prenom, telephone, email, dateRecrutement "
            + "FROM employe "
            + "where nom like :nom";

        private static const string CREATE_PRIMARY_KEY = "SELECT SEQ_ID_EMPLOYE.NEXTVAL from DUAL";



        public EmployeDAO(EmployeDTO employeDTOClass) : base(employeDTOClass) { }

        public void add(Connection connection,
        EmployeDTO employeDTO)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (employeDTO == null)
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
                command.CommandText = EmployeDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":nom", employeDTO.Nom));
                command.Parameters.Add(new OracleParameter(":prenom", employeDTO.Prenom));
                command.Parameters.Add(new OracleParameter(":telephone", employeDTO.Telephone));
                command.Parameters.Add(new OracleParameter(":email", employeDTO.Email));
                command.Parameters.Add(new OracleParameter("idClient", employeDTO.IdEmploye));

                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public EmployeDTO get(Connection connection,
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
            EmployeDTO employeDTO = null;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = EmployeDAO.READ_REQUEST;
                command.Parameters.Add(new OracleParameter(":idClient", idClient));

                    DbDataReader dataReader = command.ExecuteReader();
                    if (dataReader.NextResult())
                    {
                        employeDTO = new EmployeDTO();
                        employeDTO.IdEmploye = dataReader.GetString(1);
                        employeDTO.Nom = dataReader.GetString(2);
                        employeDTO.Prenom = dataReader.GetString(3); 
                        employeDTO.Telephone = dataReader.GetString(4);
                        employeDTO.Email = dataReader.GetString(5);
                        employeDTO.DateRecrutement = dataReader.GetDateTime(6);

                    }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return employeDTO;
        }

        public void update(Connection connection,
        EmployeDTO employeDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (employeDTO == null)
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
                command.CommandText = EmployeDAO.UPDATE_REQUEST;
                command.Parameters.Add(new OracleParameter("idClient", employeDTO.IdEmploye));
                command.Parameters.Add(new OracleParameter(":nom", employeDTO.Nom));
                command.Parameters.Add(new OracleParameter(":prenom", employeDTO.Prenom));
                command.Parameters.Add(new OracleParameter(":telephone", employeDTO.Telephone));
                command.Parameters.Add(new OracleParameter(":email", employeDTO.Email));
                command.Parameters.Add(new OracleParameter(":dateInscription", employeDTO.DateRecrutement));
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public void delete(Connection connection,
        EmployeDTO employeDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (employeDTO == null)
            {
                throw new InvalidDTOException("Le DTO ne peut être null");
            }
            //if (!dto.GetType().Equals(getDtoClass()))
            //{
            //    throw new InvalidDTOClassException("Le DTO doit être un "
            //        + getDtoClass().getName());
            //}
           // EmployeDTO employeDTO = (EmployeDTO)dto;

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = EmployeDAO.DELETE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idClient", employeDTO.IdEmploye));

            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        
        public List<EmployeDTO> getAll(Connection connection,
        string sortByPropertyName)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (sortByPropertyName == null)
            {
                throw new InvalidSortByPropertyException("La propriété utilisée pour classer ne peut être null");
            }
            List<EmployeDTO> clients = new List<EmployeDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = EmployeDAO.GET_ALL_REQUEST;

                DbDataReader dataReader = command.ExecuteReader();
                EmployeDTO employeDTO= null;

                if (dataReader.NextResult())
                {
                    employeDTO = new EmployeDTO();
                    do{
                        employeDTO.IdEmploye = dataReader.GetString(1);
                        employeDTO.Nom = dataReader.GetString(2);
                        employeDTO.Prenom = dataReader.GetString(3);
                        employeDTO.Telephone = dataReader.GetString(4);
                        employeDTO.Email = dataReader.GetString(5);
                        employeDTO.DateRecrutement = dataReader.GetDateTime(6);
                        clients.Add(employeDTO);
                    }
                        while(dataReader.NextResult());
                    }
                }catch(DbException dbException){
                    throw new DAOException(dbException);
                }
            return clients;
        }


        public List<EmployeDTO> findByNom(Connection connection, string nom,
        string sortByPropertyName)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (nom == null)
            {
                throw new InvalidCriterionException("Le nom ne peut être null");
            }
            if (sortByPropertyName == null)
            {
                throw new InvalidSortByPropertyException("La propriété utilisée pour classer ne peut être null");
            }
            List<EmployeDTO> clients = new List<EmployeDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = EmployeDAO.FIND_BY_NOM;

                DbDataReader dataReader = command.ExecuteReader();
                EmployeDTO employeDTO = null;

                if (dataReader.NextResult())
                {
                    employeDTO = new EmployeDTO();
                    do
                    {
                        employeDTO.IdEmploye = dataReader.GetString(1);
                        employeDTO.Nom = dataReader.GetString(2);
                        employeDTO.Prenom = dataReader.GetString(3);
                        employeDTO.Telephone = dataReader.GetString(4);
                        employeDTO.Email = dataReader.GetString(5);
                        employeDTO.DateRecrutement = dataReader.GetDateTime(6);
                        clients.Add(employeDTO);
                    }
                    while (dataReader.NextResult());
                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return clients;
        }

    }
}
