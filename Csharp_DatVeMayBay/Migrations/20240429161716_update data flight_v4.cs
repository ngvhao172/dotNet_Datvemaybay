using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updatedataflight_v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 7, 48, 0, 0, DateTimeKind.Local), 2545518m, new DateTime(2024, 5, 1, 2, 23, 0, 0, DateTimeKind.Local), 946931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 19, 25, 0, 0, DateTimeKind.Local), 2242283m, new DateTime(2024, 5, 3, 17, 42, 0, 0, DateTimeKind.Local), 1120024m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 1, 3, 17, 0, 0, DateTimeKind.Local), 2955967m, new DateTime(2024, 4, 30, 20, 59, 0, 0, DateTimeKind.Local), 857970m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 2, 0, 47, 0, 0, DateTimeKind.Local), 3146434m, new DateTime(2024, 5, 1, 17, 39, 0, 0, DateTimeKind.Local), 854670m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 1, 40, 0, 0, DateTimeKind.Local), 3134723m, new DateTime(2024, 5, 2, 23, 56, 0, 0, DateTimeKind.Local), 1117595m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 30, 3, 41, 0, 0, DateTimeKind.Local), 3342641m, new DateTime(2024, 4, 29, 20, 21, 0, 0, DateTimeKind.Local), 1267611m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 20, 50, 0, 0, DateTimeKind.Local), 2529483m, new DateTime(2024, 5, 1, 13, 1, 0, 0, DateTimeKind.Local), 885226m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 1, 18, 12, 0, 0, DateTimeKind.Local), 3265394m, new DateTime(2024, 5, 1, 16, 7, 0, 0, DateTimeKind.Local), 1331269m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 4, 9, 0, 0, DateTimeKind.Local), 3027096m, new DateTime(2024, 5, 3, 1, 36, 0, 0, DateTimeKind.Local), 1086599m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 3, 7, 29, 0, 0, DateTimeKind.Local), 3066553m, new DateTime(2024, 5, 3, 6, 15, 0, 0, DateTimeKind.Local), 982033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 12, 50, 0, 0, DateTimeKind.Local), 3448434m, new DateTime(2024, 4, 29, 11, 42, 0, 0, DateTimeKind.Local), 884039m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 8, 43, 0, 0, DateTimeKind.Local), 3360431m, new DateTime(2024, 5, 3, 2, 42, 0, 0, DateTimeKind.Local), 1428728m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 7, 46, 0, 0, DateTimeKind.Local), 3096990m, new DateTime(2024, 5, 1, 6, 32, 0, 0, DateTimeKind.Local), 1212072m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 1, 13, 17, 0, 0, DateTimeKind.Local), 2384260m, new DateTime(2024, 5, 1, 8, 38, 0, 0, DateTimeKind.Local), 1068021m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 0, 4, 0, 0, DateTimeKind.Local), 3110376m, new DateTime(2024, 5, 2, 17, 2, 0, 0, DateTimeKind.Local), 999956m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 30, 6, 57, 0, 0, DateTimeKind.Local), 2680851m, new DateTime(2024, 4, 29, 23, 17, 0, 0, DateTimeKind.Local), 1411139m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 20, 4, 0, 0, DateTimeKind.Local), 3121606m, new DateTime(2024, 4, 29, 17, 37, 0, 0, DateTimeKind.Local), 1153205m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 1, 17, 8, 0, 0, DateTimeKind.Local), 2623506m, new DateTime(2024, 5, 1, 10, 28, 0, 0, DateTimeKind.Local), 1029706m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 3, 15, 17, 0, 0, DateTimeKind.Local), 2929350m, new DateTime(2024, 5, 3, 10, 50, 0, 0, DateTimeKind.Local), 1491683m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 3, 12, 7, 0, 0, DateTimeKind.Local), 3083643m, new DateTime(2024, 5, 3, 5, 17, 0, 0, DateTimeKind.Local), 1318160m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 30, 10, 44, 0, 0, DateTimeKind.Local), 2578937m, new DateTime(2024, 4, 30, 7, 28, 0, 0, DateTimeKind.Local), 922378m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 3, 4, 9, 0, 0, DateTimeKind.Local), 2939390m, new DateTime(2024, 5, 2, 21, 8, 0, 0, DateTimeKind.Local), 892407m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 55, 0, 0, DateTimeKind.Local), 2630162m, new DateTime(2024, 5, 2, 5, 58, 0, 0, DateTimeKind.Local), 1056920m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 1, 3, 25, 0, 0, DateTimeKind.Local), 2928498m, new DateTime(2024, 4, 30, 23, 13, 0, 0, DateTimeKind.Local), 1414927m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 2, 17, 57, 0, 0, DateTimeKind.Local), 3404053m, new DateTime(2024, 5, 2, 12, 7, 0, 0, DateTimeKind.Local), 1344387m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 9, 9, 0, 0, DateTimeKind.Local), 3083515m, new DateTime(2024, 5, 1, 2, 48, 0, 0, DateTimeKind.Local), 808972m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 3, 58, 0, 0, DateTimeKind.Local), 3499886m, new DateTime(2024, 5, 2, 23, 42, 0, 0, DateTimeKind.Local), 1181492m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 2, 3, 24, 0, 0, DateTimeKind.Local), 2112366m, new DateTime(2024, 5, 1, 23, 40, 0, 0, DateTimeKind.Local), 862474m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 33, 0, 0, DateTimeKind.Local), 2678840m, new DateTime(2024, 5, 1, 15, 50, 0, 0, DateTimeKind.Local), 869847m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 5, 2, 0, 0, DateTimeKind.Local), 2442103m, new DateTime(2024, 5, 3, 3, 51, 0, 0, DateTimeKind.Local), 1312524m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 4, 5, 57, 0, 0, DateTimeKind.Local), 2150686m, new DateTime(2024, 5, 3, 23, 38, 0, 0, DateTimeKind.Local), 912765m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 3, 12, 57, 0, 0, DateTimeKind.Local), 2924549m, new DateTime(2024, 5, 3, 8, 43, 0, 0, DateTimeKind.Local), 1274777m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 2, 22, 23, 0, 0, DateTimeKind.Local), 2235269m, new DateTime(2024, 5, 2, 19, 18, 0, 0, DateTimeKind.Local), 1284255m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 4, 39, 0, 0, DateTimeKind.Local), 3213951m, new DateTime(2024, 4, 30, 23, 36, 0, 0, DateTimeKind.Local), 1195146m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 16, 53, 0, 0, DateTimeKind.Local), 2524859m, new DateTime(2024, 4, 29, 9, 57, 0, 0, DateTimeKind.Local), 1077850m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 2, 16, 27, 0, 0, DateTimeKind.Local), 3274293m, new DateTime(2024, 5, 2, 12, 5, 0, 0, DateTimeKind.Local), 801183m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 30, 19, 43, 0, 0, DateTimeKind.Local), 2875527m, new DateTime(2024, 4, 30, 13, 28, 0, 0, DateTimeKind.Local), 1353375m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 3, 6, 25, 0, 0, DateTimeKind.Local), 2433270m, new DateTime(2024, 5, 3, 0, 4, 0, 0, DateTimeKind.Local), 1440123m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 3, 1, 15, 0, 0, DateTimeKind.Local), 2736167m, new DateTime(2024, 5, 3, 0, 5, 0, 0, DateTimeKind.Local), 1038653m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 9, 32, 0, 0, DateTimeKind.Local), 2255263m, new DateTime(2024, 4, 30, 2, 37, 0, 0, DateTimeKind.Local), 860784m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 3, 12, 37, 0, 0, DateTimeKind.Local), 2725236m, new DateTime(2024, 5, 3, 6, 33, 0, 0, DateTimeKind.Local), 1048796m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 14, 34, 0, 0, DateTimeKind.Local), 2294218m, new DateTime(2024, 4, 29, 9, 40, 0, 0, DateTimeKind.Local), 1245825m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 5, 23, 0, 0, DateTimeKind.Local), 2980598m, new DateTime(2024, 5, 1, 2, 56, 0, 0, DateTimeKind.Local), 1410245m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 6, 15, 0, 0, DateTimeKind.Local), 3426729m, new DateTime(2024, 4, 29, 0, 59, 0, 0, DateTimeKind.Local), 1003272m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 30, 19, 11, 0, 0, DateTimeKind.Local), 2700954m, new DateTime(2024, 4, 30, 12, 21, 0, 0, DateTimeKind.Local), 1068081m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 1, 15, 40, 0, 0, DateTimeKind.Local), 2413169m, new DateTime(2024, 5, 1, 13, 26, 0, 0, DateTimeKind.Local), 825151m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 17, 38, 0, 0, DateTimeKind.Local), 2797316m, new DateTime(2024, 4, 29, 12, 37, 0, 0, DateTimeKind.Local), 1176574m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 1, 2, 13, 0, 0, DateTimeKind.Local), 2674346m, new DateTime(2024, 4, 30, 21, 36, 0, 0, DateTimeKind.Local), 1249167m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 4, 0, 49, 0, 0, DateTimeKind.Local), 2232189m, new DateTime(2024, 5, 3, 17, 41, 0, 0, DateTimeKind.Local), 821156m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 2, 7, 45, 0, 0, DateTimeKind.Local), 3042795m, new DateTime(2024, 5, 2, 5, 2, 0, 0, DateTimeKind.Local), 885956m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 18, 54, 0, 0, DateTimeKind.Local), 3281437m, new DateTime(2024, 5, 1, 14, 33, 0, 0, DateTimeKind.Local), 1114677m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 1, 2, 25, 0, 0, DateTimeKind.Local), 2414622m, new DateTime(2024, 4, 30, 20, 56, 0, 0, DateTimeKind.Local), 949239m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 4, 42, 0, 0, DateTimeKind.Local), 2111418m, new DateTime(2024, 5, 3, 1, 24, 0, 0, DateTimeKind.Local), 961053m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 2, 19, 14, 0, 0, DateTimeKind.Local), 2688575m, new DateTime(2024, 5, 2, 15, 15, 0, 0, DateTimeKind.Local), 1438277m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 19, 21, 0, 0, DateTimeKind.Local), 2694018m, new DateTime(2024, 5, 1, 16, 10, 0, 0, DateTimeKind.Local), 853609m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 9, 27, 0, 0, DateTimeKind.Local), 2766885m, new DateTime(2024, 5, 2, 2, 3, 0, 0, DateTimeKind.Local), 1269832m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 1, 18, 49, 0, 0, DateTimeKind.Local), 2951426m, new DateTime(2024, 5, 1, 13, 54, 0, 0, DateTimeKind.Local), 1043324m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 3, 17, 47, 0, 0, DateTimeKind.Local), 3051554m, new DateTime(2024, 5, 3, 12, 43, 0, 0, DateTimeKind.Local), 883917m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 14, 47, 0, 0, DateTimeKind.Local), 2789152m, new DateTime(2024, 5, 3, 13, 19, 0, 0, DateTimeKind.Local), 1398542m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 16, 58, 0, 0, DateTimeKind.Local), 2690549m, new DateTime(2024, 4, 29, 14, 29, 0, 0, DateTimeKind.Local), 1480697m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 30, 6, 7, 0, 0, DateTimeKind.Local), 2483599m, new DateTime(2024, 4, 30, 1, 58, 0, 0, DateTimeKind.Local), 984931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 2, 13, 2, 0, 0, DateTimeKind.Local), 2444324m, new DateTime(2024, 5, 2, 7, 16, 0, 0, DateTimeKind.Local), 1058827m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 1, 2, 47, 0, 0, DateTimeKind.Local), 2613927m, new DateTime(2024, 4, 30, 21, 12, 0, 0, DateTimeKind.Local), 1073485m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 11, 57, 0, 0, DateTimeKind.Local), 3354746m, new DateTime(2024, 4, 29, 4, 21, 0, 0, DateTimeKind.Local), 1472467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 2, 12, 58, 0, 0, DateTimeKind.Local), 2678360m, new DateTime(2024, 5, 2, 8, 55, 0, 0, DateTimeKind.Local), 819708m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 3, 10, 11, 0, 0, DateTimeKind.Local), 3473980m, new DateTime(2024, 5, 3, 7, 27, 0, 0, DateTimeKind.Local), 1005473m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 5, 26, 0, 0, DateTimeKind.Local), 2589698m, new DateTime(2024, 4, 29, 1, 49, 0, 0, DateTimeKind.Local), 1097183m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 2, 23, 19, 0, 0, DateTimeKind.Local), 3293683m, new DateTime(2024, 5, 2, 21, 17, 0, 0, DateTimeKind.Local), 1130212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 17, 59, 0, 0, DateTimeKind.Local), 3363794m, new DateTime(2024, 4, 29, 12, 25, 0, 0, DateTimeKind.Local), 991153m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 15, 20, 0, 0, DateTimeKind.Local), 3482202m, new DateTime(2024, 5, 1, 13, 56, 0, 0, DateTimeKind.Local), 964242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 18, 21, 0, 0, DateTimeKind.Local), 3021109m, new DateTime(2024, 5, 3, 13, 26, 0, 0, DateTimeKind.Local), 1261081m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 13, 48, 0, 0, DateTimeKind.Local), 2911722m, new DateTime(2024, 4, 29, 9, 42, 0, 0, DateTimeKind.Local), 988926m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 9, 36, 0, 0, DateTimeKind.Local), 2880947m, new DateTime(2024, 5, 2, 2, 16, 0, 0, DateTimeKind.Local), 1344678m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 3, 8, 34, 0, 0, DateTimeKind.Local), 2086681m, new DateTime(2024, 5, 3, 1, 25, 0, 0, DateTimeKind.Local), 1308680m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 8, 16, 0, 0, DateTimeKind.Local), 3109058m, new DateTime(2024, 4, 29, 3, 10, 0, 0, DateTimeKind.Local), 943157m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 2, 12, 30, 0, 0, DateTimeKind.Local), 2294498m, new DateTime(2024, 5, 2, 6, 25, 0, 0, DateTimeKind.Local), 1324369m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 14, 9, 0, 0, DateTimeKind.Local), 2677238m, new DateTime(2024, 5, 2, 10, 33, 0, 0, DateTimeKind.Local), 1434423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 9, 11, 0, 0, DateTimeKind.Local), 2624891m, new DateTime(2024, 5, 1, 7, 36, 0, 0, DateTimeKind.Local), 1071495m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 30, 4, 43, 0, 0, DateTimeKind.Local), 3107442m, new DateTime(2024, 4, 30, 0, 43, 0, 0, DateTimeKind.Local), 1220354m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 6, 9, 0, 0, DateTimeKind.Local), 2701713m, new DateTime(2024, 5, 1, 1, 15, 0, 0, DateTimeKind.Local), 1437977m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 5, 3, 18, 6, 0, 0, DateTimeKind.Local), 2231646m, new DateTime(2024, 5, 3, 13, 35, 0, 0, DateTimeKind.Local), 1206390m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 5, 42, 0, 0, DateTimeKind.Local), 3030651m, new DateTime(2024, 4, 30, 4, 25, 0, 0, DateTimeKind.Local), 1381081m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 4, 0, 28, 0, 0, DateTimeKind.Local), 3048697m, new DateTime(2024, 5, 3, 23, 16, 0, 0, DateTimeKind.Local), 1289021m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 1, 10, 35, 0, 0, DateTimeKind.Local), 3436911m, new DateTime(2024, 5, 1, 3, 48, 0, 0, DateTimeKind.Local), 1049236m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 19, 24, 0, 0, DateTimeKind.Local), 2640749m, new DateTime(2024, 4, 30, 15, 41, 0, 0, DateTimeKind.Local), 1036102m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 2, 3, 51, 0, 0, DateTimeKind.Local), 3147919m, new DateTime(2024, 5, 2, 0, 44, 0, 0, DateTimeKind.Local), 897082m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 30, 13, 34, 0, 0, DateTimeKind.Local), 2404359m, new DateTime(2024, 4, 30, 12, 34, 0, 0, DateTimeKind.Local), 899430m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 21, 9, 0, 0, DateTimeKind.Local), 3045931m, new DateTime(2024, 5, 1, 14, 14, 0, 0, DateTimeKind.Local), 816279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 5, 3, 12, 8, 0, 0, DateTimeKind.Local), 2516711m, new DateTime(2024, 5, 3, 8, 53, 0, 0, DateTimeKind.Local), 806320m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 30, 9, 18, 0, 0, DateTimeKind.Local), 2705930m, new DateTime(2024, 4, 30, 6, 29, 0, 0, DateTimeKind.Local), 963565m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 3, 10, 34, 0, 0, DateTimeKind.Local), 2940867m, new DateTime(2024, 5, 3, 9, 34, 0, 0, DateTimeKind.Local), 997029m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 6, 12, 0, 0, DateTimeKind.Local), 3436763m, new DateTime(2024, 4, 30, 1, 35, 0, 0, DateTimeKind.Local), 1058257m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 5, 1, 3, 21, 0, 0, DateTimeKind.Local), 3142552m, new DateTime(2024, 4, 30, 19, 23, 0, 0, DateTimeKind.Local), 1135722m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 29, 8, 4, 0, 0, DateTimeKind.Local), 2229134m, new DateTime(2024, 4, 29, 1, 57, 0, 0, DateTimeKind.Local), 1032281m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 23, 46, 0, 0, DateTimeKind.Local), 2655674m, new DateTime(2024, 4, 30, 17, 34, 0, 0, DateTimeKind.Local), 1142142m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 5, 1, 7, 20, 0, 0, DateTimeKind.Local), 2945844m, new DateTime(2024, 5, 1, 5, 42, 0, 0, DateTimeKind.Local), 961011m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 26, 0, 0, DateTimeKind.Local), 3038752m, new DateTime(2024, 5, 1, 0, 23, 0, 0, DateTimeKind.Local), 891077m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 19, 9, 0, 0, DateTimeKind.Local), 2347636m, new DateTime(2024, 4, 29, 17, 20, 0, 0, DateTimeKind.Local), 918212m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 20, 17, 0, 0, DateTimeKind.Local), 2827853m, new DateTime(2024, 4, 29, 12, 41, 0, 0, DateTimeKind.Local), 1257972m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 5, 4, 4, 18, 0, 0, DateTimeKind.Local), 3119763m, new DateTime(2024, 5, 3, 20, 34, 0, 0, DateTimeKind.Local), 1127432m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$MIMNWcumeGh1h92.Xe5cNePXhhfbC1jJeXWnrZwjGlfpHrGAMWaiy");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$m5ZUNFOZLtuh4kcM5iaHguJE0axlYNFe3SYt3vV.Mw2ER/brZZFtS");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "user@gmail.com",
                column: "Password",
                value: "$2a$13$n5EehFMMl2Jmz90UTP4qouXmDBB7xYn.Em1Q.rq/ddkGY9CrVOpDO");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 14, 57, 0, 0, DateTimeKind.Local), 2283724m, new DateTime(2024, 4, 25, 11, 2, 0, 0, DateTimeKind.Local), 1015305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 9, 23, 0, 0, DateTimeKind.Local), 2958882m, new DateTime(2024, 4, 25, 6, 55, 0, 0, DateTimeKind.Local), 915009m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 8, 43, 0, 0, DateTimeKind.Local), 2000173m, new DateTime(2024, 4, 27, 3, 36, 0, 0, DateTimeKind.Local), 1129088m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 20, 29, 0, 0, DateTimeKind.Local), 2032142m, new DateTime(2024, 4, 29, 17, 50, 0, 0, DateTimeKind.Local), 1080771m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 12, 1, 0, 0, DateTimeKind.Local), 2868083m, new DateTime(2024, 4, 25, 10, 37, 0, 0, DateTimeKind.Local), 1415957m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 14, 47, 0, 0, DateTimeKind.Local), 2755477m, new DateTime(2024, 4, 28, 9, 39, 0, 0, DateTimeKind.Local), 1003581m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 4, 4, 0, 0, DateTimeKind.Local), 3008736m, new DateTime(2024, 4, 25, 20, 53, 0, 0, DateTimeKind.Local), 920394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 12, 22, 0, 0, DateTimeKind.Local), 2994263m, new DateTime(2024, 4, 28, 10, 26, 0, 0, DateTimeKind.Local), 956657m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 30, 0, 26, 0, 0, DateTimeKind.Local), 2855908m, new DateTime(2024, 4, 29, 20, 15, 0, 0, DateTimeKind.Local), 1317735m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 28, 20, 33, 0, 0, DateTimeKind.Local), 2833054m, new DateTime(2024, 4, 28, 19, 20, 0, 0, DateTimeKind.Local), 898037m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 13, 3, 0, 0, DateTimeKind.Local), 2596345m, new DateTime(2024, 4, 26, 5, 40, 0, 0, DateTimeKind.Local), 1426042m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 12, 0, 0, 0, DateTimeKind.Local), 3297399m, new DateTime(2024, 4, 29, 4, 18, 0, 0, DateTimeKind.Local), 990927m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 27, 11, 52, 0, 0, DateTimeKind.Local), 3402611m, new DateTime(2024, 4, 27, 7, 57, 0, 0, DateTimeKind.Local), 1205669m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 27, 19, 16, 0, 0, DateTimeKind.Local), 2437990m, new DateTime(2024, 4, 27, 11, 40, 0, 0, DateTimeKind.Local), 1249801m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 8, 28, 0, 0, DateTimeKind.Local), 2017831m, new DateTime(2024, 4, 29, 3, 41, 0, 0, DateTimeKind.Local), 1021402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 27, 19, 4, 0, 0, DateTimeKind.Local), 3327737m, new DateTime(2024, 4, 27, 16, 48, 0, 0, DateTimeKind.Local), 1284135m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 8, 44, 0, 0, DateTimeKind.Local), 3428237m, new DateTime(2024, 4, 27, 5, 58, 0, 0, DateTimeKind.Local), 918520m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 21, 52, 0, 0, DateTimeKind.Local), 2950378m, new DateTime(2024, 4, 27, 16, 8, 0, 0, DateTimeKind.Local), 1373450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 21, 27, 0, 0, DateTimeKind.Local), 2377974m, new DateTime(2024, 4, 26, 18, 49, 0, 0, DateTimeKind.Local), 933213m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 2, 12, 0, 0, DateTimeKind.Local), 2823801m, new DateTime(2024, 4, 25, 22, 28, 0, 0, DateTimeKind.Local), 1196194m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 12, 27, 0, 0, DateTimeKind.Local), 3099189m, new DateTime(2024, 4, 29, 9, 6, 0, 0, DateTimeKind.Local), 1456730m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 14, 16, 0, 0, DateTimeKind.Local), 2786761m, new DateTime(2024, 4, 27, 7, 40, 0, 0, DateTimeKind.Local), 1190731m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 7, 52, 0, 0, DateTimeKind.Local), 2283329m, new DateTime(2024, 4, 27, 0, 28, 0, 0, DateTimeKind.Local), 1418869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 18, 28, 0, 0, DateTimeKind.Local), 2686397m, new DateTime(2024, 4, 27, 16, 16, 0, 0, DateTimeKind.Local), 1021203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 25, 21, 0, 0, 0, DateTimeKind.Local), 2471135m, new DateTime(2024, 4, 25, 19, 9, 0, 0, DateTimeKind.Local), 830708m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 6, 7, 0, 0, DateTimeKind.Local), 3331085m, new DateTime(2024, 4, 29, 3, 41, 0, 0, DateTimeKind.Local), 1157771m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 13, 20, 0, 0, DateTimeKind.Local), 2643038m, new DateTime(2024, 4, 29, 11, 28, 0, 0, DateTimeKind.Local), 1210643m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 27, 18, 32, 0, 0, DateTimeKind.Local), 3321991m, new DateTime(2024, 4, 27, 16, 7, 0, 0, DateTimeKind.Local), 1360113m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 13, 50, 0, 0, DateTimeKind.Local), 3079745m, new DateTime(2024, 4, 28, 10, 57, 0, 0, DateTimeKind.Local), 1027069m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 3, 24, 0, 0, DateTimeKind.Local), 3237271m, new DateTime(2024, 4, 29, 2, 3, 0, 0, DateTimeKind.Local), 815662m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 20, 31, 0, 0, DateTimeKind.Local), 2637885m, new DateTime(2024, 4, 29, 13, 7, 0, 0, DateTimeKind.Local), 920250m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 39, 0, 0, DateTimeKind.Local), 2138800m, new DateTime(2024, 4, 28, 6, 8, 0, 0, DateTimeKind.Local), 1193583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 26, 6, 57, 0, 0, DateTimeKind.Local), 3342811m, new DateTime(2024, 4, 25, 23, 49, 0, 0, DateTimeKind.Local), 1328563m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 1, 21, 0, 0, DateTimeKind.Local), 3089072m, new DateTime(2024, 4, 25, 19, 19, 0, 0, DateTimeKind.Local), 928938m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 27, 13, 7, 0, 0, DateTimeKind.Local), 2437947m, new DateTime(2024, 4, 27, 9, 19, 0, 0, DateTimeKind.Local), 929606m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 11, 9, 0, 0, DateTimeKind.Local), 2107690m, new DateTime(2024, 4, 28, 7, 24, 0, 0, DateTimeKind.Local), 1299997m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 13, 13, 0, 0, DateTimeKind.Local), 2155926m, new DateTime(2024, 4, 26, 11, 15, 0, 0, DateTimeKind.Local), 1339237m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 13, 28, 0, 0, DateTimeKind.Local), 2711954m, new DateTime(2024, 4, 29, 9, 45, 0, 0, DateTimeKind.Local), 1316176m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 17, 10, 0, 0, DateTimeKind.Local), 2180488m, new DateTime(2024, 4, 26, 14, 27, 0, 0, DateTimeKind.Local), 1481184m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 22, 44, 0, 0, DateTimeKind.Local), 3405560m, new DateTime(2024, 4, 27, 14, 51, 0, 0, DateTimeKind.Local), 1056975m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 23, 54, 0, 0, DateTimeKind.Local), 2428020m, new DateTime(2024, 4, 29, 21, 54, 0, 0, DateTimeKind.Local), 870420m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 7, 56, 0, 0, DateTimeKind.Local), 2395430m, new DateTime(2024, 4, 27, 0, 29, 0, 0, DateTimeKind.Local), 852174m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 15, 31, 0, 0, DateTimeKind.Local), 2692457m, new DateTime(2024, 4, 29, 10, 27, 0, 0, DateTimeKind.Local), 1148743m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 19, 45, 0, 0, DateTimeKind.Local), 2971596m, new DateTime(2024, 4, 29, 12, 42, 0, 0, DateTimeKind.Local), 1395912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 5, 57, 0, 0, DateTimeKind.Local), 2613300m, new DateTime(2024, 4, 28, 22, 43, 0, 0, DateTimeKind.Local), 1473177m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 11, 34, 0, 0, DateTimeKind.Local), 2064361m, new DateTime(2024, 4, 27, 6, 41, 0, 0, DateTimeKind.Local), 1322665m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 16, 54, 0, 0, DateTimeKind.Local), 2611641m, new DateTime(2024, 4, 26, 10, 19, 0, 0, DateTimeKind.Local), 940922m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 12, 10, 0, 0, DateTimeKind.Local), 3329501m, new DateTime(2024, 4, 26, 4, 35, 0, 0, DateTimeKind.Local), 855546m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 25, 12, 11, 0, 0, DateTimeKind.Local), 2334124m, new DateTime(2024, 4, 25, 9, 21, 0, 0, DateTimeKind.Local), 1445090m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 21, 27, 0, 0, DateTimeKind.Local), 3187594m, new DateTime(2024, 4, 28, 17, 14, 0, 0, DateTimeKind.Local), 1387160m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 15, 39, 0, 0, DateTimeKind.Local), 2231230m, new DateTime(2024, 4, 29, 12, 16, 0, 0, DateTimeKind.Local), 995657m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 5, 5, 0, 0, DateTimeKind.Local), 2450850m, new DateTime(2024, 4, 26, 3, 55, 0, 0, DateTimeKind.Local), 1031512m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 2, 16, 0, 0, DateTimeKind.Local), 2800846m, new DateTime(2024, 4, 27, 21, 32, 0, 0, DateTimeKind.Local), 1174176m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 22, 43, 0, 0, DateTimeKind.Local), 2458130m, new DateTime(2024, 4, 27, 18, 7, 0, 0, DateTimeKind.Local), 992254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 12, 47, 0, 0, DateTimeKind.Local), 3371529m, new DateTime(2024, 4, 25, 5, 24, 0, 0, DateTimeKind.Local), 884788m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 14, 0, 0, DateTimeKind.Local), 3170286m, new DateTime(2024, 4, 27, 14, 3, 0, 0, DateTimeKind.Local), 846700m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 5, 19, 0, 0, DateTimeKind.Local), 2680771m, new DateTime(2024, 4, 29, 1, 42, 0, 0, DateTimeKind.Local), 1022178m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 30, 2, 56, 0, 0, DateTimeKind.Local), 2145164m, new DateTime(2024, 4, 29, 20, 21, 0, 0, DateTimeKind.Local), 1084826m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 10, 7, 0, 0, DateTimeKind.Local), 2390722m, new DateTime(2024, 4, 29, 4, 30, 0, 0, DateTimeKind.Local), 1140354m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 6, 25, 0, 0, DateTimeKind.Local), 2152757m, new DateTime(2024, 4, 27, 2, 19, 0, 0, DateTimeKind.Local), 882041m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 14, 55, 0, 0, DateTimeKind.Local), 3196635m, new DateTime(2024, 4, 29, 10, 59, 0, 0, DateTimeKind.Local), 1497992m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 9, 33, 0, 0, DateTimeKind.Local), 3208992m, new DateTime(2024, 4, 26, 5, 10, 0, 0, DateTimeKind.Local), 912653m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 17, 33, 0, 0, DateTimeKind.Local), 2374667m, new DateTime(2024, 4, 28, 16, 16, 0, 0, DateTimeKind.Local), 914891m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 16, 36, 0, 0, DateTimeKind.Local), 2095872m, new DateTime(2024, 4, 28, 13, 46, 0, 0, DateTimeKind.Local), 1154358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 0, 34, 0, 0, DateTimeKind.Local), 3140075m, new DateTime(2024, 4, 28, 21, 52, 0, 0, DateTimeKind.Local), 958134m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 21, 30, 0, 0, DateTimeKind.Local), 3193920m, new DateTime(2024, 4, 28, 14, 7, 0, 0, DateTimeKind.Local), 1321265m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 6, 22, 0, 0, DateTimeKind.Local), 2244784m, new DateTime(2024, 4, 25, 0, 55, 0, 0, DateTimeKind.Local), 1111215m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 16, 44, 0, 0, DateTimeKind.Local), 2944308m, new DateTime(2024, 4, 25, 14, 54, 0, 0, DateTimeKind.Local), 1470500m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 29, 19, 6, 0, 0, DateTimeKind.Local), 2947836m, new DateTime(2024, 4, 29, 18, 2, 0, 0, DateTimeKind.Local), 1187458m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 10, 50, 0, 0, DateTimeKind.Local), 2392481m, new DateTime(2024, 4, 29, 5, 3, 0, 0, DateTimeKind.Local), 1083367m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 5, 36, 0, 0, DateTimeKind.Local), 2557717m, new DateTime(2024, 4, 27, 4, 7, 0, 0, DateTimeKind.Local), 1382099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 2, 33, 0, 0, DateTimeKind.Local), 2364808m, new DateTime(2024, 4, 27, 23, 26, 0, 0, DateTimeKind.Local), 1276696m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 21, 26, 0, 0, DateTimeKind.Local), 2564126m, new DateTime(2024, 4, 28, 18, 43, 0, 0, DateTimeKind.Local), 1107002m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 29, 0, 0, DateTimeKind.Local), 2580736m, new DateTime(2024, 4, 26, 6, 32, 0, 0, DateTimeKind.Local), 1479819m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 20, 59, 0, 0, DateTimeKind.Local), 2296296m, new DateTime(2024, 4, 26, 18, 20, 0, 0, DateTimeKind.Local), 953489m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 15, 16, 0, 0, DateTimeKind.Local), 3416573m, new DateTime(2024, 4, 27, 12, 54, 0, 0, DateTimeKind.Local), 1190909m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 17, 17, 0, 0, DateTimeKind.Local), 2964788m, new DateTime(2024, 4, 25, 11, 51, 0, 0, DateTimeKind.Local), 1180516m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 23, 29, 0, 0, DateTimeKind.Local), 3454927m, new DateTime(2024, 4, 25, 18, 51, 0, 0, DateTimeKind.Local), 825510m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 27, 7, 5, 0, 0, DateTimeKind.Local), 3253104m, new DateTime(2024, 4, 27, 3, 24, 0, 0, DateTimeKind.Local), 1176969m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 21, 19, 0, 0, DateTimeKind.Local), 3349451m, new DateTime(2024, 4, 28, 14, 7, 0, 0, DateTimeKind.Local), 1186614m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 25, 12, 16, 0, 0, DateTimeKind.Local), 3260037m, new DateTime(2024, 4, 25, 9, 59, 0, 0, DateTimeKind.Local), 1015707m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 32, 0, 0, DateTimeKind.Local), 3086365m, new DateTime(2024, 4, 29, 3, 56, 0, 0, DateTimeKind.Local), 1479794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 19, 49, 0, 0, DateTimeKind.Local), 3366680m, new DateTime(2024, 4, 29, 15, 54, 0, 0, DateTimeKind.Local), 1313901m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 29, 20, 12, 0, 0, DateTimeKind.Local), 2599338m, new DateTime(2024, 4, 29, 18, 50, 0, 0, DateTimeKind.Local), 1031997m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 29, 1, 9, 0, 0, DateTimeKind.Local), 2731614m, new DateTime(2024, 4, 28, 18, 32, 0, 0, DateTimeKind.Local), 915496m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 12, 4, 0, 0, DateTimeKind.Local), 2963290m, new DateTime(2024, 4, 25, 8, 33, 0, 0, DateTimeKind.Local), 1294972m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 20, 9, 0, 0, DateTimeKind.Local), 2036840m, new DateTime(2024, 4, 28, 13, 16, 0, 0, DateTimeKind.Local), 1181072m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 5, 19, 0, 0, DateTimeKind.Local), 2273308m, new DateTime(2024, 4, 29, 0, 12, 0, 0, DateTimeKind.Local), 1108369m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 29, 12, 53, 0, 0, DateTimeKind.Local), 3318476m, new DateTime(2024, 4, 29, 8, 59, 0, 0, DateTimeKind.Local), 1209757m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 1, 4, 0, 0, DateTimeKind.Local), 2721716m, new DateTime(2024, 4, 26, 19, 2, 0, 0, DateTimeKind.Local), 854652m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 18, 31, 0, 0, DateTimeKind.Local), 2983075m, new DateTime(2024, 4, 25, 14, 46, 0, 0, DateTimeKind.Local), 1326251m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 30, 1, 12, 0, 0, DateTimeKind.Local), 3195844m, new DateTime(2024, 4, 29, 21, 48, 0, 0, DateTimeKind.Local), 1136115m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 12, 44, 0, 0, DateTimeKind.Local), 2363100m, new DateTime(2024, 4, 25, 10, 49, 0, 0, DateTimeKind.Local), 1469613m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 12, 35, 0, 0, DateTimeKind.Local), 2032262m, new DateTime(2024, 4, 26, 10, 5, 0, 0, DateTimeKind.Local), 916501m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 7, 7, 0, 0, DateTimeKind.Local), 2141549m, new DateTime(2024, 4, 27, 23, 55, 0, 0, DateTimeKind.Local), 1306796m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 3, 13, 0, 0, DateTimeKind.Local), 3096741m, new DateTime(2024, 4, 25, 1, 48, 0, 0, DateTimeKind.Local), 1245520m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 0, 0, 0, DateTimeKind.Local), 3427466m, new DateTime(2024, 4, 25, 8, 31, 0, 0, DateTimeKind.Local), 921494m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 13, 50, 0, 0, DateTimeKind.Local), 2377069m, new DateTime(2024, 4, 25, 7, 46, 0, 0, DateTimeKind.Local), 1126279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 14, 38, 0, 0, DateTimeKind.Local), 3131697m, new DateTime(2024, 4, 25, 11, 4, 0, 0, DateTimeKind.Local), 1026891m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 10, 30, 0, 0, DateTimeKind.Local), 3222620m, new DateTime(2024, 4, 25, 5, 47, 0, 0, DateTimeKind.Local), 1203394m });
        }
    }
}
