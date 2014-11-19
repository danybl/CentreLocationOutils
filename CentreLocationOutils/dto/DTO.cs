using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace CentreLocationOutils.dto
{
    public class DTO : ISerializable
    {
        protected DTO() : base(){}


        public bool equals(Object obj) {
        bool equals = this == obj;
        if(!equals) {
            equals = obj != null
                && obj is DTO;
        }
        return equals;
    }




    }
}
