
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateRegion;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateRegion
{
    public class CreateRegionCommandHandler : IRequestHandler<CreateRegionCommandRequest, CreateRegionCommandResponse>
    {
        readonly IRegionWriteRepository _RegionWriteRepository;

        public CreateRegionCommandHandler(IRegionWriteRepository RegionWriteRepository)
        {
            _RegionWriteRepository = RegionWriteRepository;
        }

        public async Task<CreateRegionCommandResponse> Handle(CreateRegionCommandRequest request, CancellationToken cancellationToken)
        {
            await _RegionWriteRepository.AddAsync(new()
            {
                RegionCode = request.RegionCode,
                RegionName = request.RegionName,
                RegionDistance = request.RegionDistance,
            });
            await _RegionWriteRepository.SaveAsync();
            return new();

           

    }
    }
}