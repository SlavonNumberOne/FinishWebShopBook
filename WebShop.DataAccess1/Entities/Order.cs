using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess1;
using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
  public  class Order: BaseEntity
    {
        public User User  { get; set; }
        public string Paid { get; set; } // оплата
        public string Delivery { get; set; }//достиавка
        public string Comment { get; set; }//комментарий
    }
}

