using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using CentreLocationOutils.exception.dto;

namespace CentreLocationOutils.dao.implementations 
{
    public class DAO<T>
    {
        private T dtoClass;

        protected DAO(T dtoClass)
            : base()
        {
        if(dtoClass == null) {
            throw new InvalidDTOClassException("La classe de DTO ne peut être null");
        }
        setDtoClass(dtoClass);
        }

        protected T getDtoClass()
        {
        return this.dtoClass;
        }

        private void setDtoClass(T dtoClass)
        {
        this.dtoClass = dtoClass;
        }

        
    }
}
