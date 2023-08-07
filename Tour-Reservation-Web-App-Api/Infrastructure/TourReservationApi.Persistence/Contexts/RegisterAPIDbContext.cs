using TourReservationApi.Domain.Entities;
using TourReservationApi.Domain.Entities.Common;
using TourReservationApi.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Domain.Entities.Common;
using TourReservationApi.Domain.Entities.Identity;

namespace TourReservationApi.Persistence.Contexts
{
    public class RegisterAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public RegisterAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Register> Registers { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}
