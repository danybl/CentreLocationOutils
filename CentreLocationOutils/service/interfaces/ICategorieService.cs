using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;


namespace CentreLocationOutils.service.interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICategorieService : IService
    {
        /**
        * Ajoute une nouvelle catégorie.
        *
        * @param connection La connection à utiliser
        * @param categorieDTO La catégorie à ajouter
        */
        public virtual void add(Connection connection,
        CategorieDTO categorieDTO) ;

        /**
        * Lit une catégorie.
        *
        * @param connection La connection à utiliser
        * @param categorieDTO La catégorie à lire
        */
        public virtual CategorieDTO get(Connection connection,
        String idCategorie);

        /**
        * Met à jour une catégorie.
        *
        * @param connection La connection à utiliser
        * @param categorieDTO La catégorie à mettre à jour
        */
        public virtual void update(Connection connection,
        CategorieDTO categorieDTO);

        /**
        * Efface une catégorie.
        *
        * @param connection La connection à utiliser
        * @param categorieDTO La catégorie à effacer
        */
        public virtual void delete(Connection connection,
        CategorieDTO categorieDTO);

        /**
        * Trouve tous les livres. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun
        * livre n'est trouvé, une {@link List} vide est retournée.
        *
        * @param connection La connection à utiliser
        * @param categorieDTO La catégorie à lire
        */
        public virtual List<CategorieDTO> getAll(Connection connection,
        String sortByPropertyName);

        /*Trouve une catégorie à partir d'un nom
         *
         *@param connection La connection à utiliser
         *@param nom Le nom à trouver
         *@param sortByPropertyName Le nom de la propriété à utiliser pour classer
         */
        public virtual List<CategorieDTO> findByNom(Connection connection,
        String nom,
        String sortByPropertyName);

    }
}
