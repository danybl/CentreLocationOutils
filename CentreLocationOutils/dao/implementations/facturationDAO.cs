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
    public class FacturationDAO : CentreLocationOutils.dao.implementations.DAO, CentreLocationOutils.dao.interfaces.IFacturationDAO
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

        private static const string CREATE_PRIMARY_KEY = "SELECT SEQ_ID_FACTURATION.NEXTVAL from DUAL";

         /// <summary>
        /// Crée le DAO de la table Facturation <code>facturation</code>
        /// </summary>
        /// <param name="facturationDTOClass">La classe de membre DTO à utiliser</param>
        public FacturationDAO(FacturationDTO facturationDTOClass) : base(facturationDTOClass) { }

        /// <summary>
        /// Crée une nouvelle clef primaire pour la table <code>facturation</code>.
        /// </summary>
        /// <param name="connexion">La connexion à utiliser</param>
        /// <returns>La nouvelle clef primaire</returns>

        private static String getPrimaryKey(Connection connection)
        {
            return DAO.getPrimaryKey(connection,
                FacturationDAO.CREATE_PRIMARY_KEY);
        }
    }

}
