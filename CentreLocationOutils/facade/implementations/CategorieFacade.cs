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
    public class CategorieFacade
    {
        private ICategorieService categorieService;
        public CategorieFacade(ICategorieService categorieService)
            : base()
        {
            if (categorieService == null)
            {
                throw new InvalidServiceException("Le service d'adresse ne peut être null");
            }
            setCategorieService(categorieService);
        }

        //Getters and Setters
        /**
         * Getter de la variable d'instance <code>this.categorieService</code>.
         *
         * @return La variable d'instance <code>this.categorieService</code>
         */
        private ICategorieService getCategorieService()
        {
            return this.categorieService;
        }

        /**
         * Setter de la variable d'instance <code>this.categorieService</code>.
         *
         * @param categorieService La valeur à utiliser pour la variable d'instance <code>this.categorieService</code>
         */
        private void setCategorieService(ICategorieService categorieService)
        {
            this.categorieService = categorieService;
        }
    }
}
