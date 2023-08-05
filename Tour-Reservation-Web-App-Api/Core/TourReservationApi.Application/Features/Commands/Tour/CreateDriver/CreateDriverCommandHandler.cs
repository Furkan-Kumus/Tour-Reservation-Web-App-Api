
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.CreateDriver;
using TourReservationApi.Application.Repositories;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCreateDriver
{
    public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommandRequest, CreateDriverCommandResponse>
    {
        readonly IDriverWriteRepository _DriverWriteRepository;

        public CreateDriverCommandHandler(IDriverWriteRepository DriverWriteRepository)
        {
            _DriverWriteRepository = DriverWriteRepository;
        }

        public async Task<CreateDriverCommandResponse> Handle(CreateDriverCommandRequest request, CancellationToken cancellationToken)
        {
            await _DriverWriteRepository.AddAsync(new()
            {
                DriverName = request.DriverName,
                DriverSurname = request.DriverSurname,
            });
            await _DriverWriteRepository.SaveAsync();
            return new();

        }
    }
}