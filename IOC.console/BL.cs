using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.console
{
    class BL
    {
        private IDAL _dal { get; set; } //burada "DAL" yerine "IDAL" yaparak Business Logic(BL)'in Data Access Layer(DAL) class'ı hakkında
                                        //bilgi sahibi öğrenmesini engellemiş olduk.
        public BL()
        {
            _dal = DALFactory.GetDal();
           
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
          
        }
        //public int Hesapla()
        //{
        //    return _dal.Hesapla();
        //}
        
    }
}
