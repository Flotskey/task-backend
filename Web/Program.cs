using ASPNETCoreApp;
using ASPNETCoreApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UniversityRoomFundDbContext>();

builder.Services.AddScoped<IBuildingService, BuildingService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IFacultyService, FacultyService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();