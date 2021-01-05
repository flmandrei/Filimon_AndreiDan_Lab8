using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filimon_AndreiDan_Lab8.Models;

namespace Filimon_AndreiDan_Lab8.Data
{
    public class Filimon_AndreiDan_Lab8Context : DbContext
    {
        public Filimon_AndreiDan_Lab8Context (DbContextOptions<Filimon_AndreiDan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Filimon_AndreiDan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Filimon_AndreiDan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Filimon_AndreiDan_Lab8.Models.Category> Category { get; set; }
    }
}
