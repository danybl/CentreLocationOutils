﻿using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CentreLocationOutils.dao.interfaces
{
    public interface IDAO
    {
        /// <summary>
        /// Ajoute un nouveau DTO dans la base de données
        /// </summary>
        /// <param name="connexion">La connexion à utiliser</param>
        /// <param name="dto">Le DTO à ajouter</param>
        void add(Connection connexion,
            DTO dto);

        /// <summary>
        /// Lit un DTO à partir de la base de données
        /// </summary>
        /// <param name="connexion">La connexion ;a utiliser</param>
        /// <param name="primaryKey">La clé primaire du DTO à lire</param>
        /// <returns>Le DTO à retourner</returns>
        DTO get(Connection connexion,
            ISerializable primaryKey);

    /// <summary>
    /// Met à jour un DTO dans la base de données
    /// </summary>
    /// <param name="connexion">La connexion à utiliser</param>
    /// <param name="dto">Le DTO à mettre à jour</param>
    void update(Connection connexion,
        DTO dto);

    /// <summary>
    /// Supprime un DTO de  la base de données
    /// </summary>
    /// <param name="connexion">La connexion à utiliser</param>
    /// <param name="dto">Le DTO à supprimer</param>
    void delete(Connection connexion,
        DTO dto);

        /// <summary>
        /// Trouve tous les DTOs de la base de données. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun
        /// DTO n'est trouvé, une List vide est retournée.
        /// </summary>
        /// <param name="connexion">La connexion à utiliser</param>
        /// <param name="sortByPropertyName">Le nom de la propriété à uriliser pour classer la liste</param>
        /// <returns>La liste de tous les DTOs</returns>
        List<dynamic> getAll(Connection connexion,
        string sortByPropertyName);

    }
}
