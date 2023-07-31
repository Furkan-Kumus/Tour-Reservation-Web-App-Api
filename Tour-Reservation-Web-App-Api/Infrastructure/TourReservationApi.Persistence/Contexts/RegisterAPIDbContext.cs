using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Domain.Entities;

namespace TourReservationApi.Persistence.Contexts
{
    public class RegisterAPIDbContext : DbContext
    {
        public RegisterAPIDbContext(DbContextOptions options) 
            : base(options) { }

        public DbSet<Register> Registers { get; set; }

        
    }
}
