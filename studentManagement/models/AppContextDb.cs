using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentManagement.models
{
    public class AppContextDb:DbContext
    {

        public AppContextDb(DbContextOptions<AppContextDb> options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
