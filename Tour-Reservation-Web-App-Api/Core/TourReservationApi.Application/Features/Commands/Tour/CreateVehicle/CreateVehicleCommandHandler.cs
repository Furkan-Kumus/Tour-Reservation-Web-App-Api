
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateVehicle;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateVehicle
{
    public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommandRequest, CreateVehicleCommandResponse>
    {
        readonly IVehicleWriteRepository _VehicleWriteRepository;

        public CreateVehicleCommandHandler(IVehicleWriteRepository VehicleWriteRepository)
        {
            _VehicleWriteRepository = VehicleWriteRepository;
        }

        public async Task<CreateVehicleCommandResponse> Handle(CreateVehicleCommandRequest request, CancellationToken cancellationToken)
        {
            await _VehicleWriteRepository.AddAsync(new()
            {
                VehicleCode = request.VehicleCode,
                VehicleLicensePlate = request.VehicleLicensePlate,
                VehicleDriver = request.VehicleDriver,
                VehicleType = request.VehicleType,
                VehicleForPeople = request.VehicleForPeople,
            });
            await _VehicleWriteRepository.SaveAsync();
            return new();

    }
    }
}