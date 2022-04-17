using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;

namespace ASPNETCoreApp.Services;

public interface IDepartmentService
{
    Task<Response<List<Department>>> Add(AddDepartmentDTO addDepartmentDTO);
    Task<Response<Department>> Update(UpdateDepartmentDTO updateDepartmentDTO);
    Task<Response<List<Department>>> Remove(int id);
}
