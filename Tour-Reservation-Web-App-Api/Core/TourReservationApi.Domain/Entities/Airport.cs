using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Airport : BaseEntity
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string AirportCountry { get; set; }

    }
}
