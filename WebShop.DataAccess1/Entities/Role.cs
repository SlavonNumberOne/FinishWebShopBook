﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using WebShop.DataAccess1.Entities.Base;

namespace WebShop.DataAccess1.Entities
{
    public class Role:IdentityRole
    {
        public string Name { get; set; }
    }
}
