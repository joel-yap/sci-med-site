﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _158258_Assignment_3.Data
{
    public class _158258_Assignment_3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public _158258_Assignment_3Context() : base("name=_158258_Assignment_3Context")
        {
        }

        public System.Data.Entity.DbSet<_158258_Assignment_3.Models.Treatment> Treatments { get; set; }

        public System.Data.Entity.DbSet<_158258_Assignment_3.Models.Category> Categories { get; set; }
    }
}
