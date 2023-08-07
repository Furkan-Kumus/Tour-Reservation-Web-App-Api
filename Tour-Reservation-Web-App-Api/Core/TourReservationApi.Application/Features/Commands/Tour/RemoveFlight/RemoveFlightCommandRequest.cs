using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveFlight
{
    public class RemoveFlightCommandRequest : IRequest<RemoveFlightCommandResponse>
    {
        public string Id { get; set; }
    }
}
