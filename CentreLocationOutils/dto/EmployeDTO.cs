using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils
{
    class EmployeDTO
    {
        public string IdEmploye{get;set;}
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone{get;set;}
        public string Email { get; set; }
        public DateTime DateRecrutement { get; set; }
        public string Poste { get; set; }
    }
}
