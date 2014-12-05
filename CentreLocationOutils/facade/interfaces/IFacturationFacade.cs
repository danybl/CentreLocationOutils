using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IFacturationFacade : IFacade
    {
        public virtual List<FacturationDTO> findByClient(Connection connection, string idClient, string sortByPropertyName);

        public virtual List<FacturationDTO> findByEmploye(Connection connection, string idEmploye, string sortByPropertyName);
    }
}
