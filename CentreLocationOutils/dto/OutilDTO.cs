﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    public class OutilDTO
    {

        public static const string ID_OUTIL_COLUMN_NAME = "idOutil";

        public static const string ID_CATEGORIE_COLUMN_NAME = "idCategorie";

        public static const string NOM_COLUMN_NAME = "nom";

        public static const string DATEACQUISITION_COLUMN_NAME = "dateAcquisition";

        public string IdOutil { get; set; }
        public string IdCategorie { get; set; }
        public string Nom { get; set; }
        public string NumSerie { get; set; }
        public DateTime DateAcquisition { get; set; }
        public string PrixLocation { get; set; }
        public string Description { get; set; }

    }
}
