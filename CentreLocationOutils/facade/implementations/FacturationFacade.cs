using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.facade.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.facade.implementations
{
    /// <summary>
    /// Facade pour interagir avec le service de facture.
    /// </summary>
    public class FacturationFacade : Facade, IFacturationFacade
    {
        private IFacturationFacade facturationFacade;

        public FacturationFacade(IFacturationFacade facturationFacade) : base() {

            if (facturationFacade == null)
            {
                throw new InvalidServiceException("Le service de facture ne peut être null");
            }
            setFacturationFacade(facturationFacade);
        }

        #region Getters and Setters

        /// <summary>
        /// Getter de la variable d'instance <code>this.facturationFacade</code>.
        /// </summary>
        /// <returns>La variable d'instance <code>this.facturationFacade</code></returns>
        private IFacturationFacade getFacturationFacade()
        {
            return this.facturationFacade;
        }

        /// <summary>
        /// Setter de la variable d'instance <code>this.facturationFacade</code>.
        /// </summary>
        /// <param name="facturationFacade">La valeur à utiliser pour la variable d'instance <code>this.facturationFacade</code></param>
        private void setFacturationFacade(IFacturationFacade facturationFacade)
        {
            this.facturationFacade = facturationFacade;
        }

        #endregion

        public override List<FacturationDTO> findByClient(Connection connection, string idClient, string sortByPropertyName) {
            try
            {
               return getFacturationFacade().findByClient(connection, idClient, sortByPropertyName);
            }
            catch (ServiceException serviceExcpetion)
            {
                throw new FacadeException("", serviceExcpetion);
            }
        }

        public override List<FacturationDTO> findByEmploye(Connection connection, string idEmploye, string sortByPropertyName)
        {
            try {
                return getFacturationFacade().findByEmploye(connection, idEmploye, sortByPropertyName);
            }
            catch (ServiceException serviceExcpetion) {
                throw new FacadeException("", serviceExcpetion);
            }
        }
    }
}
