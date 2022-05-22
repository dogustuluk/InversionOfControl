using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
     class DALFactory
    {
        public static IDAL GetDal() //burada soyut nesne örneğinden almalıyız.
        {
            return new DAL();
        }

    }
}
