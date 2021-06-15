using HotBargainVbEx.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBargainVbEx.Data
{
    public class HotBargainsDbContext : DbContext
    {
        public HotBargainsDbContext( DbContextOptions<HotBargainsDbContext> options ) : base(options)
        {
        }

        public DbSet<Vestiging> Vestigingen { get; set; }

        public DbSet<Project> Projecten { get; set; }
        public DbSet<Personeel> Personeelsleden { get; set; }
    }
}
