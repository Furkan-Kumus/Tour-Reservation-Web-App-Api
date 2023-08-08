using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCity;

namespace TourReservationApi.Application.Features.Commands.City.UpdateCity
{
    public class UpdateCityCommandRequest : IRequest<UpdateCityCommandResponse>
    {

        public string Id { get; set; }
        public string CityCountry { get; set; }
        public string CityName { get; set; }
        public int CityDistance { get; set; }
    }
}
