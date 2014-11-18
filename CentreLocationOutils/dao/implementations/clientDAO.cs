using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;


namespace CentreLocationOutils.dao.implementations
{
    public class ClientDAO : CentreLocationOutils.dao.implementations.DAO<dynamic>, CentreLocationOutils.dao.interfaces.IClientDAO
    {

        private static const String ADD_REQUEST = "INSERT INTO Client (idClient, nom, prenom, telephone, email, dateInscription) "
       + "VALUES (?,?,?,?,?,?)";

        private static const String READ_REQUEST = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM client "
            + "WHERE idClient = ?";

        private static const String UPDATE_REQUEST = "UPDATE client "
            + "SET nom = ?, prenom = ?, telephone = ?, email = ? "
            + "WHERE idMembre = ?";

        private static const String DELETE_REQUEST = "DELETE FROM client "
            + "WHERE idClient = ?";

        private static const String GET_ALL_REQUEST = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM client";

        private static const String FIND_BY_NOM = "SELECT idClient, nom, prenom, telephone, email, dateInscription "
            + "FROM membre "
            + "where nom like ?";

        //private static const String FIND_BY_TEL = "SELECT idClient, nom, telephone, limitePret, nbpret"
        //    + " FROM membre"
        //    + " where telephone = ?";

        private static const String CREATE_PRIMARY_KEY = "SELECT SEQ_ID_CLIENT.NEXTVAL from DUAL";

        public ClientDAO(ClientDTO clientDTO) : base(clientDTO) { } 
        
    }
}
