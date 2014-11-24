using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    public class ReservationDTO
    {
        public string IdReservation { get; set; }
        public string IdClient { get; set; }
        public string IdOutil { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateLimite { get; set; }
    }
}
