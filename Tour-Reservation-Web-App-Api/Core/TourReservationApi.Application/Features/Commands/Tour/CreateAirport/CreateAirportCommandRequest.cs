using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateAirport
{
    public class CreateAirportCommandRequest : IRequest<CreateAirportCommandResponse>
    {
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string AirportCountry { get; set; }
    }
}
