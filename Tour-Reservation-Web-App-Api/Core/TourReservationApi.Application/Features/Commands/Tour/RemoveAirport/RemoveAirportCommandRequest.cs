using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveAirport
{
    public class RemoveAirportCommandRequest : IRequest<RemoveAirportCommandResponse>
    {
        public string Id { get; set; }
    }
}
