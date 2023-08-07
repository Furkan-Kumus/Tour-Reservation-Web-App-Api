using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllVehicle;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllVehicle
{
    public class GetAllVehicleQueryHandler : IRequestHandler<GetAllVehicleQueryRequest, GetAllVehicleQueryResponse>
    {
        readonly IVehicleReadRepository _VehicleReadRepository;
        public GetAllVehicleQueryHandler(IVehicleReadRepository VehicleReadRepository)
        {
            _VehicleReadRepository = VehicleReadRepository;
        }
        public async Task<GetAllVehicleQueryResponse> Handle(GetAllVehicleQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _VehicleReadRepository.GetAll(false).Count();
            var Vehicles = _VehicleReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.VehicleCode,
                p.VehicleLicensePlate,
                p.VehicleDriver,
                p.VehicleType,
                p.VehicleForPeople,
            }).ToList();

            return new()
            {
                Vehicles = Vehicles,
                TotalCount = totalCount
            };
        }
    }
}