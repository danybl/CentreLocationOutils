using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;


namespace CentreLocationOutils.service.interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IReservationService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="reservationDTO"></param>
        public virtual void add(Connection connection,
        ReservationDTO reservationDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public virtual ReservationDTO get(Connection connection,
        string primaryKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="reservationDTO"></param>
        public virtual void update(Connection connection,
        ReservationDTO reservationDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="reservationDTO"></param>
        public virtual void delete(Connection connection,
        ReservationDTO reservationDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public virtual List<ReservationDTO> getAll(Connection connection,
        string sortByPropertyName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="nom"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public virtual List<ReservationDTO> findByClient(Connection connection, ClientDTO clientDTO,
        string sortByPropertyName);
    }
}
