using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateDriver
{
    public class CreateDriverCommandRequest : IRequest<CreateDriverCommandResponse>
    {
        public string DriverName { get; set; }
        public string DriverSurname { get; set; }
    }
}
