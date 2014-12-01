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

        public virtual void placerReservation(Connection connection,
        ReservationDTO reservationDTO);

        public virtual void utiliserReservation(Connection connection,
        ReservationDTO reservationDTO);

        public virtual void annulerReservation(Connection connection,
        ReservationDTO reservationDTO);
    }
}
