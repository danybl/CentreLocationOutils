using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.exception.service;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.service.interfaces;
using System.Collections.Generic;

namespace CentreLocationOutils.facade.implementations
{
    public class LocationFacade : ILocationFacade
    {
        private ILocationService locationService;

        private IEmployeService employeService;

        public LocationFacade(ILocationService locationService)
            : base()
        {
            if (locationService == null)
            {
                throw new InvalidServiceException("Le service de location ne peut être null");
            }
            setLocationService(locationService);
        }

        private ILocationService getLocationService()
        {
            return this.locationService;
        }
        private void setLocationService(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        public override void commencerLocation(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationService().commencerLocation(connection, locationDTO);
            }
            catch (ServiceException serviceException)
            {
                throw new FacadeException("", serviceException);
            }
        }

        public override void renouvelerLocation(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationService().renouvelerLocation(connection, locationDTO);
            }
            catch (ServiceException serviceException)
            {
                throw new FacadeException("", serviceException);
            }
        }
        public override void terminerLocation(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                getLocationService().terminerLocation(connection, locationDTO);
            }
            catch (ServiceException serviceException)
            {
                throw new FacadeException("", serviceException);
            }
        }

        public override List<LocationDTO> findByClient(Connection connection, LocationDTO locationDTO)
        {
            try
            {
                return getLocationService().findByClient(connection, locationDTO);
            }
            catch (ServiceException serviceException)
            {
                throw new FacadeException("", serviceException);
            }
        }
    }
}
