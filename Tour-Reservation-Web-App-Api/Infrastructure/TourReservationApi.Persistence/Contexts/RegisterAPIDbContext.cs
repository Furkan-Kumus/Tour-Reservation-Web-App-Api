using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.PowerBI.Api.Models;
using TourReservationApi.Domain.Entities;
using TourReservationApi.Domain.Entities.Identity;

namespace TourReservationApi.Persistence.Contexts
{
    public class RegisterAPIDbContext : IdentityDbContext<Domain.Entities.Identity.AppUser, AppRole, string>
    {
        public RegisterAPIDbContext(DbContextOptions options) 
            : base(options) { }

        public DbSet<Register> Registers { get; set; }

        
    }
}
