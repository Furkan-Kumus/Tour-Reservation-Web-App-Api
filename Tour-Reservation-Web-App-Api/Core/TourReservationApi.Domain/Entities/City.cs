using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class City : BaseEntity
    {
        public string CityCountry { get; set; }
        public string CityName { get; set; }
        public int CityDistance { get; set; }

    }
}
