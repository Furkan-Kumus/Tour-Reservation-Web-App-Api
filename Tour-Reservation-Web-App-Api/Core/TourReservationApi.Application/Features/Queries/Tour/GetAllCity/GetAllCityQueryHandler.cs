using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllCity;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllCity
{
    public class GetAllCityQueryHandler : IRequestHandler<GetAllCityQueryRequest, GetAllCityQueryResponse>
    {
        readonly ICityReadRepository _CityReadRepository;
        public GetAllCityQueryHandler(ICityReadRepository CityReadRepository)
        {
            _CityReadRepository = CityReadRepository;
        }
        public async Task<GetAllCityQueryResponse> Handle(GetAllCityQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _CityReadRepository.GetAll(false).Count();
            var Citys = _CityReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.CityCountry,
                p.CityName,
                p.CityDistance,
            }).ToList();

            return new()
            {
                Citys = Citys,
                TotalCount = totalCount
            };
        }
    }
}