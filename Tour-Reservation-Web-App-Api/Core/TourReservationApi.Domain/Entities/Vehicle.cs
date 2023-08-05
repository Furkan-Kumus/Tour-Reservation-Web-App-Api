using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string VehicleCode { get; set; }
        public string VehicleLicensePlate { get; set; }
        public string VehicleDriver { get; set;}
        public string VehicleType { get; set;}
        public string VehicleForPeople { get; set; }

    }
}
