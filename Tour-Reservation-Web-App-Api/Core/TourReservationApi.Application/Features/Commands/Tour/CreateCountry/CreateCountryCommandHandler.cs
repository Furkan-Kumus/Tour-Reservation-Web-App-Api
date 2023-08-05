
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateCountry;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateCountry
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommandRequest, CreateCountryCommandResponse>
    {
        readonly ICountryWriteRepository _CountryWriteRepository;

        public CreateCountryCommandHandler(ICountryWriteRepository CountryWriteRepository)
        {
            _CountryWriteRepository = CountryWriteRepository;
        }

        public async Task<CreateCountryCommandResponse> Handle(CreateCountryCommandRequest request, CancellationToken cancellationToken)
        {
            await _CountryWriteRepository.AddAsync(new()
            {
                CountryCode = request.CountryCode,
                CountryName = request.CountryName,
            });
            await _CountryWriteRepository.SaveAsync();
            return new();

        }
    }
}