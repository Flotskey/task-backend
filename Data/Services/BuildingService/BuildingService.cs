using ASPNETCoreApp.Models;
using ASPNETCoreApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreApp.Services;

public class BuildingService : IBuildingService
{
    private readonly UniversityRoomFundDbContext _context;
    private readonly ILogger<Building> _logger;

    public BuildingService(UniversityRoomFundDbContext context, ILogger<Building> logger)
    {
        _context = context;
        _logger = logger;
    }


    public async Task<Response<List<Building>>> GetAll()
    {
        var buildings = await _context.Buildings
            .Include(b => b.Faculties)
            .ThenInclude(f => f.Departments)
            .Include(b => b.Locations)
            .ThenInclude(l => l.Rooms)
            .ToListAsync() ?? new List<Building>();

        return new Response<List<Building>>() { Data = buildings };
    }

    public async Task<Response<Building>> GetById(int id)
    {
        _logger.LogInformation($"Getting building {id}");
        var response = new Response<Building>();
        var building = await _context.Buildings
            .Include(b => b.Faculties)
            .ThenInclude(f => f.Departments)
            .Include(b => b.Locations)
            .ThenInclude(l => l.Rooms)
            .FirstOrDefaultAsync(b => b.Id == id);

        if (building == null)
        {
            response.ErrorMessage = "This building doesn't exist";
            response.Success = false;
            _logger.LogError($"Error getting building Id: {id} it doesn't exist");
        }
        else
        {
            response.Data = building;
            _logger.LogInformation($"Got building Id: {building.Name} Name: {building.Name}");
        };

        return response;
    }

    public async Task<Response<List<Building>>> Add(AddBuildingDTO addBuildingDTO)
    {
        var response = new Response<List<Building>>();
        var newBuilding = new Building() { Name = addBuildingDTO.Name };

        var buildings = await _context.Buildings.Include(b => b.Faculties)
            .ThenInclude(f => f.Departments)
            .Include(b => b.Locations)
            .ThenInclude(l => l.Rooms)
            .ToListAsync() ?? new List<Building>();
        var building = buildings.FirstOrDefault(b => b.Name == newBuilding.Name);

        if (building != null || addBuildingDTO.Name.Length < 4)
        {
            response.ErrorMessage = building != null ? "The building already exists" : "The building name must not be shorter than 4 characters";
            response.Success = false;
            _logger.LogError($"Error creating new building Id: {building.Id} Name: {building.Name} already exists");
        }
        else
        {
            _context.Buildings?.Add(newBuilding);
            buildings.Add(newBuilding);

            response.Data = buildings;

            await _context.SaveChangesAsync();

            _logger.LogInformation($"Added new building Id: {newBuilding.Id} Name: {newBuilding.Name}");
        }

        return response;
    }

    public async Task<Response<Building>> Update(UpdateBuildingDTO updateBuildingDTO)
    {
        var response = new Response<Building>();
        var building = await _context.Buildings.FindAsync(updateBuildingDTO.Id);
        if (building == null)
        {
            response.ErrorMessage = "This building doesn't exist";
            response.Success = false;
            _logger.LogError($"Error updating building Id: {updateBuildingDTO.Id} not found");
        }
        else
        {
            building.Name = updateBuildingDTO.Name;
            _context.Update(building);

            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated building Id: {building.Id} Name: {building.Name}");

            response.Data = building;
        }

        return response;
    }

    public async Task<Response<List<Building>>> Remove(int id)
    {
        var response = new Response<List<Building>>();
        var buildings = await _context.Buildings.ToListAsync();
        var building = buildings.FirstOrDefault(b => b.Id == id);
        if (building == null)
        {
            response.ErrorMessage = "This building doesn't exist";
            response.Success = false;
            _logger.LogError($"Error deleting building Id: {id} not found");
        }
        else
        {
            _context.Buildings?.Remove(building);
            buildings.Remove(building);

            response.Data = buildings;

            await _context.SaveChangesAsync();

            _logger.LogInformation($"Deleted building Id: {building.Id} Name: {building.Name}");
        }


        return response;
    }
}
