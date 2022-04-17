using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/faculties")]
    [ApiController]
    public class FacultiesController : ControllerBase
    {
        private IFacultyService _facultyService;
        public FacultiesController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddFacultyDTO addFacultyDTO)
        {
            var response = await _facultyService.Add(addFacultyDTO);
            if (!response.Success) return BadRequest(response);
            else return Ok(response);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateFacultyDTO updateFacultyDTO)
        {
            var response = await _facultyService.Update(updateFacultyDTO);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _facultyService.Remove(id);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }
    }
}
