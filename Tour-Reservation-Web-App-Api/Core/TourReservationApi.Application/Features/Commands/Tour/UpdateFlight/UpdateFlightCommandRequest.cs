using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateFlightCommandRequest : IRequest<UpdateFlightCommandResponse>
    {
        public string Id { get; set; }
        public string FlightCode { get; set; }
        public string FlightRegion { get; set; }
    }
}
