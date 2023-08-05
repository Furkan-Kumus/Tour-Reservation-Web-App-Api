
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
    public class CreateTourCommandHandler : IRequestHandler<CreateTourCommandRequest, CreateTourCommandResponse>
    {
        readonly IProductWriteRepository _productWriteRepository;

        public CreateTourCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public async Task<CreateTourCommandResponse> Handle(CreateTourCommandRequest request, CancellationToken cancellationToken)
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