using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using ASPNETCoreApp.Services;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/locations")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] AddLocationDTO addLocationDTO)
        {
            var response = await _locationService.Add(addLocationDTO);
            if (response.Success) return Ok(response);
            else return BadRequest(response);
        }

        [HttpDelete("delete/{buildingId}")]
        public async Task<IActionResult> Remove([FromRoute] int buildingId)
        {
            var response = await _locationService.Remove(buildingId);
            if (response.Success) return Ok(response);
            else return NotFound(response);
        }
    }
}
