using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dto
{
    public class ReservationDTO
    {
        public string IdReservation { get; set; }
        public ClientDTO ClientDTO { get; set; }
        public OutilDTO OutilDTO { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateLimite { get; set; }
    }
}
