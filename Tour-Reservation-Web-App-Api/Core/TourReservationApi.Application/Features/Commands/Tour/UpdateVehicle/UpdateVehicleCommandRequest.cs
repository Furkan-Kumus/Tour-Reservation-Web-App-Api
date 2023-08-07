using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Vehicle.UpdateVehicle
{
    public class UpdateVehicleCommandRequest : IRequest<UpdateVehicleCommandResponse>
    {

        public string Id { get; set; }
        public string VehicleCode { get; set; }
        public string VehicleLicensePlate { get; set; }
        public string VehicleDriver { get; set; }
        public string VehicleType { get; set; }
        public string VehicleForPeople { get; set; }
    }
}
