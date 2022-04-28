using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;

namespace ASPNETCoreApp.Services;

public interface IRoomService
{
    Task<Response<List<Room>>> Get(int locationId);
    Task<Response<List<Room>>> Add(AddRoomDTO addRoomDTO);
    Task<Response<Room>> Update(UpdateRoomDTO updateRoomDTO);
    Task<Response<List<Room>>> Remove(int id);
}
