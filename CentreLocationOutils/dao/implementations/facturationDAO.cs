using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.dto;
using System;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;

namespace CentreLocationOutils.dao.implementations
{
    public class FacturationDAO : DAO, IFacturationDAO
    {

        private static const string ADD_REQUEST = "INSERT INTO Facturation (idFacturation, idemploye, idlocation, couttotal) "
       + "VALUES (:idFacturation, :idemploye, :idlocation, :couttotal)";

        private static const string READ_REQUEST = "SELECT idFacturation, idemploye, idlocation, couttotal "
            + "FROM facturation "
            + "WHERE idFacturation = :idFacturation";

        private static const string UPDATE_REQUEST = "UPDATE facturation "
            + "SET idemploye = :idemploye, idlocation = :idlocation, couttotal = :couttotal "
            + "WHERE idFacturation = :idFacturation";

        private static const string DELETE_REQUEST = "DELETE FROM facturation "
            + "WHERE idFacturation = :idFacturation";

        private static const string GET_ALL_REQUEST = "SELECT idFacturation, idemploye, idlocation, couttotal "
            + "FROM facturation";

        private static const string CREATE_PRIMARY_KEY = "SELECT SEQ_FACTURATION_ID.NEXTVAL from DUAL";

        /// <summary>
        /// Crée le DAO de la table Facturation <code>facturation</code>
        /// </summary>
        /// <param name="facturationDTOClass">La classe de facturation DTO à utiliser</param>
        public FacturationDAO(FacturationDTO facturationDTOClass) : base(facturationDTOClass) { }

        /// <inheritdoc />
        private static String getPrimaryKey(Connection connection)
        {
            return DAO.getPrimaryKey(connection,
                FacturationDAO.CREATE_PRIMARY_KEY);
        }

        public void add(Connection connection,
        FacturationDTO facturationDTO)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (facturationDTO == null)
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
                command.CommandText = FacturationDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":idFacturation", facturationDTO.IdFacturation));


                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

    }
}
