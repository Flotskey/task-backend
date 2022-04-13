using ASPNETCoreApp.Models;
using ASPNETCoreApp.Models.DTOs;

namespace ASPNETCoreApp.Services;

public interface IBuildingService
{
    Task<Response<List<Building>>> GetAll();
    Task<Response<Building>> GetById(int id);
    Task<Response<List<Building>>> Add(AddBuildingDTO addBuildingDTO);
    Task<Response<Building>> Update(UpdateBuildingDTO updateBuildingDTO);
    Task<Response<List<Building>>> Remove(int id);


}
