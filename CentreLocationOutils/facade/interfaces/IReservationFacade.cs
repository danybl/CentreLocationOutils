using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IReservationFacade : IFacade
    {
        public virtual void placerReservation(Connection connection, ReservationDTO reservationDTO);
        public virtual void utiliserReservation(Connection connection, ReservationDTO reservationDTO);
        public virtual void annulerReservation(Connection connection, ReservationDTO reservationDTO);

    }
}
