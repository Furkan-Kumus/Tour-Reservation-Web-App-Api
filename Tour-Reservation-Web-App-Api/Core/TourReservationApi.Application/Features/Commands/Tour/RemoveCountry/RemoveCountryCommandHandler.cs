using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCountry;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCountry;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveCountry
{
    public class RemoveCountryCommandHandler : IRequestHandler<RemoveCountryCommandRequest, RemoveCountryCommandResponse>
    {
        readonly ICountryWriteRepository _CountryWriteRepository;

        public RemoveCountryCommandHandler(ICountryWriteRepository CountryWriteRepository)
        {
            _CountryWriteRepository = CountryWriteRepository;
        }

        public async Task<RemoveCountryCommandResponse> Handle(RemoveCountryCommandRequest request, CancellationToken cancellationToken)
        {
            await _CountryWriteRepository.RemoveAsync(request.Id);
            await _CountryWriteRepository.SaveAsync();
            return new();
        }
    }
}
