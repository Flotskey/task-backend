using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculties_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    CeilingHeight = table.Column<double>(type: "float", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Purpose = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Rooms_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "2-й учебный корпус" });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "4-й учебный корпус" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "BuildingId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Факультет вычислительной математики и кибернетики" },
                    { 2, 2, "Факультет иностранных языков и регионоведения" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "BuildingId", "CeilingHeight", "Floor" },
                values: new object[,]
                {
                    { 1, 1, 3.5, 1 },
                    { 2, 1, 3.0, 2 },
                    { 3, 1, 3.0, 3 },
                    { 4, 2, 3.0, 1 },
                    { 5, 2, 3.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "FacultyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Кафедра информационной безопасности" },
                    { 2, 1, "Кафедра интеллектуальных информационных технологий" },
                    { 3, 1, "Кафедра системного программирования" },
                    { 4, 2, "Национальное общество прикладной лингвистики" },
                    { 5, 2, "Just English" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 1, 1, 17.0, 1, 2, 0, 0, 9.0 },
                    { 2, 1, 9.0, 1, 17, 0, 1, 11.0 },
                    { 3, 1, 15.0, 1, 24, 1, 1, 10.0 },
                    { 4, 1, 12.0, 1, 28, 0, 0, 14.0 },
                    { 5, 1, 8.0, 1, 10, 1, 1, 16.0 },
                    { 6, 1, 9.0, 1, 18, 0, 1, 12.0 },
                    { 7, 1, 14.0, 1, 12, 1, 0, 9.0 },
                    { 9, 1, 8.0, 1, 20, 0, 1, 8.0 },
                    { 10, 1, 19.0, 1, 21, 0, 0, 15.0 },
                    { 14, 1, 16.0, 1, 16, 0, 0, 14.0 },
                    { 16, 1, 18.0, 1, 27, 0, 0, 16.0 },
                    { 17, 1, 15.0, 1, 14, 0, 1, 8.0 },
                    { 18, 1, 7.0, 1, 3, 1, 0, 6.0 },
                    { 20, 1, 6.0, 1, 5, 0, 0, 14.0 },
                    { 21, 1, 16.0, 1, 25, 1, 0, 9.0 },
                    { 22, 1, 18.0, 1, 13, 0, 0, 13.0 },
                    { 23, 1, 7.0, 1, 11, 0, 0, 14.0 },
                    { 26, 1, 15.0, 1, 31, 1, 0, 14.0 },
                    { 27, 1, 14.0, 1, 9, 0, 0, 6.0 },
                    { 29, 1, 11.0, 1, 4, 0, 0, 14.0 },
                    { 31, 1, 7.0, 1, 22, 1, 1, 14.0 },
                    { 33, 2, 13.0, 2, 58, 1, 1, 8.0 },
                    { 34, 2, 6.0, 2, 46, 0, 1, 7.0 },
                    { 35, 2, 12.0, 2, 55, 0, 1, 10.0 },
                    { 36, 2, 13.0, 2, 64, 1, 1, 13.0 },
                    { 37, 2, 13.0, 2, 61, 0, 1, 10.0 },
                    { 38, 2, 19.0, 2, 35, 0, 1, 14.0 },
                    { 39, 2, 12.0, 2, 40, 1, 0, 8.0 },
                    { 40, 2, 18.0, 2, 33, 1, 1, 12.0 },
                    { 42, 2, 19.0, 2, 48, 0, 1, 13.0 },
                    { 43, 2, 13.0, 2, 54, 1, 0, 8.0 },
                    { 44, 2, 17.0, 2, 59, 1, 1, 12.0 },
                    { 45, 2, 6.0, 2, 38, 0, 0, 16.0 },
                    { 48, 2, 9.0, 2, 36, 1, 1, 14.0 },
                    { 49, 2, 13.0, 2, 34, 0, 1, 8.0 },
                    { 51, 2, 13.0, 2, 60, 1, 0, 9.0 },
                    { 52, 2, 18.0, 2, 52, 0, 1, 8.0 },
                    { 55, 2, 11.0, 2, 47, 1, 1, 11.0 },
                    { 56, 2, 15.0, 2, 53, 0, 1, 11.0 },
                    { 57, 2, 6.0, 2, 57, 1, 1, 13.0 },
                    { 58, 2, 9.0, 2, 43, 1, 1, 8.0 },
                    { 59, 2, 11.0, 2, 41, 0, 0, 13.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 65, 2, 11.0, 2, 42, 1, 0, 8.0 },
                    { 66, 3, 14.0, 3, 68, 1, 0, 8.0 },
                    { 67, 3, 18.0, 3, 73, 1, 1, 9.0 },
                    { 68, 3, 10.0, 3, 123, 1, 0, 10.0 },
                    { 69, 3, 20.0, 3, 71, 0, 1, 12.0 },
                    { 70, 3, 13.0, 3, 125, 1, 0, 16.0 },
                    { 71, 3, 17.0, 3, 106, 1, 0, 11.0 },
                    { 72, 3, 18.0, 3, 124, 1, 0, 9.0 },
                    { 73, 3, 19.0, 3, 112, 1, 1, 6.0 },
                    { 74, 3, 9.0, 3, 75, 0, 0, 9.0 },
                    { 75, 3, 18.0, 3, 76, 0, 0, 12.0 },
                    { 76, 3, 7.0, 3, 102, 0, 1, 16.0 },
                    { 78, 3, 13.0, 3, 101, 1, 0, 8.0 },
                    { 79, 3, 19.0, 3, 84, 0, 0, 9.0 },
                    { 80, 3, 8.0, 3, 109, 1, 1, 12.0 },
                    { 82, 3, 10.0, 3, 127, 0, 1, 15.0 },
                    { 84, 3, 20.0, 3, 81, 1, 1, 12.0 },
                    { 85, 3, 14.0, 3, 110, 1, 0, 9.0 },
                    { 86, 3, 15.0, 3, 116, 0, 0, 16.0 },
                    { 87, 3, 16.0, 3, 115, 0, 1, 7.0 },
                    { 88, 3, 9.0, 3, 93, 0, 0, 12.0 },
                    { 89, 3, 7.0, 3, 67, 1, 0, 16.0 },
                    { 90, 3, 9.0, 3, 92, 0, 0, 8.0 },
                    { 91, 3, 11.0, 3, 96, 1, 0, 10.0 },
                    { 92, 3, 16.0, 3, 74, 1, 1, 6.0 },
                    { 93, 3, 10.0, 3, 91, 0, 1, 11.0 },
                    { 94, 3, 16.0, 3, 114, 1, 1, 13.0 },
                    { 95, 3, 19.0, 3, 85, 0, 1, 7.0 },
                    { 97, 3, 7.0, 3, 79, 0, 1, 13.0 },
                    { 99, 3, 8.0, 3, 107, 0, 0, 16.0 },
                    { 101, 3, 12.0, 3, 77, 1, 1, 11.0 },
                    { 102, 3, 10.0, 3, 103, 1, 0, 7.0 },
                    { 104, 3, 16.0, 3, 94, 1, 1, 11.0 },
                    { 105, 3, 7.0, 3, 122, 1, 0, 14.0 },
                    { 107, 3, 8.0, 3, 78, 1, 0, 11.0 },
                    { 111, 3, 9.0, 3, 118, 1, 1, 11.0 },
                    { 113, 3, 18.0, 3, 70, 0, 0, 15.0 },
                    { 114, 3, 15.0, 3, 82, 1, 0, 15.0 },
                    { 115, 3, 16.0, 3, 119, 1, 1, 15.0 },
                    { 116, 3, 11.0, 3, 117, 0, 1, 10.0 },
                    { 119, 3, 11.0, 3, 95, 0, 0, 12.0 },
                    { 121, 3, 17.0, 3, 98, 1, 0, 15.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 122, 3, 18.0, 3, 88, 1, 1, 10.0 },
                    { 123, 3, 17.0, 3, 108, 1, 0, 8.0 },
                    { 124, 3, 6.0, 3, 72, 0, 1, 10.0 },
                    { 127, 3, 13.0, 3, 69, 0, 1, 8.0 },
                    { 128, 3, 8.0, 3, 126, 1, 1, 12.0 },
                    { 132, 4, 11.0, 4, 157, 0, 1, 14.0 },
                    { 133, 4, 13.0, 4, 135, 1, 0, 16.0 },
                    { 134, 4, 6.0, 4, 159, 0, 1, 13.0 },
                    { 135, 4, 10.0, 4, 147, 1, 0, 7.0 },
                    { 136, 4, 11.0, 4, 138, 1, 1, 7.0 },
                    { 137, 4, 16.0, 4, 150, 0, 0, 11.0 },
                    { 138, 4, 8.0, 4, 154, 0, 0, 15.0 },
                    { 139, 4, 18.0, 4, 161, 0, 1, 13.0 },
                    { 140, 4, 19.0, 4, 140, 0, 0, 10.0 },
                    { 141, 4, 19.0, 4, 151, 0, 0, 13.0 },
                    { 148, 4, 14.0, 4, 136, 1, 0, 14.0 },
                    { 152, 4, 14.0, 4, 146, 0, 1, 11.0 },
                    { 155, 4, 10.0, 4, 143, 0, 1, 16.0 },
                    { 156, 4, 10.0, 4, 133, 1, 0, 16.0 },
                    { 161, 4, 7.0, 4, 148, 1, 1, 8.0 },
                    { 162, 4, 14.0, 4, 162, 0, 0, 7.0 },
                    { 164, 4, 19.0, 4, 144, 0, 0, 16.0 },
                    { 165, 5, 16.0, 5, 177, 1, 0, 8.0 },
                    { 166, 5, 9.0, 5, 173, 0, 1, 13.0 },
                    { 167, 5, 16.0, 5, 166, 0, 1, 10.0 },
                    { 168, 5, 11.0, 5, 170, 1, 0, 10.0 },
                    { 171, 5, 12.0, 5, 169, 0, 0, 7.0 },
                    { 173, 5, 13.0, 5, 176, 1, 0, 13.0 },
                    { 174, 5, 13.0, 5, 180, 0, 0, 7.0 },
                    { 175, 5, 15.0, 5, 175, 1, 0, 8.0 },
                    { 176, 5, 8.0, 5, 171, 1, 1, 13.0 },
                    { 179, 5, 13.0, 5, 168, 0, 0, 6.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_BuildingId",
                table: "Faculties",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_BuildingId",
                table: "Locations",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DepartmentId",
                table: "Rooms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_LocationId",
                table: "Rooms",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Buildings");
        }
    }
}
