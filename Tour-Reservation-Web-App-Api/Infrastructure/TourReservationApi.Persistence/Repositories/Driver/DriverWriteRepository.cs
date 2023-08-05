using TourReservationApi.Application.Repositories;
using TourReservationApi.Domain.Entities;
using TourReservationApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Persistence.Repositories
{
    public class DriverWriteRepository : WriteRepository<Driver>, IDriverWriteRepository
    {
        public DriverWriteRepository(RegisterAPIDbContext context) : base(context)
        {
        }
    }
}
