using ASPNETCoreApp.Models.DTOs;
using ASPNETCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/buildings")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {
        private IBuildingService _buildingService;
        public BuildingsController(IBuildingService buildingService)
        {
            _buildingService = buildingService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _buildingService.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _buildingService.GetById(id);
            if (response.Data == null) return NotFound(response);
            else return Ok(response);

        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddBuildingDTO addBuildingDTO)
        {
            var response = await _buildingService.Add(addBuildingDTO);
            if (response.Data == null) return BadRequest(response);
            else return Ok(response);

        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateBuildingDTO updateBuildingDTO)
        {
            var response = await _buildingService.Update(updateBuildingDTO);
            if (response.Data == null) return NotFound(response);
            else return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _buildingService.Remove(id);
            if (response == null) return NotFound(response);
            else return Ok(response);
        }
    }
}
