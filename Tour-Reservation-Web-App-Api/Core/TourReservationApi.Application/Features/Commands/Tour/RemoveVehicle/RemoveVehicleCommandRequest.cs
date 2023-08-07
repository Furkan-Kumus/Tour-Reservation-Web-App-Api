using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveVehicle
{
    public class RemoveVehicleCommandRequest : IRequest<RemoveVehicleCommandResponse>
    {
        public string Id { get; set; }
    }
}
