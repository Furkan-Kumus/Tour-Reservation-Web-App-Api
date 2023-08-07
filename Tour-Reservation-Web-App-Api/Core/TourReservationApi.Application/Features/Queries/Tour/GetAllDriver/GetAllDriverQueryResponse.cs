using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllDriver
{
    public class GetAllDriverQueryResponse
    {
        public int TotalCount { get; set; }
        public object Drivers { get; set; }
    }
}