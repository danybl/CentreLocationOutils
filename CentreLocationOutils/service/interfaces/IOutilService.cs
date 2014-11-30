using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using System.Collections.Generic;


namespace CentreLocationOutils.service.interfaces
{
    /// <summary>
    /// L'interface pour OutilService
    /// </summary>
    public interface IOutilService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="outilDTO"></param>
        public virtual void add(Connection connection,
        OutilDTO outilDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public virtual OutilDTO get(Connection connection,
        string primaryKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="outilDTO"></param>
        public virtual void update(Connection connection,
        OutilDTO outilDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="outilDTO"></param>
        public virtual void delete(Connection connection,
        OutilDTO outilDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public virtual List<OutilDTO> getAll(Connection connection,
        string sortByPropertyName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="nom"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public virtual List<OutilDTO> findByNom(Connection connection, string nom,
        string sortByPropertyName);
    }
}
