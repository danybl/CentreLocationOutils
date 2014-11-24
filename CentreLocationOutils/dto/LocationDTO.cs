using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    public class LocationDTO
    {
        public string IdLocation { get; set; }
        public ClientDTO ClientDTO { get; set; }
        public EmployeDTO EmployeDTO { get; set; }
        public OutilDTO OutilDTO { get; set; }
        public string Depot { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime DateLimite { get; set; }
        public DateTime DateRetour { get; set; }
    }
}
