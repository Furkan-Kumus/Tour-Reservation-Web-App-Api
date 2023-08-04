using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Flight : BaseEntity
    {
        public string FlightCode { get; set; }
        public string FlightRegion { get; set; }

    }
}
