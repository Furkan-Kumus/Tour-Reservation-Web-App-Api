using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCountry;

namespace TourReservationApi.Application.Features.Commands.Country.UpdateCountry
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommandRequest, UpdateCountryCommandResponse>
    {
        readonly ICountryReadRepository _CountryReadRepository;
        readonly ICountryWriteRepository _CountryWriteRepository;

        public UpdateCountryCommandHandler(ICountryReadRepository CountryReadRepository, ICountryWriteRepository CountryWriteRepository)
        {
            _CountryReadRepository = CountryReadRepository;
            _CountryWriteRepository = CountryWriteRepository;
        }

        public async Task<UpdateCountryCommandResponse> Handle(UpdateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Country Country = await _CountryReadRepository.GetByIdAsync(request.Id);
            Country.CountryCode = request.CountryCode;
            Country.CountryName = request.CountryName;
            await _CountryWriteRepository.SaveAsync();
            return new();
        }
    }
}
