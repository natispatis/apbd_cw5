using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwicz5.Filters
{
    public interface IExceptionFilter : IFilterMetadata
    {
        void OnException(ExceptionContext context);

    }
}
