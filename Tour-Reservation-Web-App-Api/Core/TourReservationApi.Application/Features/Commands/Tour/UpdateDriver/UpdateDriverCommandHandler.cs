using TourReservationApi.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateDriver;

namespace TourReservationApi.Application.Features.Commands.Driver.UpdateDriver
{
    public class UpdateDriverCommandHandler : IRequestHandler<UpdateDriverCommandRequest, UpdateDriverCommandResponse>
    {
        readonly IDriverReadRepository _DriverReadRepository;
        readonly IDriverWriteRepository _DriverWriteRepository;

        public UpdateDriverCommandHandler(IDriverReadRepository DriverReadRepository, IDriverWriteRepository DriverWriteRepository)
        {
            _DriverReadRepository = DriverReadRepository;
            _DriverWriteRepository = DriverWriteRepository;
        }

        public async Task<UpdateDriverCommandResponse> Handle(UpdateDriverCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Driver Driver = await _DriverReadRepository.GetByIdAsync(request.Id);
            Driver.DriverName = request.DriverName;
            Driver.DriverSurname = request.DriverSurname;
            await _DriverWriteRepository.SaveAsync();
            return new();
        }
    }
}
