using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.facade.interfaces
{
    public interface ILocationFacade : IFacade
    {
        public virtual void commencerLocation(Connection connection, LocationDTO locationDTO);
        public virtual void renouvelerLocation(Connection connection, LocationDTO locationDTO);
        public virtual void terminerLocation(Connection connection, LocationDTO locationDTO);
        public virtual List<LocationDTO> findByClient(Connection connection, LocationDTO locationDTO);
    }
}
