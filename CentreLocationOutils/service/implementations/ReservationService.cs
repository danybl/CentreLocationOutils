using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.service.interfaces;
using System.Collections.Generic;

namespace CentreLocationOutils.service.implementations
{
    public class ReservationService : Service, IReservationService
    {
        private IReservationDAO reservationDAO;

        public ReservationService(IReservationDAO reservationDAO)
            : base()
        {
            if (reservationDAO == null)
            {
                throw new InvalidDAOException("Le DAO de la réservation ne peut être null");
            }
            setEmployeDAO(reservationDAO);
        }
        /// <summary>
        /// Getter de la variable d'instance reservationDAO
        /// </summary>
        /// <returns>La valeur de la variable d'instance</returns>
        private IReservationDAO getReservationDAO()
        {
            return this.reservationDAO;
        }
        /// <summary>
        /// Setter de la variable d'instance reservationDAO
        /// </summary>
        /// <param name="reservationDAO">Valeur à utiliser pour la variable d'instance</param>
        private void setEmployeDAO(IReservationDAO reservationDAO)
        {
            this.reservationDAO = reservationDAO;
        }
        /// <inheritdoc />
        public override void addReservation(Connection connection,
        ReservationDTO reservationDTO)
        {
            try
            {
                getReservationDAO().add(connection,
                    reservationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }



        /// <inheritdoc />
        public override void updateReservation(Connection connection,
            ReservationDTO reservationDTO)
        {
            try
            {
                getReservationDAO().update(connection,
                    reservationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

        /// <inheritdoc />
        public override void deleteReservation(Connection connection,
            ReservationDTO reservationDTO)
        {
            try
            {
                getReservationDAO().delete(connection,
                    reservationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

        /// <inheritdoc />
        public override List<ReservationDTO> getAllReservation(Connection connection,
            string sortByPropertyName)
        {
            try
            {
                return getReservationDAO().getAll(connection,
                    sortByPropertyName);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException(daoException.Message);
            }
        }

        /// <inheritdoc />
        public override void inscrireReservation(Connection connection, ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                throw new InvalidConnectionException("La connection ne peut être null");
            }
            if (reservationDTO == null)
            {
                throw new InvalidDTOException("La réservation ne peut être null");
            }
            try
            {
                addReservation(connection, reservationDTO);
            }
            catch (DAOException daoException)
            {
                //TODO verify upon testing
                throw new ServiceException(daoException.Message, daoException);
            }
        }

        /// <inheritdoc />
        public override void desinscrireReservation(Connection connection, ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                throw new InvalidConnectionException("La connection ne peut être null");
            }
            if (reservationDTO == null)
            {
                throw new InvalidDTOException("La réservation ne peut être null");
            }
            try
            {
                deleteReservation(connection, reservationDTO);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("", daoException);
            }
        }

        /// <inheritdoc />
        public override List<ReservationDTO> findByClient(Connection connection, ReservationDTO reservationDTO)
        {
            if (connection == null)
            {
                throw new InvalidConnectionException("La connection ne peut être null");
            }
            if (reservationDTO == null)
            {
                throw new InvalidDTOException("La réservation ne peut être null");
            }
            try
            {
                return getReservationDAO().findByClient(connection, reservationDTO.ClientDTO.IdClient, ReservationDTO.ID_CLIENT_COLUMN_NAME);
            }
            catch (DAOException daoException)
            {
                throw new ServiceException("", daoException);
            }
        }
    }
}
