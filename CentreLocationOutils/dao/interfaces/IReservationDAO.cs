using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;

namespace CentreLocationOutils.dao.interfaces
{
    public interface IReservationDAO
    {
        /// <summary>
        /// Trouve les réservations d'un client. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucune réservation
        /// n'est trouvée, une {@link List} vide est retournée.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="idClient">L'ID du client à trouver</param>
        /// <param name="sortByPropertyName">Le nom de la propriété à utiliser pour classer</param>
        /// <returns>La liste des réservation correspondantes</returns>
        public List<ReservationDTO> findByClient(Connection connection,
        String idClient,
        String sortByPropertyName);

        /// <summary>
        /// Trouve les réservations pour un outil. La liste est classée par ordre croissant sur <code>sortByPropertyName</code>. Si aucune réservation
        /// n'est trouvée, une {@link List} vide est retournée.
        /// </summary>
        /// <param name="connection">La connexion à utiliser</param>
        /// <param name="idOutil">L'ID de l'outil à trouver</param>
        /// <param name="sortByPropertyName">Le nom de la propriété à utiliser pour classer</param>
        /// <returns>La liste des réservation correspondantes</returns>
        public List<ReservationDTO> findByOutil(Connection connection,
        String idClient,
        String sortByPropertyName);
    }
}
