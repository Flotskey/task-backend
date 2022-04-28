using ASPNETCoreApp.DTOs;
using ASPNETCoreApp.Models;

namespace ASPNETCoreApp.Services;

public interface ILocationService
{
    Task<Response<List<Location>>> Add(AddLocationDTO addLocationDTO);
    Task<Response<List<Location>>> Remove(int id);
}
