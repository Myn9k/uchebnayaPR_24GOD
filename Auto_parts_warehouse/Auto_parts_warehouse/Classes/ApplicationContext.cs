using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Auto_parts_warehouse.Classes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Towar> Towars { get; set; }
        public ApplicationContext() : base("DefaultConnection") { }
    }
}
