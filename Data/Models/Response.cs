namespace ASPNETCoreApp.Models;

public class Response<T>
{
    public bool Success { get; set; } = true;
    public string ErrorMessage { get; set; } = String.Empty;
    public T? Data { get; set; } = default;
}
