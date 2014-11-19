﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.dto
{
    public class ClientDTO : DTO
    {

        public ClientDTO() : base() { }

        public string IdClient {get;set;}
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone{get;set;}
        public string Email { get; set; }
        public DateTime DateInscription { get; set; }
    }
}
