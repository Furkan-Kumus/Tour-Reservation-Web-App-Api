using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveVehicle;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveVehicle
{
    public class RemoveVehicleCommandHandler : IRequestHandler<RemoveVehicleCommandRequest, RemoveVehicleCommandResponse>
    {
        readonly IVehicleWriteRepository _VehicleWriteRepository;

        public RemoveVehicleCommandHandler(IVehicleWriteRepository VehicleWriteRepository)
        {
            _VehicleWriteRepository = VehicleWriteRepository;
        }

        public async Task<RemoveVehicleCommandResponse> Handle(RemoveVehicleCommandRequest request, CancellationToken cancellationToken)
        {
            await _VehicleWriteRepository.RemoveAsync(request.Id);
            await _VehicleWriteRepository.SaveAsync();
            return new();
        }
    }
}
