using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TourReservationApi.Application.Abstractions;
using TourReservationApi.Persistence.Concretes;
using TourReservationApi.Persistence.Contexts;

namespace TourReservationApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly RegisterAPIDbContext _registerAPIDbContext;

        public RegistersController(RegisterAPIDbContext registerAPIDbContext)
        {
            _registerAPIDbContext = registerAPIDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetRegisters()
        {
            var registers = await _registerAPIDbContext.Registers.ToListAsync();

            return Ok(registers);
        }
    }
}
