using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveRegion;
using TourReservationApi.Application.Features.Commands.Tour.RemoveRegion;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveRegion
{
    public class RemoveRegionCommandHandler : IRequestHandler<RemoveRegionCommandRequest, RemoveRegionCommandResponse>
    {
        readonly IRegionWriteRepository _RegionWriteRepository;

        public RemoveRegionCommandHandler(IRegionWriteRepository RegionWriteRepository)
        {
            _RegionWriteRepository = RegionWriteRepository;
        }

        public async Task<RemoveRegionCommandResponse> Handle(RemoveRegionCommandRequest request, CancellationToken cancellationToken)
        {
            await _RegionWriteRepository.RemoveAsync(request.Id);
            await _RegionWriteRepository.SaveAsync();
            return new();
        }
    }
}
