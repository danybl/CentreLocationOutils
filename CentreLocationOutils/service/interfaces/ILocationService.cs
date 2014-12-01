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
    /// Interface de base pour les services.<br/>
    /// Toutes les interfaces de service devrait en hériter.
    /// </summary>
    public interface ILocationService : IService
    {
        /// <summary>
        /// Ajoute une nouvelle location dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="locationDTO">La location à ajouter</param>
        void add(Connection connection, LocationDTO locationDTO);

        /// <summary>
        /// Lit une location à partir de la base de données.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="locationDTO">La location à ajouter</param>
        void get(Connection connection, string idLocation);

        /// <summary>
        /// Met à jour une location dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="locationDTO">La location à ajouter</param>
        void update(Connection connection, LocationDTO locationDTO);

        /// <summary>
        /// Supprime une location de la base de données.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="locationDTO">La location à ajouter</param>
        void delete(Connection connection, LocationDTO locationDTO);

        /// <summary>
        /// Trouve tous les locations de la base de données. 
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="sortByPropertyName">La liste est classée par ordre croissant sur <code>sortByPropertyName</code>.</param>
        /// <returns>Si aucune location n'est trouvée, une {@link List} vide est retournée.</returns>
        List<LocationDTO> getall(Connection connection, string sortByPropertyName);
    }
}
