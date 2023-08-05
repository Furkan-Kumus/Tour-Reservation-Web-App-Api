using TourReservationApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Repositories
{
    public interface ICountryWriteRepository : IWriteRepository<Country>
    {
    }
}
