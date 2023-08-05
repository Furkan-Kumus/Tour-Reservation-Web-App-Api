using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateFlight
{
    public class CreateTourCommandRequest : IRequest<CreateTourCommandResponse>
    {
        public string FlightCode { get; set; }
        public string FlightRegion { get; set; }
    }
}
