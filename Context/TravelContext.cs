using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TravelCountdownApi.Model;

namespace TravelCountdownApi.Context
{
    public class TravelContext : DbContext
    {
        public TravelContext(DbContextOptions<TravelContext> options)
        : base(options)
        { }

        public DbSet<TravelDestination> TravelDestinations { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=TravelDestination.db");
        // }
    }
}