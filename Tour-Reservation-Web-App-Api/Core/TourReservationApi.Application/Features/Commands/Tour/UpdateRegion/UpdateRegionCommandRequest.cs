using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourReservationApi.Application.Features.Commands.Region.UpdateRegion
{
    public class UpdateRegionCommandRequest : IRequest<UpdateRegionCommandResponse>
    {

        public string Id { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public int RegionDistance { get; set; }

    }
}
