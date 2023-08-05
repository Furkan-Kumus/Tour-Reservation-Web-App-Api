
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateAirport;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateAirport
{
    public class CreateAirportCommandHandler : IRequestHandler<CreateAirportCommandRequest, CreateAirportCommandResponse>
    {
        readonly IAirportWriteRepository _AirportWriteRepository;

        public CreateAirportCommandHandler(IAirportWriteRepository AirportWriteRepository)
        {
            _AirportWriteRepository = AirportWriteRepository;
        }

        public async Task<CreateAirportCommandResponse> Handle(CreateAirportCommandRequest request, CancellationToken cancellationToken)
        {
            await _AirportWriteRepository.AddAsync(new()
            {
                AirportCode = request.AirportCode,
                AirportName = request.AirportName,
                AirportCountry = request.AirportCountry,
            });
            await _AirportWriteRepository.SaveAsync();
            return new();

        }
    }
}