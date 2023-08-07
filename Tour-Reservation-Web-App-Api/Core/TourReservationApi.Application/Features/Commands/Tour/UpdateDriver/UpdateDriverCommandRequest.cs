using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateDriver;

namespace TourReservationApi.Application.Features.Commands.Driver.UpdateDriver
{
    public class UpdateDriverCommandRequest : IRequest<UpdateDriverCommandResponse>
    {

        public string Id { get; set; }
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }
    }
}
