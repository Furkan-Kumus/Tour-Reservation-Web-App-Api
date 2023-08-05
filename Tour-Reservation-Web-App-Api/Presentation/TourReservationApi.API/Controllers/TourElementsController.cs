using TourReservationApi.Application.Features.Commands.AppUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourReservationApi.Application.Features.Commands.AppUser.CreateUser;
using System.Net;
using TourReservationApi.Application.Features.Commands.Tour.CreateFlight;
using TourReservationApi.Application.Features.Commands.Tour.CreateVehicle;
using TourReservationApi.Application.Features.Commands.Tour.CreateRegion;
namespace TourReservationApi.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TourElementsController : ControllerBase
    {
        readonly IMediator _mediator;

        public TourElementsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        //{
        //    GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
        //    return Ok(response);
        //}

        //[HttpGet("{Id}")]
        //public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        //{
        //    GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
        //    return Ok(response);
        //}

        [HttpPost("Flight")]
        public async Task<IActionResult> Post(CreateFlightCommandRequest createProductCommandRequest)
        {
            CreateFlightCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        //Repostoris ve I repostroisteki Write Readler 
        //TourElementsController
        //Handler response request  Handler a strinlger aktar
        //service registiration and import
        //entities
        //registerapidbcontents e ekle


        [HttpPost("Vehicle")]

        public async Task<IActionResult> Post(CreateVehicleCommandRequest createProductCommandRequest)
        {
            CreateVehicleCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPost("Region")]

        public async Task<IActionResult> Post(CreateRegionCommandRequest createProductCommandRequest)
        {
            CreateRegionCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        //[HttpPut]
        //public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        //{
        //    UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
        //    return Ok();
        //}

        //[HttpDelete("{Id}")]
        //public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        //{
        //    RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
        //    return Ok();
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest uploadProductImageCommandRequest)
        //{
        //    uploadProductImageCommandRequest.Files = Request.Form.Files;
        //    UploadProductImageCommandResponse response = await _mediator.Send(uploadProductImageCommandRequest);
        //    return Ok();
        //}

        //[HttpGet("[action]/{id}")]
        //public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest getProductImagesQueryRequest)
        //{
        //    List<GetProductImagesQueryResponse> response = await _mediator.Send(getProductImagesQueryRequest);
        //    return Ok(response);
        //}

        //[HttpDelete("[action]/{id}")]
        //public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest removeProductImageCommandRequest, [FromQuery] string imageId)
        //{
        //    //Ders sonrası not !
        //    //Burada RemoveProductImageCommandRequest sınıfı içerisindeki ImageId property'sini de 'FromQuery' attribute'u ile işaretleyebilirdik!

        //    removeProductImageCommandRequest.ImageId = imageId;
        //    RemoveProductImageCommandResponse response = await _mediator.Send(removeProductImageCommandRequest);
        //    return Ok();
        //}

    }
}
