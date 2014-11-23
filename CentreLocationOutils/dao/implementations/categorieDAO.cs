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
    public class CategorieDAO : DAO, ICategorieDAO
    {
        private static const string ADD_REQUEST = "INSERT INTO outil (idCategorie, nom, description) "
      + "VALUES (:idOutil, :idCategorie, :nom, :numSerie, :dateAqcuisition, :prixLocation, :description)";

        private static const string READ_REQUEST = "SELECT idOutil, idCategorie ,nom, numSerie, dateAqcuisition, prixLocation, description "
           + "FROM outil "
           + "WHERE idOutil = :idOutil";

        private static const string UPDATE_REQUEST = "UPDATE outil "
            + "SET idCategorie = :idCategorie, nom = :nom, numSerie = :numSerie, dateAcquisition = :dateAcquisition, prixLocation = :prixLocation, description = :description "
            + "WHERE idOutil = :idOutil";

        private static const string DELETE_REQUEST = "DELETE FROM outil "
            + "WHERE idOutil = :idOutil";

        private static const string GET_ALL_REQUEST = "SELECT idOutil, idCategorie ,nom, numSerie, dateAqcuisition, prixLocation, description "
            + "FROM outil";

        private static const string FIND_BY_NOM = "SELECT idOutil, idCategorie ,nom, numSerie, dateAqcuisition, prixLocation, description "
            + "FROM outil "
            + "where nom like :nom";

        private static const string CREATE_PRIMARY_KEY = "SELECT SEQ_ID_OUTIL.NEXTVAL from DUAL";
    }
}
