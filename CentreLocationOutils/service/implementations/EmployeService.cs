using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.service.interfaces;
using CentreLocationOutils.dao.interfaces;
using CentreLocationOutils.exception.dao;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.exception.dto;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;
using CentreLocationOutils.dao.implementations;

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
        /// <inheritdoc />
        public override void addEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().add(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

        /// <inheritdoc />
    public override EmployeDTO getEmploye(Connection connection,
        string idEmploye)  {
        try {
            return getEmployeDAO().get(connection,
                idEmploye);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    /// <inheritdoc />
    public override void updateEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().update(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    /// <inheritdoc />
    public override void deleteEmploye(Connection connection,
        EmployeDTO employeDTO) {
        try {
            getEmployeDAO().delete(connection,
                employeDTO);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    /// <inheritdoc />
    public override List<EmployeDTO> getAllEmployes(Connection connection,
        string sortByPropertyName) {
        try {
            return (List<EmployeDTO>) getEmployeDAO().getAll(connection,
                sortByPropertyName);
        } catch(DAOException daoException) {
            throw new ServiceException(daoException.Message);
        }
    }

    /// <inheritdoc />
    public override void inscrireEmploye(Connection connection, EmployeDTO employeDTO)
    {
        if (connection == null)
        {
            throw new InvalidConnectionException("La connection ne peut être null");
        }
        if (employeDTO == null)
        {
            throw new InvalidDTOException("L'employé ne peut être null");
        }
        try
        {
            addEmploye(connection, employeDTO);
        }
        catch (DAOException daoException)
        {
            //TODO verify upon testing
            throw new ServiceException(daoException.Message, daoException);
        }
    }

    /// <inheritdoc />
    public override void desinscrireEmployer(Connection connection, EmployeDTO employeDTO)
    {
        if (connection == null)
        {
            throw new InvalidConnectionException("La connection ne peut être null");
        }
        if (employeDTO == null)
        {
            throw new InvalidDTOException("L'employé ne peut être null");
        }
        try
        {
            deleteEmploye(connection, employeDTO);
        }
        catch (DAOException daoException)
        {
            throw new ServiceException("", daoException);
        }
    }

    /// <inheritdoc />
        public override void findByNom(Connection connection, EmployeDTO employeDTO){
            if (connection == null)
            {
                throw new InvalidConnectionException("La connection ne peut être null");
            }
            if (employeDTO == null)
            {
                throw new InvalidDTOException("L'employé ne peut être null");
            }
            try{
                getEmployeDAO().findByNom(connection, employeDTO.Nom, EmployeDTO.NOM_COLUMN_NAME);
            }catch(DAOException daoException){
                throw new ServiceException("", daoException);
            }
        }

    }
}
