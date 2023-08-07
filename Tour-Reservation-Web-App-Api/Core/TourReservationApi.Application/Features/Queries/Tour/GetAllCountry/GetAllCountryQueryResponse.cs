using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllCountry
{
    public class GetAllCountryQueryResponse
    {
        public int TotalCount { get; set; }
        public object Countrys { get; set; }
    }
}