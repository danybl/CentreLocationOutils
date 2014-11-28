using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dto
{
    public class EmployeDTO : DTO
    {
        public static const string ID_EMPLOYE_COLUMN_NAME = "idEmploye";

        public static const string NOM_COLUMN_NAME = "nom";

        public static const string DATE_RECRUTEMENT_COLUMN_NAME = "dateRecrutement";

        public string IdEmploye{get;set;}
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone{get;set;}
        public string Email { get; set; }
        public DateTime DateRecrutement { get; set; }
        public string Poste { get; set; }
    }
}
