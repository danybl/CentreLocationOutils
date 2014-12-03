using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.dao.implementations;
using CentreLocationOutils.dto;

namespace CentreLcationOutils_front_end.util
{
    public class CentreLocationOutilsCreateur
    {
        public Connection Connection { get; private set; }
        public IClientFacade ClientFacade { get; private set; }
        public IEmployeFacade EmployeFacade { get; private set; }
        public IReservationFacade ReservationFacade { get; private set; }
        public ILocationFacade LocationFacade { get; private set; }
        public IOutilFacade OutilFacade { get; private set; }
        public IAdresseFacade AdresseFacade { get; private set; }
        public IFacturationFacade FacturationFacade { get; private set; }

        public CentreLocationOutilsCreateur()
        {
            try
            {
               // IClientDAO clientDAO = new ClientDAO();
            }
        }
    }
}
