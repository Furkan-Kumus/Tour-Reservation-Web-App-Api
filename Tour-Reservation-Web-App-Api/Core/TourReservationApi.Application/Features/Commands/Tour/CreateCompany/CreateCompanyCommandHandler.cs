
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateFlight;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateFlight
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommandRequest, CreateCompanyCommandResponse>
    {
        readonly IProductWriteRepository _productWriteRepository;

        public CreateCompanyCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommandRequest request, CancellationToken cancellationToken)
        {
            await _productWriteRepository.AddAsync(new()
            {
                FlightCode = request.FlightCode,
                FlightRegion = request.FlightRegion,
            });
            await _productWriteRepository.SaveAsync();
            return new();
        }
    }
}