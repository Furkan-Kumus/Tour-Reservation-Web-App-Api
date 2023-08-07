using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.RemoveDriver;
using TourReservationApi.Application.Features.Commands.Tour.RemoveDriver;

namespace TourReservationApi.Application.Features.Commands.Tour.RemoveDriver
{
    public class RemoveDriverCommandHandler : IRequestHandler<RemoveDriverCommandRequest, RemoveDriverCommandResponse>
    {
        readonly IDriverWriteRepository _DriverWriteRepository;

        public RemoveDriverCommandHandler(IDriverWriteRepository DriverWriteRepository)
        {
            _DriverWriteRepository = DriverWriteRepository;
        }

        public async Task<RemoveDriverCommandResponse> Handle(RemoveDriverCommandRequest request, CancellationToken cancellationToken)
        {
            await _DriverWriteRepository.RemoveAsync(request.Id);
            await _DriverWriteRepository.SaveAsync();
            return new();
        }
    }
}
