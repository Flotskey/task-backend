using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreConsoleApp.Migrations
{
    public partial class ComputedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18);

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
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31);

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
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65);

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
                keyValue: 90);

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
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114);

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
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138);

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
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Rooms",
                type: "float",
                nullable: false,
                computedColumnSql: "[Width]*[Length]",
                stored: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "BuildingId", "CeilingHeight", "Floor" },
                values: new object[,]
                {
                    { 11, 1, 3.5, 1 },
                    { 22, 1, 3.0, 2 },
                    { 33, 1, 3.0, 3 },
                    { 44, 2, 3.0, 1 },
                    { 55, 2, 3.0, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 11, 23, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 18.0, 11, 19, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 14.0, 11, 12, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 11, 17, 1, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 14.0, 11, 22, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 20.0, 11, 9, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 16.0, 11, 21, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 7.0, 11, 10, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 7.0, 11, 24, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 14.0, 11, 28, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 11, 31, 1, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 18.0, 11, 8, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 19.0, 11, 27, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 15.0, 11, 7, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 14.0, 22, 55, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 20.0, 22, 43, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 16.0, 22, 38, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 17.0, 22, 41, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 13.0, 22, 51, 0, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 20.0, 22, 50, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 16.0, 22, 63, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 18.0, 22, 64, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 17.0, 22, 46, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 22, 47, 0, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 22, 44, 0, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 12.0, 22, 48, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 7.0, 22, 62, 1, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 19.0, 33, 111, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 33, 68, 0, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 12.0, 33, 97, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "LocationId", "Number", "Purpose" },
                values: new object[] { 33, 67, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 11.0, 33, 73, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 33, 95, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 33, 106, 0, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 15.0, 33, 101, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 33, 105, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 7.0, 33, 69, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Length", "LocationId", "Number" },
                values: new object[] { 10.0, 33, 89 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 8.0, 33, 84, 0, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 16.0, 33, 77, 1, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Length", "LocationId", "Number", "Type" },
                values: new object[] { 17.0, 33, 119, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 20.0, 33, 94, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 15.0, 33, 70, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 17.0, 33, 99, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 33, 78, 1, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 12.0, 33, 127, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 33, 86, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 16.0, 33, 129, 1, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 33, 121, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 18.0, 33, 100, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 14.0, 33, 110, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 7.0, 33, 116, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 11.0, 33, 80, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 15.0, 33, 74, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 33, 90, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 18.0, 33, 102, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 12.0, 33, 125, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 17.0, 33, 81, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 6.0, 33, 117, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 17.0, 44, 135, 1, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 12.0, 44, 145, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 16.0, 44, 160, 1, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 12.0, 44, 158, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 20.0, 44, 134, 0, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "LocationId", "Number", "Type", "Width" },
                values: new object[] { 44, 147, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 44, 133, 1, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 8.0, 44, 157, 1, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 17.0, 44, 153, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 6.0, 44, 143, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 15.0, 44, 154, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type" },
                values: new object[] { 9.0, 55, 166, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 7.0, 55, 172, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type" },
                values: new object[] { 8.0, 55, 167, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 9.0, 55, 179, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 14.0, 55, 174, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 55, 177, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 20.0, 55, 171, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 12.0, 55, 173, 0, 10.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 8, 1, 15.0, 11, 4, 0, 0, 11.0 },
                    { 11, 1, 11.0, 11, 14, 0, 0, 14.0 },
                    { 12, 1, 14.0, 11, 1, 0, 1, 8.0 },
                    { 13, 1, 20.0, 11, 18, 0, 1, 14.0 },
                    { 19, 1, 6.0, 11, 25, 0, 1, 9.0 },
                    { 25, 1, 10.0, 11, 11, 0, 0, 14.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 41, 2, 9.0, 22, 45, 1, 0, 6.0 },
                    { 46, 2, 10.0, 22, 35, 0, 1, 9.0 },
                    { 47, 2, 9.0, 22, 61, 1, 0, 14.0 },
                    { 50, 2, 9.0, 22, 57, 1, 1, 6.0 },
                    { 53, 2, 6.0, 22, 33, 1, 1, 9.0 },
                    { 62, 2, 8.0, 22, 52, 0, 0, 12.0 },
                    { 77, 3, 17.0, 33, 76, 1, 0, 9.0 },
                    { 81, 3, 19.0, 33, 72, 1, 1, 10.0 },
                    { 96, 3, 14.0, 33, 107, 0, 1, 8.0 },
                    { 98, 3, 18.0, 33, 75, 1, 0, 14.0 },
                    { 100, 3, 8.0, 33, 130, 0, 0, 13.0 },
                    { 103, 3, 13.0, 33, 114, 0, 0, 15.0 },
                    { 108, 3, 16.0, 33, 85, 1, 0, 14.0 },
                    { 109, 3, 19.0, 33, 109, 0, 1, 11.0 },
                    { 112, 3, 6.0, 33, 124, 0, 1, 14.0 },
                    { 117, 3, 20.0, 33, 112, 0, 1, 12.0 },
                    { 118, 3, 11.0, 33, 123, 1, 0, 11.0 },
                    { 126, 3, 7.0, 33, 118, 0, 1, 14.0 },
                    { 142, 4, 14.0, 44, 136, 0, 0, 12.0 },
                    { 143, 4, 14.0, 44, 163, 1, 1, 11.0 },
                    { 147, 4, 10.0, 44, 151, 1, 0, 16.0 },
                    { 149, 4, 16.0, 44, 156, 1, 0, 8.0 },
                    { 153, 4, 7.0, 44, 148, 1, 0, 10.0 },
                    { 154, 4, 13.0, 44, 149, 0, 0, 10.0 },
                    { 157, 4, 11.0, 44, 161, 1, 0, 8.0 },
                    { 158, 4, 12.0, 44, 139, 1, 0, 10.0 },
                    { 159, 4, 15.0, 44, 155, 0, 0, 6.0 },
                    { 160, 4, 8.0, 44, 137, 0, 0, 14.0 },
                    { 170, 5, 7.0, 55, 176, 0, 0, 9.0 },
                    { 177, 5, 7.0, 55, 168, 1, 0, 9.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8);

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96);

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
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108);

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
                keyValue: 126);

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
                keyValue: 147);

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
                keyValue: 154);

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
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Rooms");

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

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 17.0, 1, 2, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 1, 17, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 15.0, 1, 24, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 1, 28, 0, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 1, 18, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 14.0, 1, 12, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 8.0, 1, 20, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 19.0, 1, 21, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 16.0, 1, 16, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 18.0, 1, 27, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 1, 14, 0, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 6.0, 1, 5, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 14.0, 1, 9, 0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 11.0, 1, 4, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 2, 58, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 6.0, 2, 46, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 12.0, 2, 55, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 2, 64, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 12.0, 2, 40, 1, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 18.0, 2, 33, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 19.0, 2, 48, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 2, 54, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 6.0, 2, 38, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 9.0, 2, 36, 1, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 13.0, 2, 60, 1, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 9.0, 2, 43, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 2, 41, 0, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 14.0, 3, 68, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 3, 73, 1, 1, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 10.0, 3, 123, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "LocationId", "Number", "Purpose" },
                values: new object[] { 3, 71, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 13.0, 3, 125, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 3, 106, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 3, 124, 1, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 19.0, 3, 112, 6.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 9.0, 3, 75, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 18.0, 3, 76, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Length", "LocationId", "Number" },
                values: new object[] { 7.0, 3, 102 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 13.0, 3, 101, 1, 0, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 19.0, 3, 84, 0, 0, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Length", "LocationId", "Number", "Type" },
                values: new object[] { 8.0, 3, 109, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 10.0, 3, 127, 1, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 20.0, 3, 81, 1, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 14.0, 3, 110, 9.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 15.0, 3, 116, 0, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 7.0, 3, 67, 0, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 11.0, 3, 96, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 10.0, 3, 91, 0, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 3, 114, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 19.0, 3, 85, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 7.0, 3, 79, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 10.0, 3, 103, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 8.0, 3, 78, 1, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 18.0, 3, 70, 0, 15.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 3, 117, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 11.0, 3, 95, 0, 12.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 18.0, 3, 88, 1, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 6.0, 3, 72, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 13.0, 3, 69, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 4, 157, 0, 1, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 13.0, 4, 135, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 6.0, 4, 159, 0, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 10.0, 4, 147, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 11.0, 4, 138, 1, 1, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "LocationId", "Number", "Type", "Width" },
                values: new object[] { 4, 150, 0, 11.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[] { 18.0, 4, 161, 0, 1, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 19.0, 4, 140, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 19.0, 4, 151, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 14.0, 4, 136, 0, 14.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Length", "LocationId", "Number", "Width" },
                values: new object[] { 10.0, 4, 143, 16.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type" },
                values: new object[] { 16.0, 5, 177, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 9.0, 5, 173, 0, 13.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Type" },
                values: new object[] { 16.0, 5, 166, 0, 1 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 11.0, 5, 170, 0, 10.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 12.0, 5, 169, 0, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "LocationId", "Number", "Width" },
                values: new object[] { 5, 180, 7.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Length", "LocationId", "Number", "Purpose", "Width" },
                values: new object[] { 15.0, 5, 175, 1, 8.0 });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Length", "LocationId", "Number", "Type", "Width" },
                values: new object[] { 8.0, 5, 171, 1, 13.0 });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 5, 1, 8.0, 1, 10, 1, 1, 16.0 },
                    { 18, 1, 7.0, 1, 3, 1, 0, 6.0 },
                    { 21, 1, 16.0, 1, 25, 1, 0, 9.0 },
                    { 22, 1, 18.0, 1, 13, 0, 0, 13.0 },
                    { 23, 1, 7.0, 1, 11, 0, 0, 14.0 },
                    { 26, 1, 15.0, 1, 31, 1, 0, 14.0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "DepartmentId", "Length", "LocationId", "Number", "Purpose", "Type", "Width" },
                values: new object[,]
                {
                    { 31, 1, 7.0, 1, 22, 1, 1, 14.0 },
                    { 37, 2, 13.0, 2, 61, 0, 1, 10.0 },
                    { 38, 2, 19.0, 2, 35, 0, 1, 14.0 },
                    { 44, 2, 17.0, 2, 59, 1, 1, 12.0 },
                    { 49, 2, 13.0, 2, 34, 0, 1, 8.0 },
                    { 52, 2, 18.0, 2, 52, 0, 1, 8.0 },
                    { 55, 2, 11.0, 2, 47, 1, 1, 11.0 },
                    { 56, 2, 15.0, 2, 53, 0, 1, 11.0 },
                    { 57, 2, 6.0, 2, 57, 1, 1, 13.0 },
                    { 65, 2, 11.0, 2, 42, 1, 0, 8.0 },
                    { 87, 3, 16.0, 3, 115, 0, 1, 7.0 },
                    { 88, 3, 9.0, 3, 93, 0, 0, 12.0 },
                    { 90, 3, 9.0, 3, 92, 0, 0, 8.0 },
                    { 92, 3, 16.0, 3, 74, 1, 1, 6.0 },
                    { 99, 3, 8.0, 3, 107, 0, 0, 16.0 },
                    { 101, 3, 12.0, 3, 77, 1, 1, 11.0 },
                    { 104, 3, 16.0, 3, 94, 1, 1, 11.0 },
                    { 105, 3, 7.0, 3, 122, 1, 0, 14.0 },
                    { 111, 3, 9.0, 3, 118, 1, 1, 11.0 },
                    { 114, 3, 15.0, 3, 82, 1, 0, 15.0 },
                    { 115, 3, 16.0, 3, 119, 1, 1, 15.0 },
                    { 121, 3, 17.0, 3, 98, 1, 0, 15.0 },
                    { 123, 3, 17.0, 3, 108, 1, 0, 8.0 },
                    { 128, 3, 8.0, 3, 126, 1, 1, 12.0 },
                    { 138, 4, 8.0, 4, 154, 0, 0, 15.0 },
                    { 152, 4, 14.0, 4, 146, 0, 1, 11.0 },
                    { 156, 4, 10.0, 4, 133, 1, 0, 16.0 },
                    { 161, 4, 7.0, 4, 148, 1, 1, 8.0 },
                    { 162, 4, 14.0, 4, 162, 0, 0, 7.0 },
                    { 164, 4, 19.0, 4, 144, 0, 0, 16.0 },
                    { 173, 5, 13.0, 5, 176, 1, 0, 13.0 },
                    { 179, 5, 13.0, 5, 168, 0, 0, 6.0 }
                });
        }
    }
}
