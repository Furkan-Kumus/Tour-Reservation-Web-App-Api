using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllRegion
{
    public class GetAllRegionQueryResponse
    {
        public int TotalCount { get; set; }
        public object Regions { get; set; }
    }
}