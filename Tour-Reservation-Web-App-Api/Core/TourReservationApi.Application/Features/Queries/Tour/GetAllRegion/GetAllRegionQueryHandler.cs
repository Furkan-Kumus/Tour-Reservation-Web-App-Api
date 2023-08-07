using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllRegion;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllRegion
{
    public class GetAllRegionQueryHandler : IRequestHandler<GetAllRegionQueryRequest, GetAllRegionQueryResponse>
    {
        readonly IRegionReadRepository _RegionReadRepository;
        public GetAllRegionQueryHandler(IRegionReadRepository RegionReadRepository)
        {
            _RegionReadRepository = RegionReadRepository;
        }
        public async Task<GetAllRegionQueryResponse> Handle(GetAllRegionQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _RegionReadRepository.GetAll(false).Count();
            var Regions = _RegionReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size).Select(p => new
            {
                p.Id,
                p.RegionCode,
                p.RegionName,
                p.RegionDistance,
            }).ToList();

            return new()
            {
                Regions = Regions,
                TotalCount = totalCount
            };
        }
    }
}