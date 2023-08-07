using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateAirport;

namespace TourReservationApi.Application.Features.Commands.Airport.UpdateAirport
{
    public class UpdateAirportCommandRequest : IRequest<UpdateAirportCommandResponse>
    {

        public string Id { get; set; }
        public string AirportCode { get; set; }
        public string AirportName { get; set; }
        public string AirportCountry { get; set; }
    }
}
