
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateCity;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateCity
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommandRequest, CreateCityCommandResponse>
    {
        readonly ICityWriteRepository _CityWriteRepository;

        public CreateCityCommandHandler(ICityWriteRepository CityWriteRepository)
        {
            _CityWriteRepository = CityWriteRepository;
        }

        public async Task<CreateCityCommandResponse> Handle(CreateCityCommandRequest request, CancellationToken cancellationToken)
        {
            await _CityWriteRepository.AddAsync(new()
            {
                CityCountry = request.CityCountry,
                CityName = request.CityName,
                CityDistance = request.CityDistance,
            });
            await _CityWriteRepository.SaveAsync();
            return new();

        }
    }
}