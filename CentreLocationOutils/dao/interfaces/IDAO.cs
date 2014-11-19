using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;
using System.Runtime.Serialization;

namespace CentreLocationOutils.dao.interfaces
{
    public interface IDAO
    {
       /**
     * Ajoute un nouveau DTO dans la base de données.
     * 
     * @param connexion La connexion à utiliser
     * @param dto Le DTO à ajouter
     */
        void add(Connection connexion,
            DTO dto);

    /**
     * Lit un DTO à partir de la base de données.
     * 
     * @param connexion La connexion à utiliser
     * @param primaryKey La clef primaire du DTO à lire
     * @return Le livre
     */
        DTO get(Connection connexion,
            ISerializable primaryKey);

        /**
     * Met à jour un DTO dans la base de données.
     * 
     * @param connexion La connexion à utiliser
     * @param dto Le DTO à mettre à jour
     */
    void update(Connection connexion,
        DTO dto);

    /**
     * Supprime un DTO de la base de données.
     * 
     * @param connexion La connexion à utiliser
     * @param dto Le DTO à supprimer
     */
    void delete(Connection connexion,
        DTO dto);

    /**
     * Trouve tous les DTOs de la base de données. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucun
     * DTO n'est trouvé, une {@link List} vide est retournée.
     * 
     * @param connexion La connexion à utiliser
     * @param sortByPropertyName The nom de la propriété à utiliser pour classer
     */
        List<dynamic> getAll(Connection connexion,
        String sortByPropertyName);

    }
}
