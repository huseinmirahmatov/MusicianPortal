using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }

        public DbSet<Album> albums { get; set; }
        public DbSet<Artist> artists { get;set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<Listener> listeners { get; set; }
        public DbSet<PlayList> playLists { get; set; }
        public DbSet<Track> tracks { get; set; }    
        public DbSet<User> users { get; set; }
    }
  }
