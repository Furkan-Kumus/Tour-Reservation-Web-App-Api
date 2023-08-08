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
    public class CityReadRepository : ReadRepository<City>, ICityReadRepository
    {
        public CityReadRepository(RegisterAPIDbContext context) : base(context)
        {
        }
    }
}
