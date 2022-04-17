using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApp.Services;

public class RoomService : IRoomService
{

    private UniversityRoomFundDbContext _context;

    public RoomService(UniversityRoomFundDbContext context)
    {
        _context = context;
    }
    public async Task<Response<List<Room>>> Add(AddRoomDTO addRoomDTO)
    {
        var response = new Response<List<Room>>();
        var location = await _context.Locations.FindAsync(addRoomDTO.LocationId);
        var rooms = location.Rooms.ToList();
        var room = rooms.FirstOrDefault(r => r.Number == addRoomDTO.Number);

        if (room != null)
        {
            response.Success = false;
            response.ErrorMessage = "This room number is already taken";
        }
        else
        {
            var newRoom = addRoomDTO.Adapt<Room>();
            _context.Rooms.Add(newRoom);
            rooms.Add(newRoom);

            await _context.SaveChangesAsync();

            response.Data = rooms;
        }

        return response;
    }

    public async Task<Response<Room>> Update(UpdateRoomDTO updateRoomDTO)
    {
        var response = new Response<Room>();
        var room = await _context.Rooms.AsNoTracking().FirstOrDefaultAsync(r => r.Id == updateRoomDTO.Id);
        if (room == null)
        {
            response.Success = false;
            response.ErrorMessage = "This room doesn't exist";
        }
        else
        {
            var newRoom = updateRoomDTO.Adapt<Room>();
            newRoom.LocationId = room.LocationId;

            _context.Rooms.Update(newRoom);
            await _context.SaveChangesAsync();

            response.Data = newRoom;
        }

        return response;
    }

    public async Task<Response<List<Room>>> Remove(int id)
    {
        var response = new Response<List<Room>>();
        var room = await _context.Rooms.FirstOrDefaultAsync(r => r.Id == id);
        var location = await _context.Locations.FindAsync(room.LocationId);
        if (room == null)
        {
            response.Success = false;
            response.ErrorMessage = "This room doesn't exist";
        }
        else
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            response.Data = location.Rooms.ToList();
        }

        return response;
    }
}
