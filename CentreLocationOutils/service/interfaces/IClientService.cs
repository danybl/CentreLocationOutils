using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.service.interfaces;
using CentreLocationOutils.dto;
using CentreLocationOutils.db;
using CentreLocationOutils.exception.service;

namespace CentreLocationOutils.service.interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientService : CentreLocationOutils.dao.interfaces.IService
    {
        void add(Connection connection, ClientDTO clientDTO) {
        throw new ServiceException;
        }
        ClientDTO get(Connection connection, String idClient){
        throw new ServiceException;
        }
        void update(Connection connection, ClientDTO clientDTO){
        throw new ServiceException;
        }
        void delete(Connection connection, ClientDTO clientDTO){
        throw new ServiceException;
        }
        List<ClientDTO> findByNom(Connection connection,String nom,String SortByPropertyName)
        {
        throw new ServiceException;
        }
    }
}
