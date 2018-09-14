﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestMVCAutocomplete.Models
{
    public class ApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ApplicationContext() : base("name=ApplicationContext")
        {
        }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Brand> Brands { get; set; }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Color> Colors { get; set; }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Car> Cars { get; set; }
    
    }
}
