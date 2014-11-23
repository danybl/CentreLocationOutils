using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dao.interfaces
{
    public interface IOutilDAO : IDAO
    {
        ///<summary>Trouve les outils à partir d'un nom. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun outil
        ///n'est trouvé, une {@link List} vide est retournée.</summary>>
        /// <param name="connection">La connexion à utiliser</param>
        ///<param name="nom">Le nom à trouver</param>
        ///<param name="sortByPropertyName">The nom de la propriété à utiliser pour classer</param>
        /// <returns> La liste des outils correspondants à une liste vide sinon</returns>

        List<OutilDTO> findByNom(Connection connection,
            String nom,
            String sortByPropertyName);
    }
}
