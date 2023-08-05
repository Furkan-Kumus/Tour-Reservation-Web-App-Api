using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Country : BaseEntity
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

    }
}
