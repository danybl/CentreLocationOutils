using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.service.interfaces;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;

namespace CentreLocationOutils.service.implementations
{
    public class EmployeService : IService, IEmployeService
    {
        private IEmployeDAO employeDAO;

        public EmployeService(IEmployeDAO employeDAO) : base() {
            if (employeDAO == null)
            {
                //throw new InvalidDAO
                //TODO créer InvalidDAOException
            }
        }
        /// <summary>
        /// Getter de la variable d'instance employeDAO
        /// </summary>
        /// <returns>La valeur de la variable d'instance</returns>
        private IEmployeDAO getEmployeDAO()
        {
            return this.employeDAO;
        }
        /// <summary>
        /// Setter de la variable d'instance employeDAO
        /// </summary>
        /// <param name="employeDAO">Valeur à utiliser pour la variable d'instance</param>
        private void setEmployeDAO(IEmployeDAO employeDAO)
        {
            this.employeDAO = employeDAO;
        }

        public override void addEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().add(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    public override EmployeDTO getEmploye(Connection connection,
        String idEmploye)  {
        try {
            return (EmployeDTO) getEmployeDAO().get(connection,
                idEmploye);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    public override void updateEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().update(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    public void deleteEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().delete(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    public List<EmployeDTO> getAllEmployes(Connection connection,
        String sortByPropertyName) {
        try {
            return (List<EmployeDTO>) getEmployeDAO().getAll(connection,
                sortByPropertyName);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }


    }
}
