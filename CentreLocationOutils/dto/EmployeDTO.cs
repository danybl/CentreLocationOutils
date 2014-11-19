using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dto
{
    public class ClientDTO : DTO
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
