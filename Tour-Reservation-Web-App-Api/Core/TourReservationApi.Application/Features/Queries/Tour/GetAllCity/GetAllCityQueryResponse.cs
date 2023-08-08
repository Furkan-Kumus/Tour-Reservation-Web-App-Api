using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllCity
{
    public class GetAllCityQueryResponse
    {
        public int TotalCount { get; set; }
        public object Citys { get; set; }
    }
}