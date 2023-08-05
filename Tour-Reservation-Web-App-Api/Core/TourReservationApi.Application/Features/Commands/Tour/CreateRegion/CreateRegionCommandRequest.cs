using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Tour.CreateRegion
{
    public class CreateRegionCommandRequest : IRequest<CreateRegionCommandResponse>
    {
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public int RegionDistance { get; set; }
    }
}
