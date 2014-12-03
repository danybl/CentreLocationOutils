using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentreLocationOutils.facade.implementations
{
    public class AdresseFacade
    {
        private IAdresseService adresseService;
        public AdresseFacade(IAdresseService adresseService)
            : base()
        {
            if (adresseService == null)
            {
                throw new InvalidServiceException("Le service d'adresse ne peut être null");
            }
            setAdresseService(adresseService);
        }

        //Getters and Setters
        /**
         * Getter de la variable d'instance <code>this.adresseService</code>.
         *
         * @return La variable d'instance <code>this.adresseService</code>
         */
        private IAdresseService getAdresseService()
        {
            return this.adresseService;
        }

        /**
         * Setter de la variable d'instance <code>this.adresseService</code>.
         *
         * @param adresseService La valeur à utiliser pour la variable d'instance <code>this.adresseService</code>
         */
        private void setAdresseService(IAdresseService adresseService)
        {
            this.adresseService = adresseService;
        }
        /**
         *Change l'adresse d'un client déjà existant
         *
         * @param connection. La connection à utiliser.
         * @param adresseDTO. L'adresse à changer.
         */
        public override void changerAdresse(Connection connection, AdresseDTO adresseDTO)
        {
            try
            {
                getAdresseService().changerAdresse(connection, adresseDTO);
            }
            catch (ServiceException serviceExcpetion)
            {
                throw new FacadeException("", serviceExcpetion);
            }
        }

    }
}