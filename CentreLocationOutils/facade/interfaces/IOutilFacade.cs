using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IOutilFacade : IFacade
    {
        public virtual OutilDTO getOutil(Connection connection, string idOutil);
        public virtual void acquerirOutil(Connection connection, OutilDTO outilDTO);
        public virtual void vendreOutil(Connection connection, OutilDTO outilDTO);
        public virtual void findByNom(Connection connection, OutilDTO outilDTO);
    }
}
