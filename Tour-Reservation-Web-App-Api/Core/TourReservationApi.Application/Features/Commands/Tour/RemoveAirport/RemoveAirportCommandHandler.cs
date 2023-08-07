using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveAirport;
using TourReservationApi.Application.Features.Commands.Tour.RemoveAirport;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveAirport
{
    public class RemoveAirportCommandHandler : IRequestHandler<RemoveAirportCommandRequest, RemoveAirportCommandResponse>
    {
        readonly IAirportWriteRepository _AirportWriteRepository;

        public RemoveAirportCommandHandler(IAirportWriteRepository AirportWriteRepository)
        {
            _AirportWriteRepository = AirportWriteRepository;
        }

        public async Task<RemoveAirportCommandResponse> Handle(RemoveAirportCommandRequest request, CancellationToken cancellationToken)
        {
            await _AirportWriteRepository.RemoveAsync(request.Id);
            await _AirportWriteRepository.SaveAsync();
            return new();
        }
    }
}
