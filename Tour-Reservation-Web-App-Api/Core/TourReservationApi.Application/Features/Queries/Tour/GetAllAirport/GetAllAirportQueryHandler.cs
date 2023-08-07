using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllAirport;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllAirport
{
    public class GetAllAirportQueryHandler : IRequestHandler<GetAllAirportQueryRequest, GetAllAirportQueryResponse>
    {
        readonly IAirportReadRepository _AirportReadRepository;
        public GetAllAirportQueryHandler(IAirportReadRepository AirportReadRepository)
        {
            _AirportReadRepository = AirportReadRepository;
        }
        public async Task<GetAllAirportQueryResponse> Handle(GetAllAirportQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _AirportReadRepository.GetAll(false).Count();
            var Airports = _AirportReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.AirportCode,
                p.AirportName,
                p.AirportCountry,
            }).ToList();

            return new()
            {
                Airports = Airports,
                TotalCount = totalCount
            };
        }
    }
}