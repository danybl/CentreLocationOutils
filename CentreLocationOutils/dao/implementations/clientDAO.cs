using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception;
using CentreLocationOutils.dao.implementations;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;

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

        public ClientDAO(ClientDTO clientDTO) : base(clientDTO) { } 

        public void add(Connection connection,
        DTO dto) {
        if(connection == null) {
           // throw new InvalidHibernateSessionException("La connexion ne peut être null");
        }
        if(dto == null) {
            throw new InvalidDTOException("Le DTO ne peut être null");
        }
        //if(!dto.getClass().equals(getDtoClass())) {
        //    throw new InvalidDTOClassException("Le DTO doit être un "
        //        + getDtoClass().getName());
        //}
        ClientDTO clientDTO = (ClientDTO) dto;
        try{
            DbCommand command= connection.getConnection().CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = ClientDAO.ADD_REQUEST;
            command.Parameters.Add(new OracleParameter("idClient", clientDTO.IdClient));
            command.Parameters.Add(new OracleParameter("nom", clientDTO.Nom));
        }catch(){

        }
        
    }
}
