using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApp.Services;

public class LocationService : ILocationService
{
    private UniversityRoomFundDbContext _context;

    public LocationService()
    {
        _context = new UniversityRoomFundDbContext();
    }

    public async Task<Response<List<Location>>> Add(AddLocationDTO addLocationDTO)
    {
        var response = new Response<List<Location>>();
        var building = await _context.Buildings.FindAsync(addLocationDTO.BuildingId);

        if (building == null)
        {
            response.Success = false;
            response.ErrorMessage = "This building doesn't exist";
        }
        else
        {
            var buildingLocations = await _context.Locations.Where(l => l.BuildingId == addLocationDTO.BuildingId).ToListAsync();
            var buildingLocationsCount = buildingLocations.Count;

            var location = new Location() { BuildingId = addLocationDTO.BuildingId, Floor = buildingLocationsCount + 1, CeilingHeight = addLocationDTO.CeilingHeight };

            _context.Locations.Add(location);
            buildingLocations.Add(location);

            response.Data = buildingLocations;

            await _context.SaveChangesAsync();
        }



        return response;
    }

    public async Task<Response<List<Location>>> Remove(int buildingId)
    {
        var response = new Response<List<Location>>();
        var locations = await _context.Locations.Where(l => l.BuildingId == buildingId).ToListAsync();
        var location = locations.OrderBy(l => l.Floor).LastOrDefault();

        if (location == null)
        {
            response.ErrorMessage = "This floor doesn't exist";
            response.Success = false;
        }
        else
        {
            _context.Locations.Remove(location);
            locations.Remove(location);

            response.Data = locations;

            await _context.SaveChangesAsync();
        }

        return response;
    }
}
