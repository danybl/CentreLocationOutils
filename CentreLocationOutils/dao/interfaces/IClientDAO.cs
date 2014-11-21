using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;

namespace CentreLocationOutils.dao.interfaces
{
    public interface IClientDAO : IDAO
    {

     
     ///<summary>Trouve les clients à partir d'un nom. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun client
     ///n'est trouvé, une {@link List} vide est retournée.</summary>>
     /// <param name="connection">La connexion à utiliser</param>
     ///<param name="nom">Le nom à trouver</param>
     ///<param name="sortByPropertyName">The nom de la propriété à utiliser pour classer</param>
     /// <returns> La liste des clients correspondants à une liste vide sinon</returns>
     
        List<ClientDTO> findByNom(Connection connection,
            String nom,
            String sortByPropertyName);

    }
}
