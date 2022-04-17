using ASPNETCoreApp.Models;
using ASPNETCoreApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApp.Services;

public class BuildingService : IBuildingService
{
    private UniversityRoomFundDbContext _context;

    public BuildingService(UniversityRoomFundDbContext context)
    {
        _context = context;
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
        }
        else
        {
            response.Data = building;
        };

        return response;
    }

    public async Task<Response<List<Building>>> Add(AddBuildingDTO addBuildingDTO)
    {
        var response = new Response<List<Building>>();
        var newBuilding = new Building() { Name = addBuildingDTO.Name };

        var buildings = await _context.Buildings.ToListAsync();
        var building = buildings.FirstOrDefault(b => b.Name == newBuilding.Name);

        if (building != null)
        {
            response.ErrorMessage = "The building already exists";
            response.Success = false;
        }
        else
        {
            _context.Buildings?.Add(newBuilding);
            buildings.Add(newBuilding);

            response.Data = buildings;

            await _context.SaveChangesAsync();
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
        }
        else
        {
            building.Name = updateBuildingDTO.Name;
            _context.Update(building);

            await _context.SaveChangesAsync();

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
        }
        else
        {
            _context.Buildings?.Remove(building);
            buildings.Remove(building);

            response.Data = buildings;

            await _context.SaveChangesAsync();
        }


        return response;
    }
}
