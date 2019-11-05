using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
   public class AuthorBook: BaseEntity
    {
        public Author Author { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
    }
}
