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
    public interface IEmployeService : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="employeDTO"></param>
        public void add(Connection connection,
        EmployeDTO employeDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public EmployeDTO get(Connection connection,
        string primaryKey);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="employeDTO"></param>
        public void update(Connection connection,
        EmployeDTO employeDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="employeDTO"></param>
        public void delete(Connection connection,
        EmployeDTO employeDTO);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public List<EmployeDTO> getAll(Connection connection,
        string sortByPropertyName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="nom"></param>
        /// <param name="sortByPropertyName"></param>
        /// <returns></returns>
        public List<EmployeDTO> findByNom(Connection connection, string nom,
        string sortByPropertyName);
    }
}
