using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateAirport;

namespace TourReservationApi.Application.Features.Commands.Airport.UpdateAirport
{
    public class UpdateAirportCommandHandler : IRequestHandler<UpdateAirportCommandRequest, UpdateAirportCommandResponse>
    {
        readonly IAirportReadRepository _AirportReadRepository;
        readonly IAirportWriteRepository _AirportWriteRepository;

        public UpdateAirportCommandHandler(IAirportReadRepository AirportReadRepository, IAirportWriteRepository AirportWriteRepository)
        {
            _AirportReadRepository = AirportReadRepository;
            _AirportWriteRepository = AirportWriteRepository;
        }

        public async Task<UpdateAirportCommandResponse> Handle(UpdateAirportCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Airport Airport = await _AirportReadRepository.GetByIdAsync(request.Id);
            Airport.AirportCode = request.AirportCode;
            Airport.AirportName = request.AirportName;
            Airport.AirportCountry = request.AirportCountry;
            await _AirportWriteRepository.SaveAsync();
            return new();
        }
    }
}
