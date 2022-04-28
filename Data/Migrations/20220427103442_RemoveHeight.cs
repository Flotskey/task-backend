using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    public partial class RemoveHeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17);

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
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27);

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
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82);

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
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97);

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
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152);

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
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 6.0, 1, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 12.0, 22, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 23, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 11.0, 31, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 9.0, 11, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 17.0, 21, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 17.0, 25, 1, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 8.0, 14, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 8.0, 8, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 7, 1, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Length", "Purpose", "Width" },
                values: new object[] { 17.0, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 9.0, 12, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 5, 0, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 15, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Number", "Purpose", "Type", "Width" },
                values: new object[] { 34, 1, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 7.0, 49, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 35, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 17.0, 41, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 11.0, 55, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 10.0, 42, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 61, 0, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 14.0, 47, 1, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 15.0, 56, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 63, 1, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 8.0, 48, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Number", "Purpose", "Type", "Width" },
                values: new object[] { 36, 1, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 15.0, 52, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 13.0, 123, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 129, 0, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 114, 1, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 6.0, 97, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 11.0, 81, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Length", "Number", "Purpose" },
                values: new object[] { 17.0, 78, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Length", "Number" },
                values: new object[] { 18.0, 101 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 6.0, 109, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Number", "Purpose", "Width" },
                values: new object[] { 99, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 8.0, 79, 0, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 16.0, 80, 1, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 17.0, 113, 1, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 6.0, 110, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 75, 0, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Length", "Number", "Purpose" },
                values: new object[] { 13.0, 70, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 7.0, 84, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 20.0, 76, 1, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Number", "Purpose", "Type", "Width" },
                values: new object[] { 103, 1, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 7.0, 120, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 20.0, 130, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 11.0, 127, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 126, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 14.0, 93, 0, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 20.0, 111, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Length", "Number" },
                values: new object[] { 17.0, 161 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 13.0, 158, 1, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 16.0, 139, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 135, 0, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 14.0, 146, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 11.0, 137, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Number", "Type", "Width" },
                values: new object[] { 136, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 15.0, 160, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 16.0, 140, 1, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 19.0, 145, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 8.0, 149, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 8.0, 155, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 14.0, 133, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 157, 1, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 147, 1, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 13.0, 148, 1, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 8.0, 153, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 142, 0, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 9.0, 174, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 15.0, 178, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 7.0, 175, 0, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 16.0, 169, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 11.0, 177, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Length", "Number", "Width" },
                values: new object[] { 7.0, 165, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Length", "Purpose", "Width" },
                values: new object[] { 11.0, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Length", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 170, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Length", "Type", "Width" },
                values: new object[] { 17.0, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Length", "Number", "Type", "Width" },
                values: new object[] { 19.0, 171, 0, 8.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 11, 1, 8.0, 11, 20, 0, 0, 16.0 },
                    { 15, 1, 19.0, 11, 28, 1, 1, 8.0 },
                    { 18, 1, 18.0, 11, 17, 1, 0, 8.0 },
                    { 19, 1, 11.0, 11, 30, 1, 0, 11.0 },
                    { 24, 1, 7.0, 11, 26, 1, 0, 13.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 28, 1, 13.0, 11, 19, 1, 0, 8.0 },
                    { 29, 1, 11.0, 11, 4, 1, 1, 12.0 },
                    { 37, 2, 13.0, 22, 53, 1, 0, 6.0 },
                    { 38, 2, 8.0, 22, 57, 0, 0, 15.0 },
                    { 42, 2, 10.0, 22, 54, 1, 0, 14.0 },
                    { 56, 2, 6.0, 22, 64, 0, 0, 9.0 },
                    { 61, 2, 18.0, 22, 62, 0, 0, 8.0 },
                    { 63, 2, 17.0, 22, 44, 1, 1, 7.0 },
                    { 65, 2, 11.0, 22, 37, 0, 1, 6.0 },
                    { 75, 3, 6.0, 33, 91, 1, 1, 15.0 },
                    { 77, 3, 14.0, 33, 125, 0, 1, 15.0 },
                    { 85, 3, 20.0, 33, 71, 1, 0, 11.0 },
                    { 86, 3, 16.0, 33, 116, 1, 0, 8.0 },
                    { 90, 3, 19.0, 33, 77, 0, 0, 14.0 },
                    { 101, 3, 8.0, 33, 82, 0, 1, 12.0 },
                    { 102, 3, 10.0, 33, 117, 0, 0, 14.0 },
                    { 103, 3, 20.0, 33, 89, 0, 1, 12.0 },
                    { 105, 3, 14.0, 33, 106, 1, 1, 8.0 },
                    { 110, 3, 16.0, 33, 85, 1, 1, 9.0 },
                    { 112, 3, 20.0, 33, 88, 0, 1, 13.0 },
                    { 117, 3, 12.0, 33, 118, 0, 0, 12.0 },
                    { 129, 3, 9.0, 33, 87, 0, 0, 10.0 },
                    { 130, 3, 14.0, 33, 98, 0, 1, 12.0 },
                    { 150, 4, 20.0, 44, 138, 0, 1, 10.0 },
                    { 153, 4, 19.0, 44, 134, 0, 1, 15.0 },
                    { 157, 4, 12.0, 44, 132, 1, 0, 8.0 },
                    { 158, 4, 13.0, 44, 150, 1, 1, 16.0 },
                    { 160, 4, 9.0, 44, 143, 0, 1, 8.0 },
                    { 161, 4, 17.0, 44, 151, 0, 0, 14.0 },
                    { 164, 4, 19.0, 44, 154, 0, 1, 15.0 },
                    { 171, 5, 7.0, 55, 166, 1, 0, 13.0 },
                    { 177, 5, 20.0, 55, 172, 1, 0, 16.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65);

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
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101);

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
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110);

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
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150);

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
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171);

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
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 16.0, 7, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 19.0, 4, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 13.0, 1, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 19.0, 30, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.5, 18.0, 14, 1, 9.0 });

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
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.5, 7.0, 6, 0, 0, 7.0 });

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
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 10.0, 17, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.5, 11.0, 20, 0, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Height", "Length", "Purpose", "Width" },
                values: new object[] { 3.5, 14.0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.5, 16.0, 21, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.5, 12.0, 19, 1, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.5, 6.0, 10, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Height", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 54, 0, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 8.0, 37, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 50, 1, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 10.0, 48, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 19.0, 56, 14.0 });

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
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 34, 1, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 35, 0, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 11.0, 40, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 52, 0, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 19.0, 33, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Height", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 58, 0, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 18.0, 51, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 16.0, 71, 0, 13.0 });

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
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 16.0, 122, 12.0 });

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
                columns: new[] { "Height", "Length", "Number", "Purpose" },
                values: new object[] { 3.0, 9.0, 85, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Height", "Length", "Number" },
                values: new object[] { 3.0, 13.0, 106 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 112, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Height", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 96, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 19.0, 119, 1, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 83, 0, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 8.0, 70, 0, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 10.0, 107, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 16.0, 77, 1, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Height", "Length", "Number", "Purpose" },
                values: new object[] { 3.0, 9.0, 79, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 8.0, 72, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 105, 0, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Height", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 113, 0, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 109, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 7.0, 123, 8.0 });

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
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 87, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 18.0, 125, 1, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 11.0, 97, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Height", "Length", "Number" },
                values: new object[] { 3.0, 12.0, 151 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 11.0, 147, 0, 0, 10.0 });

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
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 144, 1, 1, 10.0 });

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
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 6.0, 145, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Height", "Number", "Type", "Width" },
                values: new object[] { 3.0, 156, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 139, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 18.0, 159, 0, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 146, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 13.0, 163, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 15.0, 142, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 20.0, 150, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 10.0, 138, 0, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 12.0, 155, 0, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 15.0, 152, 0, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 17.0, 137, 1, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 140, 1, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 14.0, 171, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 11.0, 180, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 3.0, 16.0, 167, 1, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 17.0, 177, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 14.0, 169, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Height", "Length", "Number", "Width" },
                values: new object[] { 3.0, 10.0, 174, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Height", "Length", "Purpose", "Width" },
                values: new object[] { 3.0, 20.0, 1, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Height", "Length", "Number", "Purpose", "Width" },
                values: new object[] { 3.0, 7.0, 168, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Height", "Length", "Type", "Width" },
                values: new object[] { 3.0, 20.0, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Height", "Length", "Number", "Type", "Width" },
                values: new object[] { 3.0, 9.0, 165, 1, 6.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Height", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 13, 1, 3.5, 15.0, 11, 13, 0, 1, 12.0 },
                    { 16, 1, 3.5, 12.0, 11, 31, 1, 0, 13.0 },
                    { 17, 1, 3.5, 17.0, 11, 28, 0, 0, 13.0 },
                    { 21, 1, 3.5, 16.0, 11, 11, 1, 0, 8.0 },
                    { 22, 1, 3.5, 13.0, 11, 8, 0, 1, 13.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Height", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 25, 1, 3.5, 7.0, 11, 29, 1, 0, 7.0 },
                    { 27, 1, 3.5, 14.0, 11, 9, 0, 0, 10.0 },
                    { 30, 1, 3.5, 9.0, 11, 15, 1, 1, 6.0 },
                    { 31, 1, 3.5, 12.0, 11, 26, 1, 1, 6.0 },
                    { 44, 2, 3.0, 18.0, 22, 53, 0, 0, 14.0 },
                    { 45, 2, 3.0, 17.0, 22, 44, 1, 1, 13.0 },
                    { 46, 2, 3.0, 15.0, 22, 63, 1, 1, 15.0 },
                    { 48, 2, 3.0, 10.0, 22, 42, 0, 1, 7.0 },
                    { 49, 2, 3.0, 19.0, 22, 64, 0, 0, 12.0 },
                    { 64, 2, 3.0, 17.0, 22, 39, 0, 0, 9.0 },
                    { 72, 3, 3.0, 10.0, 33, 68, 0, 0, 9.0 },
                    { 81, 3, 3.0, 14.0, 33, 102, 0, 1, 14.0 },
                    { 82, 3, 3.0, 6.0, 33, 89, 1, 0, 8.0 },
                    { 87, 3, 3.0, 6.0, 33, 120, 0, 1, 13.0 },
                    { 88, 3, 3.0, 12.0, 33, 121, 0, 0, 16.0 },
                    { 94, 3, 3.0, 15.0, 33, 100, 0, 0, 10.0 },
                    { 96, 3, 3.0, 8.0, 33, 93, 0, 0, 11.0 },
                    { 97, 3, 3.0, 16.0, 33, 129, 1, 0, 8.0 },
                    { 104, 3, 3.0, 16.0, 33, 88, 0, 0, 12.0 },
                    { 106, 3, 3.0, 6.0, 33, 115, 0, 0, 11.0 },
                    { 108, 3, 3.0, 16.0, 33, 81, 0, 0, 11.0 },
                    { 111, 3, 3.0, 8.0, 33, 66, 0, 1, 9.0 },
                    { 113, 3, 3.0, 15.0, 33, 128, 0, 1, 15.0 },
                    { 121, 3, 3.0, 18.0, 33, 104, 1, 1, 8.0 },
                    { 138, 4, 3.0, 17.0, 44, 135, 0, 1, 8.0 },
                    { 139, 4, 3.0, 11.0, 44, 143, 1, 1, 16.0 },
                    { 142, 4, 3.0, 14.0, 44, 153, 0, 0, 10.0 },
                    { 143, 4, 3.0, 18.0, 44, 136, 0, 1, 11.0 },
                    { 152, 4, 3.0, 7.0, 44, 162, 0, 0, 16.0 },
                    { 180, 5, 3.0, 10.0, 55, 176, 1, 0, 8.0 }
                });
        }
    }
}
