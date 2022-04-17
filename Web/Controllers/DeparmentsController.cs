using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DeparmentsController : ControllerBase
    {
        private IDepartmentService _departmentService;

        public DeparmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddDepartmentDTO addDepartmentDTO)
        {
            var response = await _departmentService.Add(addDepartmentDTO);
            if (!response.Success) return BadRequest(response);
            else return Ok(response);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UpdateDepartmentDTO updateDepartmentDTO)
        {
            var response = await _departmentService.Update(updateDepartmentDTO);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _departmentService.Remove(id);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }
    }
}
