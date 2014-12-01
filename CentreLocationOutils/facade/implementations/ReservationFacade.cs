using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CentreLocationOutils.facade.interfaces;
using CentreLocationOutils.service.interfaces;
using CentreLocationOutils.exception.facade;
using CentreLocationOutils.db;
using CentreLocationOutils.dto;
using CentreLocationOutils.service.implementations;
using CentreLocationOutils.exception.service;

namespace CentreLocationOutils.facade.implementations
{
   public class ReservationFacade : Facade, IReservationFacade
    {
       private IReservationService reservationService;

       public ReservationFacade(IReservationService reservationService)
           : base()
       {
           if (reservationService == null)
           {
               throw new InvalidServiceException("Le service de réservation ne peut être null");
           }
           setReservationService(reservationService);
       }

       private IReservationService getReservationService()
       {
           return this.reservationService;
       }
       private void setReservationService(IReservationService reservationService)
       {
           this.reservationService = reservationService;
       }

       public void placerReservation(Connection connection, ReservationDTO reservationDTO)
       {
           try
           {
               getReservationService().placerReservation(connection, reservationDTO);
           }
           catch (ServiceException serviceException)
           {
               throw new FacadeException("", serviceException);
           }
       }

       public void utiliserReservation(Connection connection, ReservationDTO reservationDTO)
       {
           try
           {
               getReservationService().utiliserReservation(connection, reservationDTO);
           }
           catch (ServiceException serviceException)
           {
               throw new FacadeException("", serviceException);
           }
       }

       public void annulerReservation(Connection connection, ReservationDTO reservationDTO)
       {
           try
           {
               getReservationService().annulerReservation(connection, reservationDTO);
           }
           catch (ServiceException serviceException)
           {
               throw new FacadeException("", serviceException);
           }
       }

       //TODO intégrer les findByXXXXX

    }
}
