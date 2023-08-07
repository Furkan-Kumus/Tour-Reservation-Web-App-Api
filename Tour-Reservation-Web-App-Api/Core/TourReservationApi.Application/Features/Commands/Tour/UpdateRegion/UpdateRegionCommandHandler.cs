using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Region.UpdateRegion
{
    public class UpdateRegionCommandHandler : IRequestHandler<UpdateRegionCommandRequest, UpdateRegionCommandResponse>
    {
        readonly IRegionReadRepository _RegionReadRepository;
        readonly IRegionWriteRepository _RegionWriteRepository;

        public UpdateRegionCommandHandler(IRegionReadRepository RegionReadRepository, IRegionWriteRepository RegionWriteRepository)
        {
            _RegionReadRepository = RegionReadRepository;
            _RegionWriteRepository = RegionWriteRepository;
        }

        public async Task<UpdateRegionCommandResponse> Handle(UpdateRegionCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Region Region = await _RegionReadRepository.GetByIdAsync(request.Id);
            Region.RegionDistance = request.RegionDistance;
            Region.RegionCode = request.RegionCode;
            Region.RegionName = request.RegionName;
            await _RegionWriteRepository.SaveAsync();
            return new();
        }
    }
}
