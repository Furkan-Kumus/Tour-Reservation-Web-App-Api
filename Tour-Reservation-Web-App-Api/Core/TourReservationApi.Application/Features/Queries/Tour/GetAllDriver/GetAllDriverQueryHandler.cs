using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllDriver;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllDriver
{
    public class GetAllDriverQueryHandler : IRequestHandler<GetAllDriverQueryRequest, GetAllDriverQueryResponse>
    {
        readonly IDriverReadRepository _DriverReadRepository;
        public GetAllDriverQueryHandler(IDriverReadRepository DriverReadRepository)
        {
            _DriverReadRepository = DriverReadRepository;
        }
        public async Task<GetAllDriverQueryResponse> Handle(GetAllDriverQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _DriverReadRepository.GetAll(false).Count();
            var Drivers = _DriverReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.DriverName,
                p.DriverSurname,
            }).ToList();

            return new()
            {
                Drivers = Drivers,
                TotalCount = totalCount
            };
        }
    }
}