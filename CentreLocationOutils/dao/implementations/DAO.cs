using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using CentreLocationOutils.exception;

namespace CentreLocationOutils.dao.implementations
{
    public class DAO
    {
        private Type dtoClass;

        protected DAO(Type dtoClass) : base() {
        if(dtoClass == null) {
            throw new InvalidDTOClassException("La classe de DTO ne peut être null");
        }
        setDtoClass(dtoClass);
        }

        protected Type getDtoClass() {
        return this.dtoClass;
        }

        private void setDtoClass(Type dtoClass) {
        this.dtoClass = dtoClass;
        }

        
    }
}
