using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Entities.Base;
using WebShopDataAccesLear;

namespace WebShop.DataAccess.Entities
{
    public class OrderItem : BaseEntity
    {
        public Book Book { get; set; }
        public Order Order { get; set; }
        public int Count { get; set; }//количество
    } 
}
