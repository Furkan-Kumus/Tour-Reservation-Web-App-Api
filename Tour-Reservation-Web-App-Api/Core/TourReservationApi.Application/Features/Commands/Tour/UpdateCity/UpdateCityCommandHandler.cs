using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCity;

namespace TourReservationApi.Application.Features.Commands.City.UpdateCity
{
    public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommandRequest, UpdateCityCommandResponse>
    {
        readonly ICityReadRepository _CityReadRepository;
        readonly ICityWriteRepository _CityWriteRepository;

        public UpdateCityCommandHandler(ICityReadRepository CityReadRepository, ICityWriteRepository CityWriteRepository)
        {
            _CityReadRepository = CityReadRepository;
            _CityWriteRepository = CityWriteRepository;
        }

        public async Task<UpdateCityCommandResponse> Handle(UpdateCityCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.City City = await _CityReadRepository.GetByIdAsync(request.Id);
            City.CityCountry = request.CityCountry;
            City.CityName = request.CityName;
            City.CityDistance = request.CityDistance;
            await _CityWriteRepository.SaveAsync();


            return new ();
        }
    }
}
