using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-T1SVJU1\SQLEXPRESS;database=corpersonel;integrated security=true;");
        }

        public DbSet<departmanlar> departmanlars { get; set; }
        public DbSet<personel> personels { get; set; }
    }
}
