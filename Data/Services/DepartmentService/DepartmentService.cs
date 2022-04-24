using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ASPNETCoreApp.Services;

public class DepartmentService : IDepartmentService
{
    private readonly UniversityRoomFundDbContext _context;
    private readonly ILogger<Department> _logger;
    public DepartmentService(UniversityRoomFundDbContext context, ILogger<Department> logger)
    {
        _context = context;
        _logger = logger;
    }
    public async Task<Response<List<Department>>> Add(AddDepartmentDTO addDepartmentDTO)
    {
        var response = new Response<List<Department>>();
        var faculty = await _context.Faculties.Include(f => f.Departments).FirstOrDefaultAsync(f => f.Id == addDepartmentDTO.FacultyId);
        var department = faculty.Departments.FirstOrDefault(d => d.Name == addDepartmentDTO.Name);
        if (faculty == null || department != null)
        {
            response.Success = false;
            if (faculty == null)
            {
                response.ErrorMessage = "This faculty doesn't exist";
                _logger.LogError($"Error adding department Id: {addDepartmentDTO.Name} FacultyId: {addDepartmentDTO.FacultyId} faculty not found");
            }
            else if (department != null)
            {
                response.ErrorMessage = "This deparment's name is already taken";
                _logger.LogError($"Error adding department Id: {addDepartmentDTO.Name} FacultyId: {addDepartmentDTO.FacultyId} department's name already taken");
            }
        }
        else
        {
            var newFaculty = await _context.Faculties.Include(f => f.Departments).FirstOrDefaultAsync(f => f.Id == addDepartmentDTO.FacultyId);
            var newDepartment = addDepartmentDTO.Adapt<Department>();

            _context.Departments.Add(newDepartment);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Added department Id: {newDepartment.Id} Name: {newDepartment.Name} FacultyId: {newDepartment.FacultyId}");

            response.Data = newFaculty.Departments.ToList();
        }

        return response;
    }

    public async Task<Response<Department>> Update(UpdateDepartmentDTO updateDepartmentDTO)
    {
        var response = new Response<Department>();
        var department = await _context.Departments.AsNoTracking().FirstOrDefaultAsync(d => d.Id == updateDepartmentDTO.Id);
        if (department == null)
        {
            response.Success = false;
            response.ErrorMessage = "This department doesn't exist";
            _logger.LogError($"Error updating department Id: {department.Name} FacultyId: {department.FacultyId} not found");
        }
        else
        {
            var newDepartment = updateDepartmentDTO.Adapt<Department>();
            newDepartment.FacultyId = department.FacultyId;

            _context.Departments.Update(newDepartment);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Updated department Id: {newDepartment.Id} Name: {newDepartment.Name} FacultyId: {newDepartment.FacultyId}");

            response.Data = newDepartment;
        }

        return response;

    }

    public async Task<Response<List<Department>>> Remove(int id)
    {
        var response = new Response<List<Department>>();
        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            response.Success = false;
            response.ErrorMessage = "This department doesn't exist";
            _logger.LogError($"Error deleting department Id: {department.Name} FacultyId: {department.FacultyId} not found");
        }
        else
        {
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            _logger.LogInformation($"Removed department Id: {department.Id} Name: {department.Name} FacultyId: {department.FacultyId}");

            var faculty = await _context.Faculties.Include(f => f.Departments).FirstOrDefaultAsync(f => f.Id == department.FacultyId);
            response.Data = faculty.Departments.ToList();
        }

        return response;
    }
}
