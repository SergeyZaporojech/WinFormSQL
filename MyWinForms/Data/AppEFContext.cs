using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinForms.Data
{
    public class AppEFContext:DbContext
    {     
        public AppEFContext()
        {         
        //this.Database.EnsureCreated();     //якщо не використовуємо міграцію даних    
        }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Integrated Security =True; Initial Catalog = myhellodb");
        }

    }
}
