using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.Controllers
{
    [Route("api/rooms")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private IRoomService _roomService;
        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddRoomDTO addRoomDTO)
        {
            var response = await _roomService.Add(addRoomDTO);
            if (!response.Success) return BadRequest(response);
            else return Ok(response);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(UpdateRoomDTO updateRoomDTO)
        {
            var response = await _roomService.Update(updateRoomDTO);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var response = await _roomService.Remove(id);
            if (!response.Success) return NotFound(response);
            else return Ok(response);
        }
    }
}
