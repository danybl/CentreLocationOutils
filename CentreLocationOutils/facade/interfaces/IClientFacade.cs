using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IClientFacade : IFacade
    {
        public virtual ClientDTO getClient(Connection connection, string idClient);

        public virtual List<ClientDTO> findByNom(Connection connection, String nom, String SortByPropertyName);

        public virtual List<ClientDTO> isncrire(Connection connection, ClientDTO clientDTO);
    }
}
