using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Domain.Entities.Identity
{
    public class AppFlight : IdentityUser<string>
    {
        public string FlightCode { get; set; }
        public string FlightRegion { get; set; }
    }
}
