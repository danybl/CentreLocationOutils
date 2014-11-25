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
        public string NbLocations { get; set; }
        public string LimiteLocations { get; set; }


    //    public bool equals(Object obj) {
    //    bool equals = this == obj;
    //    if(!equals) {
    //        equals = obj != null
    //            && obj is ClientDTO;
    //        if(equals) {
    //            ClientDTO clientDTO = (ClientDTO) obj;
    //            EqualsBuilder equalsBuilder = new EqualsBuilder();
    //            equalsBuilder.appendSuper(base.equals(clientDTO));
    //            equalsBuilder.append(IdClient,
    //                clientDTO.IdClient);
    //            equals = equalsBuilder.isEquals();
    //        }
    //    }
    //    return equals;
    //}
    }
}
