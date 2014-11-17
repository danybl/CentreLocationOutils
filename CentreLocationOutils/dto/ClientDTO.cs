using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils
{
    public class ClientDTO : CentreLocationOutils.dto.DTO
    {
        public string IdClient{get;set;}
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone{get;set;}
        public string Email { get; set; }
        public DateTime DateInscription { get; set; }
    }
}
