using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    public partial class AddRoomHeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Rooms",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Volume",
                table: "Rooms",
                type: "float",
                nullable: false,
                computedColumnSql: "[Width]*[Length]*[Height]",
                stored: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 16.0, 7, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 19.0, 4, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 13.0, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 19.0, 30, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 20.0, 2, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 7.0, 6, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 18.0, 27, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 10.0, 17, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 11.0, 20, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 15.0, 13, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 14.0, 18, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.5, 12.0, 31, 1, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 17.0, 28, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 16.0, 21, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 7.0, 29, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 14.0, 9, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 20.0, 54, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 8.0, 37, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 50, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 10.0, 48, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 19.0, 56, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 17.0, 62, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 34, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Height", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 44, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 15.0, 63, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Height", "Number", "Type", "Width" },
                values: new object[] { 3.0, 42, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 35, 0, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 52, 0, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 18.0, 51, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 16.0, 71, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 7.0, 117, 1, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 124, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Height", "Length", "Number", "Purpose" },
                values: new object[] { 3.0, 16.0, 122, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 110, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 9.0, 85, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Height", "Number", "Type", "Width" },
                values: new object[] { 3.0, 68, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 13.0, 106, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 112, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 18.0, 96, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Height", "Length", "Number", "Purpose" },
                values: new object[] { 3.0, 19.0, 119, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type" },
                values: new object[] { 3.0, 9.0, 83, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 8.0, 70, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 102, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 6.0, 89, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 16.0, 77, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 79, 1, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 105, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 15.0, 100, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Height", "Length", "Number", "Type" },
                values: new object[] { 3.0, 20.0, 113, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 8.0, 93, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 16.0, 129, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Height", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 81, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Height", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 128, 0, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 111, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 87, 0, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 11.0, 97, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 151, 0, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 11.0, 147, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 13.0, 141, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Height", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 144, 1, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 15.0, 160, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 6.0, 145, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 143, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 20.0, 156, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 139, 1, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Height", "Number", "Width" },
                values: new object[] { 3.0, 153, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Height", "Length", "Number", "Purpose" },
                values: new object[] { 3.0, 18.0, 136, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 15.0, 142, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 20.0, 150, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 155, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Height", "Number", "Width" },
                values: new object[] { 3.0, 152, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 171, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 11.0, 180, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Height", "Length", "Width" },
                values: new object[] { 3.0, 16.0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 17.0, 177, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 10.0, 174, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 7.0, 168, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 20.0, 179, 0, 7.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Height", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 5, 1, 3.5, 18.0, 11, 14, 0, 1, 9.0 },
                    { 21, 1, 3.5, 16.0, 11, 11, 1, 0, 8.0 },
                    { 22, 1, 3.5, 13.0, 11, 8, 0, 1, 13.0 },
                    { 26, 1, 3.5, 12.0, 11, 19, 1, 0, 6.0 },
                    { 30, 1, 3.5, 9.0, 11, 15, 1, 1, 6.0 },
                    { 31, 1, 3.5, 12.0, 11, 26, 1, 1, 6.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Height", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 32, 1, 3.5, 6.0, 11, 10, 1, 0, 14.0 },
                    { 44, 2, 3.0, 18.0, 22, 53, 0, 0, 14.0 },
                    { 49, 2, 3.0, 19.0, 22, 64, 0, 0, 12.0 },
                    { 52, 2, 3.0, 11.0, 22, 40, 0, 0, 16.0 },
                    { 54, 2, 3.0, 19.0, 22, 33, 0, 1, 15.0 },
                    { 55, 2, 3.0, 15.0, 22, 58, 0, 1, 13.0 },
                    { 64, 2, 3.0, 17.0, 22, 39, 0, 0, 9.0 },
                    { 83, 3, 3.0, 10.0, 33, 107, 1, 1, 14.0 },
                    { 87, 3, 3.0, 6.0, 33, 120, 0, 1, 13.0 },
                    { 88, 3, 3.0, 12.0, 33, 121, 0, 0, 16.0 },
                    { 92, 3, 3.0, 8.0, 33, 72, 0, 1, 7.0 },
                    { 99, 3, 3.0, 11.0, 33, 109, 1, 0, 7.0 },
                    { 104, 3, 3.0, 16.0, 33, 88, 0, 0, 12.0 },
                    { 106, 3, 3.0, 6.0, 33, 115, 0, 0, 11.0 },
                    { 111, 3, 3.0, 8.0, 33, 66, 0, 1, 9.0 },
                    { 115, 3, 3.0, 7.0, 33, 123, 1, 1, 8.0 },
                    { 121, 3, 3.0, 18.0, 33, 104, 1, 1, 8.0 },
                    { 123, 3, 3.0, 18.0, 33, 125, 1, 0, 13.0 },
                    { 138, 4, 3.0, 17.0, 44, 135, 0, 1, 8.0 },
                    { 144, 4, 3.0, 18.0, 44, 159, 0, 0, 15.0 },
                    { 145, 4, 3.0, 14.0, 44, 146, 0, 0, 6.0 },
                    { 146, 4, 3.0, 13.0, 44, 163, 0, 0, 10.0 },
                    { 151, 4, 3.0, 10.0, 44, 138, 0, 0, 11.0 },
                    { 152, 4, 3.0, 7.0, 44, 162, 0, 0, 16.0 },
                    { 156, 4, 3.0, 17.0, 44, 137, 1, 0, 10.0 },
                    { 162, 4, 3.0, 14.0, 44, 140, 1, 0, 16.0 },
                    { 169, 5, 3.0, 14.0, 55, 169, 0, 0, 10.0 },
                    { 173, 5, 3.0, 20.0, 55, 173, 1, 1, 16.0 },
                    { 178, 5, 3.0, 9.0, 55, 165, 0, 1, 6.0 },
                    { 180, 5, 3.0, 10.0, 55, 176, 1, 0, 8.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 13.0, 23, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 18.0, 19, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 14.0, 12, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 11.0, 17, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 14.0, 22, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 20.0, 9, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 15.0, 4, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 21, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 10, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 20.0, 18, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 24, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 14.0, 28, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 11.0, 31, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 18.0, 8, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 11, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 19.0, 27, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 14.0, 55, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 20.0, 43, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 38, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 17.0, 41, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 13.0, 51, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 9.0, 45, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 18.0, 64, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Number", "Purpose", "Width" },
                values: new object[] { 46, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 35, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Number", "Type", "Width" },
                values: new object[] { 47, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 9.0, 57, 1, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 33, 1, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 62, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 19.0, 111, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 68, 0, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 97, 1, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Length", "Number", "Purpose" },
                values: new object[] { 20.0, 67, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 11.0, 73, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 17.0, 95, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Number", "Type", "Width" },
                values: new object[] { 106, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 15.0, 101, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 13.0, 105, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 89, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Length", "Number", "Purpose" },
                values: new object[] { 8.0, 84, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Length", "Number", "Purpose", "Type" },
                values: new object[] { 16.0, 77, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 17.0, 119, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 19.0, 72, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 20.0, 94, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 12.0, 127, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 86, 0, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 16.0, 129, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 121, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Length", "Number", "Type" },
                values: new object[] { 18.0, 100, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 14.0, 107, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 14.0, 110, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Number", "Purpose", "Width" },
                values: new object[] { 85, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Number", "Purpose", "Type", "Width" },
                values: new object[] { 74, 1, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 11.0, 90, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 102, 1, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 17.0, 81, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 17.0, 135, 1, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 12.0, 145, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 16.0, 160, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Number", "Purpose", "Type", "Width" },
                values: new object[] { 158, 0, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 20.0, 134, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 147, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 12.0, 133, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 8.0, 157, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 17.0, 153, 0, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Number", "Width" },
                values: new object[] { 136, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Length", "Number", "Purpose" },
                values: new object[] { 14.0, 163, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 151, 1, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 6.0, 143, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 13.0, 149, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Number", "Width" },
                values: new object[] { 154, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 166, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 172, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Length", "Width" },
                values: new object[] { 8.0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 179, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 176, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 20.0, 171, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 12.0, 173, 1, 10.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 11, 1, 11.0, 11, 14, 0, 0, 14.0 },
                    { 12, 1, 14.0, 11, 1, 0, 1, 8.0 },
                    { 19, 1, 6.0, 11, 25, 0, 1, 9.0 },
                    { 29, 1, 15.0, 11, 7, 0, 0, 16.0 },
                    { 40, 2, 20.0, 22, 50, 1, 0, 15.0 },
                    { 42, 2, 16.0, 22, 63, 0, 1, 9.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 47, 2, 9.0, 22, 61, 1, 0, 14.0 },
                    { 51, 2, 11.0, 22, 44, 0, 1, 11.0 },
                    { 58, 2, 12.0, 22, 48, 1, 0, 12.0 },
                    { 62, 2, 8.0, 22, 52, 0, 0, 12.0 },
                    { 75, 3, 7.0, 33, 69, 0, 0, 15.0 },
                    { 77, 3, 17.0, 33, 76, 1, 0, 9.0 },
                    { 84, 3, 15.0, 33, 70, 1, 0, 7.0 },
                    { 85, 3, 17.0, 33, 99, 1, 0, 11.0 },
                    { 86, 3, 18.0, 33, 78, 1, 1, 6.0 },
                    { 98, 3, 18.0, 33, 75, 1, 0, 14.0 },
                    { 100, 3, 8.0, 33, 130, 0, 0, 13.0 },
                    { 102, 3, 7.0, 33, 116, 1, 0, 11.0 },
                    { 103, 3, 13.0, 33, 114, 0, 0, 15.0 },
                    { 107, 3, 11.0, 33, 80, 0, 0, 8.0 },
                    { 109, 3, 19.0, 33, 109, 0, 1, 11.0 },
                    { 112, 3, 6.0, 33, 124, 0, 1, 14.0 },
                    { 117, 3, 20.0, 33, 112, 0, 1, 12.0 },
                    { 118, 3, 11.0, 33, 123, 1, 0, 11.0 },
                    { 122, 3, 12.0, 33, 125, 1, 0, 11.0 },
                    { 126, 3, 7.0, 33, 118, 0, 1, 14.0 },
                    { 127, 3, 6.0, 33, 117, 0, 1, 6.0 },
                    { 149, 4, 16.0, 44, 156, 1, 0, 8.0 },
                    { 153, 4, 7.0, 44, 148, 1, 0, 10.0 },
                    { 157, 4, 11.0, 44, 161, 1, 0, 8.0 },
                    { 158, 4, 12.0, 44, 139, 1, 0, 10.0 },
                    { 159, 4, 15.0, 44, 155, 0, 0, 6.0 },
                    { 160, 4, 8.0, 44, 137, 0, 0, 14.0 },
                    { 171, 5, 14.0, 55, 174, 0, 1, 14.0 },
                    { 174, 5, 13.0, 55, 177, 0, 0, 15.0 },
                    { 177, 5, 7.0, 55, 168, 1, 0, 9.0 }
                });
        }
    }
}
