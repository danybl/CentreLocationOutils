using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.facade.implementations
{
    public class ClientFacade : Facade, IClientFacade
    {
    private IClientService clientService;

    private IEmployeService employeService;

     public ClientFacade(IClientService clientService) : base() {
            if (clientService == null)
            {
                throw new InvalidServiceException("Le service de client ne peut être null");
            }
            setClientService(clientService);
        }

     //Getters and Setters
     /**
      * Getter de la variable d'instance <code>this.clientService</code>.
      *
      * @return La variable d'instance <code>this.clientService</code>
      */
     private IClientService getClientService()
     {
         return this.clientService;
     }

     /**
      * Setter de la variable d'instance <code>this.clientService</code>.
      *
      * @param clientService La valeur à utiliser pour la variable d'instance <code>this.clientService</code>
      */
     private void setClientService(IClientService clientService)
     {
         this.clientService = clientService;
     }

     public override List<ClientDTO> findByNom(Connection connection, String nom, String SortByPropertyName)
     {
         try
         {
             return getClientService().findByNom(connection, nom, SortByPropertyName);
         }
         catch (ServiceException serviceException)
         {
             throw new FacadeException("", serviceException);
         }
    }
    }
}
