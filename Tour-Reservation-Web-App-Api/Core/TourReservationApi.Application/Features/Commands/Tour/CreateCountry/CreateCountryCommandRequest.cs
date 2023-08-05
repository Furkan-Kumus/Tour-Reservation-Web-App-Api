using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateCountry
{
    public class CreateCountryCommandRequest : IRequest<CreateCountryCommandResponse>
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }

    }
}
