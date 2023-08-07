using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllVehicle
{
    public class GetAllVehicleQueryResponse
    {
        public int TotalCount { get; set; }
        public object Vehicles { get; set; }
    }
}