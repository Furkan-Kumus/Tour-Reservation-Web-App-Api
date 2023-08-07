using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllAirport
{
    public class GetAllAirportQueryResponse
    {
        public int TotalCount { get; set; }
        public object Airports { get; set; }
    }
}