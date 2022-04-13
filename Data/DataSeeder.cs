using ASPNETCoreApp.Enums;
using ASPNETCoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreApp;

public class DataSeeder
{
    public DataSeeder(ModelBuilder builder)
    {

        builder.Entity<Building>().HasData(
            new Building() { Id = 1, Name = "2-й учебный корпус" },
            new Building() { Id = 2, Name = "4-й учебный корпус" }
            );

        builder.Entity<Location>().HasData(

            new Location() { Id = 1, BuildingId = 1, CeilingHeight = 3.5, Floor = 1 },
            new Location() { Id = 2, BuildingId = 1, CeilingHeight = 3, Floor = 2 },
            new Location() { Id = 3, BuildingId = 1, CeilingHeight = 3, Floor = 3 },

            new Location() { Id = 4, BuildingId = 2, CeilingHeight = 3, Floor = 1 },
            new Location() { Id = 5, BuildingId = 2, CeilingHeight = 3, Floor = 2 }
            );


        builder.Entity<Faculty>().HasData(
            new Faculty() { Id = 1, BuildingId = 1, Name = "Факультет вычислительной математики и кибернетики" },
            new Faculty() { Id = 2, BuildingId = 2, Name = "Факультет иностранных языков и регионоведения" }
            );

        builder.Entity<Department>().HasData(
            new Department() { Id = 1, FacultyId = 1, Name = "Кафедра информационной безопасности" },
            new Department() { Id = 2, FacultyId = 1, Name = "Кафедра интеллектуальных информационных технологий" },
            new Department() { Id = 3, FacultyId = 1, Name = "Кафедра системного программирования" },

            new Department() { Id = 4, FacultyId = 2, Name = "Национальное общество прикладной лингвистики" },
            new Department() { Id = 5, FacultyId = 2, Name = "Just English" }
            );

        builder.Entity<Room>().HasData(GenerateRooms(1, 1, 1, 32));
        builder.Entity<Room>().HasData(GenerateRooms(2, 2, 33, 65));
        builder.Entity<Room>().HasData(GenerateRooms(3, 3, 66, 131));

        builder.Entity<Room>().HasData(GenerateRooms(4, 4, 132, 164));
        builder.Entity<Room>().HasData(GenerateRooms(5, 5, 165, 181));
    }

    private List<Room> GenerateRooms(int locationId, int departmentId, int startingRoomNumber, int endingRoomNumber)
    {
        var random = new Random();
        var rooms = new List<Room>();

        for (int i = startingRoomNumber; i <= endingRoomNumber; i++)
        {
            int randomRoomNumber = random.Next(startingRoomNumber, endingRoomNumber);
            int randomLength = random.Next(6, 21);
            int randomWidth = random.Next(6, 17);
            int randomType = random.Next(0, 2);
            int randomPurpose = random.Next(0, 2);

            //Если сгенерился уже существующий номер кабинета, то продолжаем цикл по новой
            if (rooms.Any(r => r.Number == randomRoomNumber))
            {
                continue;
            }

            rooms.Add(new Room()
            {
                Id = i,
                LocationId = locationId,
                DepartmentId = departmentId,
                Number = randomRoomNumber,
                Length = randomLength,
                Width = randomWidth,
                Purpose = (RoomPurpose)randomPurpose,
                Type = (RoomType)randomType
            });
        }

        return rooms;
    }
}
