using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCountry;

namespace TourReservationApi.Application.Features.Commands.Country.UpdateCountry
{
    public class UpdateCountryCommandRequest : IRequest<UpdateCountryCommandResponse>
    {

        public string Id { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
