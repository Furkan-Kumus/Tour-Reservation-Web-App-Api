using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Driver : BaseEntity
    {
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }

    }
}
