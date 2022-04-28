using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreApp.Services;

public class RoomService : IRoomService
{

    private readonly UniversityRoomFundDbContext _context;
    private readonly ILogger<Room> _logger;
    public RoomService(UniversityRoomFundDbContext context, ILogger<Room> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<Response<List<Room>>> Get(int locationId)
    {
        var response = new Response<List<Room>>();
        var rooms = await _context.Rooms.Where(r => r.LocationId == locationId).ToListAsync();
        response.Data = rooms;
        return response;
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
            _logger.LogError($"Error adding new room Id: {room.Id} Number: {room.Number} already");
        }
        else
        {
            var newRoom = addRoomDTO.Adapt<Room>();
            _context.Rooms.Add(newRoom);
            rooms.Add(newRoom);

            await _context.SaveChangesAsync();

            _logger.LogInformation($"Added new room Id: {newRoom.Id} Number: {newRoom.Number}");

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
            _logger.LogError($"Error updating room Id: {room.Id} Number: {room.Number} not found");
        }
        else
        {
            var newRoom = updateRoomDTO.Adapt<Room>();
            newRoom.LocationId = room.LocationId;

            _context.Rooms.Update(newRoom);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated new room Id: {newRoom.Id} Number: {newRoom.Number}");

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
            _logger.LogError($"Error deleting room Id: {room.Id} Number: {room.Number} not found");
        }
        else
        {
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted room Id: {room.Id} Number: {room.Number}");

            response.Data = location.Rooms.ToList();
        }

        return response;
    }
}
