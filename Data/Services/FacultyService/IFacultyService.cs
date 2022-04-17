using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;

namespace ASPNETCoreApp.Services;

public interface IFacultyService
{
    Task<Response<List<Faculty>>> Add(AddFacultyDTO addFacultyDTO);
    Task<Response<Faculty>> Update(UpdateFacultyDTO updateFacultyDTO);
    Task<Response<List<Faculty>>> Remove(int buildingId);
}
