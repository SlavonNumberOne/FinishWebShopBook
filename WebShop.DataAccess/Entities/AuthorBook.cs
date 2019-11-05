using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess.Entities.Base;

namespace WebShop.DataAccess.Entities
{
   public class AuthorBook: BaseEntity
    {
        public Author Author { get; set; }
        public Book Book { get; set; }
        public DateTime Date { get; set; }
    }
}
