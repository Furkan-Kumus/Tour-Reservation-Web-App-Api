using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllCountry;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllCountry
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQueryRequest, GetAllCountryQueryResponse>
    {
        readonly ICountryReadRepository _CountryReadRepository;
        public GetAllCountryQueryHandler(ICountryReadRepository CountryReadRepository)
        {
            _CountryReadRepository = CountryReadRepository;
        }
        public async Task<GetAllCountryQueryResponse> Handle(GetAllCountryQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _CountryReadRepository.GetAll(false).Count();
            var Countrys = _CountryReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.CountryCode,
                p.CountryName,
            }).ToList();

            return new()
            {
                Countrys = Countrys,
                TotalCount = totalCount
            };
        }
    }
}