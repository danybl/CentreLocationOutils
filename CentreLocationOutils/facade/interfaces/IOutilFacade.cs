using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.facade.interfaces
{
    public interface IOutilFacade : IFacade
    {
        OutilDTO getOutil(Connection connection, string idOutil);
        void acquerirOutil(Connection connection, OutilDTO outilDTO);
        void vendreOutil(Connection connection, OutilDTO outilDTO);
        void findByNom(Connection connection, OutilDTO outilDTO);
    }
}
