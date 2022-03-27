using EFCoreConsoleApp;
using EFCoreConsoleApp.Models;

using var db = new UniversityRoomFundDbContext();

var rooms = db.Rooms.ToList();

db.Rooms.Add(new Room()
{
    BuildingId = 1,
    FacultyId = 1,
    DepartmentId = 2,
    Number = 666,
    Length = 13.5,
    Width = 28,
    Location = "3rd floor",
    Purpose = "Learn C#",
    Type = "Normal",
    CeilingHeight = 2.5
});

db.Rooms.Add(new Room()
{
    BuildingId = 1,
    FacultyId = 1,
    DepartmentId = 1,
    Number = 777,
    Length = 13.5,
    Width = 28,
    Location = "2nd floor",
    Purpose = "Learn EF Core",
    Type = "Normal",
    CeilingHeight = 2.5
});

db.Rooms.Add(new Room()
{
    BuildingId = 1,
    FacultyId = 1,
    DepartmentId = 1,
    Number = 111,
    Length = 13.5,
    Width = 28,
    Location = "1st floor",
    Purpose = "Learn EF Core",
    Type = "Unusual",
    CeilingHeight = 2.5
});

db.SaveChanges();

var room = db.Rooms.First(room => room.Id == 2);

db.Rooms.Remove(room);
db.SaveChanges();

var room404 = db.Rooms.First(room => room.Id == 1);

room404.Number = 505;

db.Rooms.Update(room404);
db.SaveChanges();

db.Rooms.ToList().ForEach((r) =>
{
    Console.WriteLine($"Id = {r.Id}, Number = {r.Number}, BuildingId = {r.BuildingId} FacultyId = {r.FacultyId}");
});

