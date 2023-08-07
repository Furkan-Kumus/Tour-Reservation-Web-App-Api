using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Vehicle.UpdateVehicle
{
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommandRequest, UpdateVehicleCommandResponse>
    {
        readonly IVehicleReadRepository _VehicleReadRepository;
        readonly IVehicleWriteRepository _VehicleWriteRepository;

        public UpdateVehicleCommandHandler(IVehicleReadRepository VehicleReadRepository, IVehicleWriteRepository VehicleWriteRepository)
        {
            _VehicleReadRepository = VehicleReadRepository;
            _VehicleWriteRepository = VehicleWriteRepository;
        }

        public async Task<UpdateVehicleCommandResponse> Handle(UpdateVehicleCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Vehicle Vehicle = await _VehicleReadRepository.GetByIdAsync(request.Id);
            Vehicle.VehicleLicensePlate = request.VehicleLicensePlate;
            Vehicle.VehicleCode = request.VehicleCode;
            Vehicle.VehicleDriver = request.VehicleDriver;
            Vehicle.VehicleType = request.VehicleType;
            Vehicle.VehicleForPeople = request.VehicleForPeople;
            await _VehicleWriteRepository.SaveAsync();
            return new();
        }
    }
}
