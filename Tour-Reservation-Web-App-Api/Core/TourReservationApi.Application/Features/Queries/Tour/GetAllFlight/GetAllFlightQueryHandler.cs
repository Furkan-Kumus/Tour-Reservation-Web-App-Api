using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Product.GetAllProduct;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllFlight
{
    public class GetAllFlightQueryHandler : IRequestHandler<GetAllFlightQueryRequest, GetAllFlightQueryResponse>
    {
        readonly IProductReadRepository _FlightReadRepository;
        public GetAllFlightQueryHandler(IProductReadRepository ProductReadRepository)
        {
            _FlightReadRepository = ProductReadRepository;
        }
        public async Task<GetAllFlightQueryResponse> Handle(GetAllFlightQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _FlightReadRepository.GetAll(false).Count();
            var Flights = _FlightReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.FlightCode,
                p.FlightRegion,
            }).ToList();

            return new()
            {
                Flights = Flights,
                TotalCount = totalCount
            };
        }
    }
}