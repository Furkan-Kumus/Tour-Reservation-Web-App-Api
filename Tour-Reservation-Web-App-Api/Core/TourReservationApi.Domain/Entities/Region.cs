using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Region : BaseEntity
    {
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public int RegionDistance { get; set; }

    }
}
