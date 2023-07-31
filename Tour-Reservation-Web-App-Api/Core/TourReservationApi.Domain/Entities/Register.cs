using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Domain.Entities.Common;

namespace TourReservationApi.Domain.Entities
{
    public class Register : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
