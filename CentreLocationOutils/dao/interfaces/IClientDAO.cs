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

     /**
     * Trouve les clients à partir d'un nom. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun client
     * n'est trouvé, une {@link List} vide est retournée.
     * 
     * @param connexion La connexion à utiliser
     * @param nom Le nom à trouver
     * @param sortByPropertyName The nom de la propriété à utiliser pour classer
     * @return La liste des clients correspondants à une liste vide sinon
     */
        List<ClientDTO> findByNom(Connection connection,
            String nom,
            String sortByPropertyName);

    }
}
