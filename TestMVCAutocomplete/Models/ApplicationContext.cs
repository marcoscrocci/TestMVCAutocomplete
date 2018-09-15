using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Redefinindo o nome da tabela
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Car>().ToTable("Car");
            modelBuilder.Entity<Color>().ToTable("Color");            

            // Especificando a propriedade Id como chave primária.
            modelBuilder.Entity<Brand>().HasKey(p => p.BrandId);
            modelBuilder.Entity<Car>().HasKey(p => p.CarId);
            modelBuilder.Entity<Color>().HasKey(p => p.ColorId);

            // Especificando a chave Id como Identity (auto-incremento)
            modelBuilder.Entity<Brand>()
                .Property(p => p.BrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Car>()
                .Property(p => p.CarId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Color>()
                .Property(p => p.ColorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Brand> Brands { get; set; }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Color> Colors { get; set; }

        public System.Data.Entity.DbSet<TestMVCAutocomplete.Models.Car> Cars { get; set; }
    
    }
}
