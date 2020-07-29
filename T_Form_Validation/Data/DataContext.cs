using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T_Form_Validation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<CopyBook> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-E7O9U9N; Database=MyBookStore; Trusted_Connection=True; MultipleActiveResultSets=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}


    }
}
