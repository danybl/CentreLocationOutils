using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLcationOutils_front_end.util;
using System.IO;

namespace CentreLcationOutils_front_end
{
    public class CentreLocationOutilsTesting
    {
        
        private static CentreLocationOutilsCreateur gestionCentreOutils;

        public CentreLocationOutilsTesting() : base() {
            startReading();
        
        }

        public void startReading(){
            StringReader streamReader = (StringReader) Console.In;
            
            gestionCentreOutils = new CentreLocationOutilsCreateur("local", "location", "tiger");

        }
    }
    }
}
