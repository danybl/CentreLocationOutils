using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IAdresseFacade : IFacade
    {
        public virtual void changerLocation(Connection connection, AdresseDTO adresseDTO);
    }
}
