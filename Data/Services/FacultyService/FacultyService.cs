using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApp.Services;

public class FacultyService : IFacultyService
{
    private UniversityRoomFundDbContext _context;
    public FacultyService(UniversityRoomFundDbContext context)
    {
        _context = context;
    }
    public async Task<Response<List<Faculty>>> Add(AddFacultyDTO addFacultyDTO)
    {
        var response = new Response<List<Faculty>>();
        var building = await _context.Buildings.FindAsync(addFacultyDTO.BuildingId);
        var faculty = building.Faculties.FirstOrDefault(f => f.Name == addFacultyDTO.Name);

        if (building == null || faculty != null)
        {
            response.Success = false;
            if (faculty != null) response.ErrorMessage = "This faculty name has already been taken";
            else if (building != null) response.ErrorMessage = "This building doesn't exist";
        }
        else
        {

            var newFaculty = addFacultyDTO.Adapt<Faculty>();
            _context.Faculties.Add(newFaculty);
            await _context.SaveChangesAsync();

            response.Data = building.Faculties.ToList();
        }



        return response;
    }

    public async Task<Response<Faculty>> Update(UpdateFacultyDTO updateFacultyDTO)
    {
        var response = new Response<Faculty>();
        var faculty = await _context.Faculties.AsNoTracking().FirstOrDefaultAsync(f => f.Id == updateFacultyDTO.Id);

        if (faculty == null)
        {
            response.Success = false;
            response.ErrorMessage = "This faculty doesn't exist";
        }
        else
        {
            var newFaculty = updateFacultyDTO.Adapt<Faculty>();
            newFaculty.BuildingId = faculty.BuildingId;

            _context.Faculties.Update(newFaculty);
            await _context.SaveChangesAsync();

            response.Data = newFaculty;
        }

        return response;
    }

    public async Task<Response<List<Faculty>>> Remove(int id)
    {
        var response = new Response<List<Faculty>>();
        var faculty = await _context.Faculties.FindAsync(id);
        if (faculty == null)
        {
            response.Success = false;
            response.ErrorMessage = "This faculty doesn't exist";
        }
        else
        {
            _context.Faculties.Remove(faculty);
            await _context.SaveChangesAsync();

            var faculties = await _context.Faculties.Where(f => f.BuildingId == faculty.BuildingId).ToListAsync();

            response.Data = faculties;
        }

        return response;
    }
}
