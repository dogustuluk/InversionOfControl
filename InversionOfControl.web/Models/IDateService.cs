using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InversionOfControl.web.Models
{
    interface IDateService
    {
        DateTime GetDateTime { get; }
    }
    
     interface ISingletonDateService: IDateService { }
     interface IScopedDateService: IDateService { }
     interface ITransientDateService: IDateService { }
}
