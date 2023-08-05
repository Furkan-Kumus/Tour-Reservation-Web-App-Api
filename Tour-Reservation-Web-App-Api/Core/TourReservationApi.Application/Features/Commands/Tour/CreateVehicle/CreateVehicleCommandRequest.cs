using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateVehicle
{
    public class CreateVehicleCommandRequest : IRequest<CreateVehicleCommandResponse>
    {
        public string VehicleCode { get; set; }
        public string VehicleLicensePlate { get; set; }
        public string VehicleDriver { get; set; }
        public string VehicleType { get; set; }
        public string VehicleForPeople { get; set; }
    }
}
