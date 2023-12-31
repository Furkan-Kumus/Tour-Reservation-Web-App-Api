﻿using TourReservationApi.Application.Features.Commands.AppUser.LoginUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TourReservationApi.Application.Features.Commands.AppUser.CreateUser;
using System.Net;
using TourReservationApi.Application.Features.Commands.Tour.CreateFlight;
using TourReservationApi.Application.Features.Commands.Tour.CreateVehicle;
using TourReservationApi.Application.Features.Commands.Tour.CreateRegion;
using TourReservationApi.Application.Features.Commands.Tour.CreateCountry;
using TourReservationApi.Application.Features.Commands.Tour.CreateAirport;
using TourReservationApi.Application.Features.Commands.Tour.CreateDriver;
using TourReservationApi.Application.Features.Queries.Product.GetAllProduct;
using TourReservationApi.Application.Features.Queries.Tour.GetAllFlight;
using TourReservationApi.Application.Features.Queries.Tour.GetAllVehicle;
using TourReservationApi.Application.Features.Queries.Tour.GetAllAirport;
using TourReservationApi.Application.Features.Queries.Tour.GetAllCountry;
using TourReservationApi.Application.Features.Queries.Tour.GetAllDriver;
using TourReservationApi.Application.Features.Queries.Tour.GetAllRegion;
using TourReservationApi.Application.Features.Commands.Tour.RemoveVehicle;
using TourReservationApi.Application.Features.Commands.Tour.RemoveFlight;
using TourReservationApi.Application.Features.Commands.Tour.RemoveRegion;
using TourReservationApi.Application.Features.Commands.Tour.RemoveAirport;
using TourReservationApi.Application.Features.Commands.Tour.RemoveDriver;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCountry;
using TourReservationApi.Application.Features.Commands.Vehicle.UpdateVehicle;
using TourReservationApi.Application.Features.Commands.Region.UpdateRegion;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCountry;
using TourReservationApi.Application.Features.Commands.Country.UpdateCountry;
using TourReservationApi.Application.Features.Commands.Airport.UpdateAirport;
using TourReservationApi.Application.Features.Commands.Tour.UpdateAirport;
using TourReservationApi.Application.Features.Commands.Driver.UpdateDriver;
using TourReservationApi.Application.Features.Commands.Tour.UpdateDriver;
using ETicaretAPI.Application.Features.Commands.Product.UpdateProduct;
using TourReservationApi.Application.Features.Commands.Tour.CreateCity;
using TourReservationApi.Application.Features.Commands.Tour.RemoveCity;
using TourReservationApi.Application.Features.Commands.Tour.UpdateCity;
using TourReservationApi.Application.Features.Commands.City.UpdateCity;
using TourReservationApi.Application.Features.Queries.Tour.GetAllCity;

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
        [HttpGet("Flight")]
        public async Task<IActionResult> Get([FromQuery] GetAllFlightQueryRequest getAllProductQueryRequest)
        {
            GetAllFlightQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("Flight")]
        public async Task<IActionResult> Post(CreateFlightCommandRequest createProductCommandRequest)
        {
            CreateFlightCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("Flight/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveFlightCommandRequest removeProductCommandRequest)
        {
            RemoveFlightCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
        [HttpPut("Flight/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateFlightCommandRequest updateProductCommandRequest)
        {
            UpdateFlightCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }
        //Repostoris ve I repostroisteki Write Readler 
        //TourElementsController
        //Handler response request  Handler a strinlger aktar
        //service registiration and import
        //entities
        //registerapidbcontents e ekle

        [HttpGet("Vehicle")]
        public async Task<IActionResult> Get([FromQuery] GetAllVehicleQueryRequest getAllProductQueryRequest)
        {
            GetAllVehicleQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("Vehicle")]

        public async Task<IActionResult> Post(CreateVehicleCommandRequest createProductCommandRequest)
        {
            CreateVehicleCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("Vehicle/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveVehicleCommandRequest removeProductCommandRequest)
        {
            RemoveVehicleCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPut("Vehicle/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateVehicleCommandRequest updateProductCommandRequest)
        {
            UpdateVehicleCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }









        
        [HttpGet("City")]
        public async Task<IActionResult> Get([FromQuery] GetAllCityQueryRequest getAllProductQueryRequest)
        {
            GetAllCityQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("City")]

        public async Task<IActionResult> Post(CreateCityCommandRequest createProductCommandRequest)
        {
            CreateCityCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("City/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCityCommandRequest removeProductCommandRequest)
        {
           RemoveCityCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPut("City/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateCityCommandRequest updateProductCommandRequest)
        {
            UpdateCityCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }














        [HttpGet("Region")]
        public async Task<IActionResult> Get([FromQuery] GetAllRegionQueryRequest getAllProductQueryRequest)
        {
            GetAllRegionQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        
        [HttpPost("Region")]

        public async Task<IActionResult> Post(CreateRegionCommandRequest createProductCommandRequest)
        {
            CreateRegionCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("Region/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveRegionCommandRequest removeProductCommandRequest)
        {
            RemoveRegionCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
        [HttpPut("Region/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateRegionCommandRequest updateProductCommandRequest)
        {
            UpdateRegionCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }
        [HttpGet("Country")]
        public async Task<IActionResult> Get([FromQuery] GetAllCountryQueryRequest getAllProductQueryRequest)
        {
            GetAllCountryQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("Country")]

        public async Task<IActionResult> Post(CreateCountryCommandRequest createProductCommandRequest)
        {
            CreateCountryCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("Country/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCountryCommandRequest removeProductCommandRequest)
        {
            RemoveCountryCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
        [HttpPut("Country/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateCountryCommandRequest updateProductCommandRequest)
        {
            UpdateCountryCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }
        [HttpGet("Airport")]
        public async Task<IActionResult> Get([FromQuery] GetAllAirportQueryRequest getAllProductQueryRequest)
        {
            GetAllAirportQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("Airport")]

        public async Task<IActionResult> Post(CreateAirportCommandRequest createProductCommandRequest)
        {
            CreateAirportCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("Airport/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAirportCommandRequest removeProductCommandRequest)
        {
            RemoveAirportCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
        [HttpPut("Airport/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateAirportCommandRequest updateProductCommandRequest)
        {
            UpdateAirportCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }
        [HttpGet("Driver")]
        public async Task<IActionResult> Get([FromQuery] GetAllDriverQueryRequest getAllProductQueryRequest)
        {
            GetAllDriverQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }
        [HttpPost("Driver")]

        public async Task<IActionResult> Post(CreateDriverCommandRequest createProductCommandRequest)
        {
            CreateDriverCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }
        [HttpDelete("Driver/{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveDriverCommandRequest removeProductCommandRequest)
        {
            RemoveDriverCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
        [HttpPut("Driver/{Id}")]
        public async Task<IActionResult> Put([FromBody] UpdateDriverCommandRequest updateProductCommandRequest)
        {
            UpdateDriverCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }


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
