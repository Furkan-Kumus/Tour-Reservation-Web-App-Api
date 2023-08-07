using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Repositories;
using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;

using TourReservationApi.Application.Features.Commands.Product.UpdateProduct;

namespace TourReservationApi.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateFlightCommandHandler : IRequestHandler<UpdateFlightCommandRequest, UpdateFlightCommandResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        readonly IProductWriteRepository _productWriteRepository;

        public UpdateFlightCommandHandler(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<UpdateFlightCommandResponse> Handle(UpdateFlightCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Flight product = await _productReadRepository.GetByIdAsync(request.Id);
            product.FlightCode = request.FlightCode;
            product.FlightRegion = request.FlightRegion;
            await _productWriteRepository.SaveAsync();
            return new();
        }
    }
}
