﻿using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CentreLocationOutils.dao.implementations
{
    public class ReservationDAO : DAO, IReservationDAO
    {
        private static const String CREATE_PRIMARY_KEY = "SELECT SEQ_ID_RESERVATION.NEXTVAL "
        + "FROM DUAL";

        private static const String ADD_REQUEST = "INSERT INTO reservation (idReservation, idClient, idOutil, dateReservation, dateLimite) "
            + "VALUES (:idReservation, :idClient, :idOutil, :dateReservation, :dateLimite";

        private static const String READ_REQUEST = "SELECT idReservation, idClient, idOutil, dateReservation, dateLimite "
            + "FROM reservation "
            + "WHERE idReservation = :idReservation";

        //TODO vérifier si changement possible pour idClient
        private static const String UPDATE_REQUEST = "UPDATE reservation "
            + "SET idClient = :idClient, idOutil = :idOutil, dateReservation = :dateReservation, dateLimite = :dateLimite  "
            + "WHERE idReservation = :idReservation";

        private static const String DELETE_REQUEST = "DELETE FROM reservation "
            + "WHERE idReservation = ?";

        private static const String GET_ALL_REQUEST = "SELECT idReservation, idMembre, idLivre, dateReservation "
            + "FROM reservation";

        private static const String FIND_BY_MEMBRE_REQUEST = "SELECT idReservation, idMembre, idLivre, dateReservation "
            + "FROM reservation "
            + "WHERE idMembre = ?";

        private static const String FIND_BY_LIVRE_REQUEST = "SELECT idReservation, idMembre, idLivre, dateReservation "
            + "FROM reservation "
            + "WHERE idLivre = ? "
            + "ORDER BY dateReservation ASC";

        public ReservationDAO(ReservationDTO reservationDTOClass) : base(reservationDTOClass) { }

        public void add(Connection connection,
        ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                // throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (reservationDTO == null)
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
                command.CommandText = ReservationDAO.ADD_REQUEST;
                command.Parameters.Add(new OracleParameter(":idReservation", reservationDTO.IdReservation));
                command.Parameters.Add(new OracleParameter(":idClient", reservationDTO.IdClient));
                command.Parameters.Add(new OracleParameter(":idOutil", reservationDTO.IdOutil));
                command.Parameters.Add(new OracleParameter(":dateReservation", reservationDTO.DateReservation));
                command.Parameters.Add(new OracleParameter(":dateLimite", reservationDTO.DateLimite));


                command.ExecuteNonQuery();
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public ReservationDTO get(Connection connection,
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
            string idReservation = primaryKey.ToString();
            ReservationDTO reservationDTO = null;
            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ReservationDAO.READ_REQUEST;
                command.Parameters.Add(new OracleParameter(":idReservation", idReservation));

                DbDataReader dataReader = command.ExecuteReader();
                if (dataReader.NextResult())
                {
                    reservationDTO = new ReservationDTO();
                    reservationDTO.IdReservation = dataReader.GetString(1);
                    reservationDTO.IdClient = dataReader.GetString(2);
                    reservationDTO.IdOutil = dataReader.GetString(3);
                    reservationDTO.DateReservation = dataReader.GetDateTime(4);
                    reservationDTO.DateLimite = dataReader.GetDateTime(5);

                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return reservationDTO;
        }

        public void update(Connection connection,
        ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (reservationDTO == null)
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
                command.CommandText = ReservationDAO.UPDATE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idClient", reservationDTO.IdClient));
                command.Parameters.Add(new OracleParameter(":idOutil", reservationDTO.IdOutil));
                command.Parameters.Add(new OracleParameter(":dateReservation", reservationDTO.DateReservation));
                command.Parameters.Add(new OracleParameter(":dateLimite", reservationDTO.DateLimite));
                command.Parameters.Add(new OracleParameter(":idReservation", reservationDTO.IdReservation));
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public void delete(Connection connection,
        ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                //throw new InvalidHibernateSessionException("La connexion ne peut être null");
            }
            if (reservationDTO == null)
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
                command.CommandText = ReservationDAO.DELETE_REQUEST;
                command.Parameters.Add(new OracleParameter(":idReservation", reservationDTO.IdReservation));

            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
        }

        public List<ReservationDTO> getAll(Connection connection,
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
            List<ReservationDTO> reservations = new List<ReservationDTO>();

            try
            {
                DbCommand command = connection.getConnection().CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = ReservationDAO.GET_ALL_REQUEST;

                DbDataReader dataReader = command.ExecuteReader();
                ReservationDTO reservationDTO = null;

                if (dataReader.NextResult())
                {
                    reservationDTO = new ReservationDTO();
                    do
                    {
                        reservationDTO.IdReservation = dataReader.GetString(1);
                        reservationDTO.IdClient = dataReader.GetString(2);
                        reservationDTO.IdOutil = dataReader.GetString(3);
                        reservationDTO.DateReservation = dataReader.GetDateTime(4);
                        reservationDTO.DateLimite = dataReader.GetDateTime(5);

                        reservations.Add(reservationDTO);
                    }
                    while (dataReader.NextResult());
                }
            }
            catch (DbException dbException)
            {
                throw new DAOException(dbException);
            }
            return reservations;
        }

    }
}
