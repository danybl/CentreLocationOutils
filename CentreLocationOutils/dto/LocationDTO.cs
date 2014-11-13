using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    class LocationDTO
    {
        public string IdLocation { get; set; }
        public string IdClient { get; set; }
        public string IdEmploye { get; set; }
        public string IdOutils { get; set; }
        public string Depot { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime DateLimite { get; set; }
        public DateTime DateRetour { get; set; }
    }
}
