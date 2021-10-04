using MenuApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuApp.Data
{
    public class MenuContext:DbContext
    {
        public MenuContext(DbContextOptions options) : base(options) { }

        public DbSet<Menuclass> menuclasses { get; set; }
    }
}
