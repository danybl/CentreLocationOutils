using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    public class AdresseDTO : DTO
    {

        public static const string ID_ADRESSE_COLUMN_NAME = "idAdresse";

        public static const string VILLE_COLUMN_NAME = "ville";

        public static const string PROVINCE_COLUMN_NAME = "province";

        public static const string PAYS_COLUMN_NAME = "pays";

        public string IdAdresse { get; set; }
        public string Numero { get; set; }
        public string Rue { get; set; }
        public string Appartement { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Province { get; set; }
        public string Pays { get; set; }

    }
}
