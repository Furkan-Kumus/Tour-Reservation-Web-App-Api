using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCity;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCity;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveCity
{
    public class RemoveCityCommandHandler : IRequestHandler<RemoveCityCommandRequest, RemoveCityCommandResponse>
    {
        readonly ICityWriteRepository _CityWriteRepository;

        public RemoveCityCommandHandler(ICityWriteRepository CityWriteRepository)
        {
            _CityWriteRepository = CityWriteRepository;
        }

        public async Task<RemoveCityCommandResponse> Handle(RemoveCityCommandRequest request, CancellationToken cancellationToken)
        {
            await _CityWriteRepository.RemoveAsync(request.Id);
            await _CityWriteRepository.SaveAsync();
            return new();
        }
    }
}
