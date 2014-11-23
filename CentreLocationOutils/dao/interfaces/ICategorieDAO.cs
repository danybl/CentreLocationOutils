using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;

namespace CentreLocationOutils.dao.interfaces
{
    public interface ICategorieDAO : IDAO
    {
        ///<summary>Trouve les catégories à partir d'un nom. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucune catégorie
        ///n'est trouvée, une {@link List} vide est retournée.</summary>>
        /// <param name="connection">La connexion à utiliser</param>
        ///<param name="nom">Le nom à trouver</param>
        ///<param name="sortByPropertyName">The nom de la propriété à utiliser pour classer</param>
        /// <returns> La liste des catégories correspondants à une liste vide sinon</returns>

        List<CategorieDTO> findByNom(Connection connection,
            String nom,
            String sortByPropertyName);
    }
}
