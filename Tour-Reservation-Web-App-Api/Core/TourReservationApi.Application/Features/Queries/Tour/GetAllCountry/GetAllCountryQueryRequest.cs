using TourReservationApi.Application.RequestParameters;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Application.Features.Queries.Tour.GetAllCountry;

namespace TourReservationApi.Application.Features.Queries.Tour.GetAllCountry
{
    public class GetAllCountryQueryRequest : IRequest<GetAllCountryQueryResponse>
    {
        //public Pagination Pagination { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}