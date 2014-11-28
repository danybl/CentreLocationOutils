﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dto
{
    public class ReservationDTO
    {

        public static const string ID_RESERVATION_COLUMN_NAME = "idReservation";

        public static const string ID_CLIENT_COLUMN_NAME = "idClient";

        public static const string ID_EMPLOYE_COLUMN_NAME = "idEmploye";

        public static const string ID_OUTIL_COLUMN_NAME = "idOutil";

        public static const string DATELIMITE_COLUMN_NAME = "dateLimite";

        public string IdReservation { get; set; }
        public ClientDTO ClientDTO { get; set; }
        public OutilDTO OutilDTO { get; set; }
        public DateTime DateReservation { get; set; }
        public DateTime DateLimite { get; set; }
    }
}
