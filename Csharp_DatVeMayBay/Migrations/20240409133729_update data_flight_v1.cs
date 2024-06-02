using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updatedata_flight_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 11, 16, 31, 0, 0, DateTimeKind.Local), 2470062m, new DateTime(2024, 4, 11, 9, 41, 0, 0, DateTimeKind.Local), 1154005m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 10, 5, 34, 0, 0, DateTimeKind.Local), 2612234m, new DateTime(2024, 4, 9, 22, 45, 0, 0, DateTimeKind.Local), 1355476m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 10, 4, 0, 0, 0, DateTimeKind.Local), 2879562m, new DateTime(2024, 4, 9, 22, 45, 0, 0, DateTimeKind.Local), 1238581m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 11, 3, 1, 0, 0, DateTimeKind.Local), 2951827m, new DateTime(2024, 4, 10, 21, 25, 0, 0, DateTimeKind.Local), 969176m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 3, 5, 0, 0, DateTimeKind.Local), 3027939m, new DateTime(2024, 4, 11, 21, 34, 0, 0, DateTimeKind.Local), 1266569m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 14, 29, 0, 0, DateTimeKind.Local), 3341596m, new DateTime(2024, 4, 11, 10, 53, 0, 0, DateTimeKind.Local), 1398788m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 15, 42, 0, 0, DateTimeKind.Local), 2560626m, new DateTime(2024, 4, 10, 14, 27, 0, 0, DateTimeKind.Local), 1047268m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 13, 8, 2, 0, 0, DateTimeKind.Local), 2385108m, new DateTime(2024, 4, 13, 2, 29, 0, 0, DateTimeKind.Local), 1403112m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 10, 9, 17, 0, 0, DateTimeKind.Local), 3350865m, new DateTime(2024, 4, 10, 5, 35, 0, 0, DateTimeKind.Local), 1051090m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 11, 52, 0, 0, DateTimeKind.Local), 2451286m, new DateTime(2024, 4, 12, 8, 17, 0, 0, DateTimeKind.Local), 998076m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 5, 7, 0, 0, DateTimeKind.Local), 3031927m, new DateTime(2024, 4, 11, 22, 38, 0, 0, DateTimeKind.Local), 942679m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 13, 6, 55, 0, 0, DateTimeKind.Local), 2093682m, new DateTime(2024, 4, 13, 1, 27, 0, 0, DateTimeKind.Local), 1217336m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 9, 13, 7, 0, 0, DateTimeKind.Local), 2435063m, new DateTime(2024, 4, 9, 6, 18, 0, 0, DateTimeKind.Local), 980886m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 13, 21, 0, 0, DateTimeKind.Local), 3443563m, new DateTime(2024, 4, 13, 7, 8, 0, 0, DateTimeKind.Local), 840908m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 23, 0, 0, DateTimeKind.Local), 2098617m, new DateTime(2024, 4, 12, 18, 0, 0, 0, DateTimeKind.Local), 974444m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 13, 11, 6, 0, 0, DateTimeKind.Local), 3223285m, new DateTime(2024, 4, 13, 5, 11, 0, 0, DateTimeKind.Local), 1351450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 9, 16, 0, 0, DateTimeKind.Local), 3357576m, new DateTime(2024, 4, 13, 3, 55, 0, 0, DateTimeKind.Local), 1440218m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 2, 42, 0, 0, DateTimeKind.Local), 3032750m, new DateTime(2024, 4, 11, 19, 58, 0, 0, DateTimeKind.Local), 1180896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 18, 0, 0, DateTimeKind.Local), 3116797m, new DateTime(2024, 4, 10, 5, 21, 0, 0, DateTimeKind.Local), 1038505m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 10, 9, 0, 0, DateTimeKind.Local), 3240955m, new DateTime(2024, 4, 11, 7, 42, 0, 0, DateTimeKind.Local), 1059215m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 20, 32, 0, 0, DateTimeKind.Local), 3200218m, new DateTime(2024, 4, 12, 14, 20, 0, 0, DateTimeKind.Local), 895792m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 7, 56, 0, 0, DateTimeKind.Local), 2821324m, new DateTime(2024, 4, 12, 4, 18, 0, 0, DateTimeKind.Local), 1349046m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 11, 21, 0, 0, DateTimeKind.Local), 2268724m, new DateTime(2024, 4, 11, 3, 43, 0, 0, DateTimeKind.Local), 1416745m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 20, 5, 0, 0, DateTimeKind.Local), 2514418m, new DateTime(2024, 4, 11, 17, 45, 0, 0, DateTimeKind.Local), 1462537m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 20, 4, 0, 0, DateTimeKind.Local), 2317532m, new DateTime(2024, 4, 13, 17, 7, 0, 0, DateTimeKind.Local), 844578m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 10, 3, 7, 0, 0, DateTimeKind.Local), 2801080m, new DateTime(2024, 4, 10, 0, 38, 0, 0, DateTimeKind.Local), 1199230m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 10, 15, 28, 0, 0, DateTimeKind.Local), 2433597m, new DateTime(2024, 4, 10, 7, 31, 0, 0, DateTimeKind.Local), 1245887m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 13, 18, 35, 0, 0, DateTimeKind.Local), 3439869m, new DateTime(2024, 4, 13, 16, 24, 0, 0, DateTimeKind.Local), 1090450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 11, 21, 55, 0, 0, DateTimeKind.Local), 2906373m, new DateTime(2024, 4, 11, 18, 50, 0, 0, DateTimeKind.Local), 1428313m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 8, 14, 0, 0, DateTimeKind.Local), 2496603m, new DateTime(2024, 4, 12, 6, 36, 0, 0, DateTimeKind.Local), 1205434m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 11, 12, 58, 0, 0, DateTimeKind.Local), 3458057m, new DateTime(2024, 4, 11, 11, 45, 0, 0, DateTimeKind.Local), 1031948m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 19, 2, 0, 0, DateTimeKind.Local), 3053799m, new DateTime(2024, 4, 11, 16, 42, 0, 0, DateTimeKind.Local), 884904m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 22, 58, 0, 0, DateTimeKind.Local), 2965037m, new DateTime(2024, 4, 11, 18, 23, 0, 0, DateTimeKind.Local), 1095381m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 11, 0, 53, 0, 0, DateTimeKind.Local), 2041823m, new DateTime(2024, 4, 10, 21, 51, 0, 0, DateTimeKind.Local), 1233332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 13, 11, 54, 0, 0, DateTimeKind.Local), 2894561m, new DateTime(2024, 4, 13, 7, 26, 0, 0, DateTimeKind.Local), 908415m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 16, 51, 0, 0, DateTimeKind.Local), 2714983m, new DateTime(2024, 4, 10, 13, 56, 0, 0, DateTimeKind.Local), 974990m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 9, 15, 10, 0, 0, DateTimeKind.Local), 3375031m, new DateTime(2024, 4, 9, 8, 12, 0, 0, DateTimeKind.Local), 987247m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 9, 7, 8, 0, 0, DateTimeKind.Local), 3017072m, new DateTime(2024, 4, 9, 5, 50, 0, 0, DateTimeKind.Local), 813563m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 2, 35, 0, 0, DateTimeKind.Local), 2888158m, new DateTime(2024, 4, 11, 23, 6, 0, 0, DateTimeKind.Local), 1243934m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 11, 48, 0, 0, DateTimeKind.Local), 2837766m, new DateTime(2024, 4, 11, 10, 48, 0, 0, DateTimeKind.Local), 918226m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 2, 29, 0, 0, DateTimeKind.Local), 2896669m, new DateTime(2024, 4, 11, 19, 26, 0, 0, DateTimeKind.Local), 1156909m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 21, 2, 0, 0, DateTimeKind.Local), 2181020m, new DateTime(2024, 4, 13, 19, 49, 0, 0, DateTimeKind.Local), 1449896m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 14, 37, 0, 0, DateTimeKind.Local), 2595091m, new DateTime(2024, 4, 13, 7, 14, 0, 0, DateTimeKind.Local), 1194628m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 8, 3, 0, 0, DateTimeKind.Local), 2048490m, new DateTime(2024, 4, 11, 6, 31, 0, 0, DateTimeKind.Local), 1332547m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 23, 14, 0, 0, DateTimeKind.Local), 3098365m, new DateTime(2024, 4, 12, 16, 53, 0, 0, DateTimeKind.Local), 1263560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 5, 55, 0, 0, DateTimeKind.Local), 2466753m, new DateTime(2024, 4, 10, 22, 56, 0, 0, DateTimeKind.Local), 1209442m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 10, 0, 1, 0, 0, DateTimeKind.Local), 2647416m, new DateTime(2024, 4, 9, 16, 59, 0, 0, DateTimeKind.Local), 833037m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 50, 0, 0, DateTimeKind.Local), 3446792m, new DateTime(2024, 4, 13, 11, 27, 0, 0, DateTimeKind.Local), 1125991m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 10, 7, 7, 0, 0, DateTimeKind.Local), 3164443m, new DateTime(2024, 4, 10, 3, 51, 0, 0, DateTimeKind.Local), 965049m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 2, 39, 0, 0, DateTimeKind.Local), 2775511m, new DateTime(2024, 4, 10, 21, 40, 0, 0, DateTimeKind.Local), 1141293m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 10, 0, 37, 0, 0, DateTimeKind.Local), 2920449m, new DateTime(2024, 4, 9, 19, 3, 0, 0, DateTimeKind.Local), 1370358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 0, 2, 0, 0, DateTimeKind.Local), 3255067m, new DateTime(2024, 4, 11, 17, 18, 0, 0, DateTimeKind.Local), 865871m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 4, 0, 0, 0, DateTimeKind.Local), 2458172m, new DateTime(2024, 4, 10, 20, 54, 0, 0, DateTimeKind.Local), 809674m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 7, 52, 0, 0, DateTimeKind.Local), 2958111m, new DateTime(2024, 4, 12, 0, 17, 0, 0, DateTimeKind.Local), 955543m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 15, 56, 0, 0, DateTimeKind.Local), 2453807m, new DateTime(2024, 4, 12, 12, 11, 0, 0, DateTimeKind.Local), 883222m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 17, 14, 0, 0, DateTimeKind.Local), 3188028m, new DateTime(2024, 4, 12, 15, 16, 0, 0, DateTimeKind.Local), 1009455m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 9, 41, 0, 0, DateTimeKind.Local), 3323064m, new DateTime(2024, 4, 10, 6, 30, 0, 0, DateTimeKind.Local), 1146767m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 9, 12, 16, 0, 0, DateTimeKind.Local), 3005361m, new DateTime(2024, 4, 9, 10, 52, 0, 0, DateTimeKind.Local), 1499588m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 5, 55, 0, 0, DateTimeKind.Local), 3236995m, new DateTime(2024, 4, 11, 23, 9, 0, 0, DateTimeKind.Local), 1299916m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 10, 19, 2, 0, 0, DateTimeKind.Local), 2908348m, new DateTime(2024, 4, 10, 11, 35, 0, 0, DateTimeKind.Local), 957497m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 10, 24, 0, 0, DateTimeKind.Local), 3286973m, new DateTime(2024, 4, 10, 4, 49, 0, 0, DateTimeKind.Local), 1104309m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 13, 10, 5, 0, 0, DateTimeKind.Local), 2631900m, new DateTime(2024, 4, 13, 4, 26, 0, 0, DateTimeKind.Local), 1341638m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 9, 21, 45, 0, 0, DateTimeKind.Local), 3094358m, new DateTime(2024, 4, 9, 15, 34, 0, 0, DateTimeKind.Local), 941450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 2, 3, 0, 0, DateTimeKind.Local), 2237747m, new DateTime(2024, 4, 13, 20, 54, 0, 0, DateTimeKind.Local), 1241518m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 9, 2, 27, 0, 0, DateTimeKind.Local), 3361741m, new DateTime(2024, 4, 9, 0, 3, 0, 0, DateTimeKind.Local), 987596m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 12, 17, 0, 0, DateTimeKind.Local), 3214155m, new DateTime(2024, 4, 12, 8, 41, 0, 0, DateTimeKind.Local), 1314340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 18, 47, 0, 0, DateTimeKind.Local), 2809286m, new DateTime(2024, 4, 13, 16, 49, 0, 0, DateTimeKind.Local), 1260009m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 2, 41, 0, 0, DateTimeKind.Local), 3230626m, new DateTime(2024, 4, 11, 19, 52, 0, 0, DateTimeKind.Local), 859358m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 9, 17, 24, 0, 0, DateTimeKind.Local), 2467926m, new DateTime(2024, 4, 9, 12, 30, 0, 0, DateTimeKind.Local), 1177281m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 13, 53, 0, 0, DateTimeKind.Local), 2443077m, new DateTime(2024, 4, 13, 6, 28, 0, 0, DateTimeKind.Local), 1442238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 9, 7, 48, 0, 0, DateTimeKind.Local), 2810286m, new DateTime(2024, 4, 9, 2, 55, 0, 0, DateTimeKind.Local), 1152072m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 11, 15, 12, 0, 0, DateTimeKind.Local), 2990343m, new DateTime(2024, 4, 11, 8, 43, 0, 0, DateTimeKind.Local), 1329242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 9, 19, 56, 0, 0, DateTimeKind.Local), 2041346m, new DateTime(2024, 4, 9, 13, 54, 0, 0, DateTimeKind.Local), 1193425m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 10, 6, 42, 0, 0, DateTimeKind.Local), 2622234m, new DateTime(2024, 4, 10, 2, 15, 0, 0, DateTimeKind.Local), 1461448m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 11, 16, 59, 0, 0, DateTimeKind.Local), 3465808m, new DateTime(2024, 4, 11, 13, 39, 0, 0, DateTimeKind.Local), 1056906m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 8, 56, 0, 0, DateTimeKind.Local), 2150705m, new DateTime(2024, 4, 11, 7, 53, 0, 0, DateTimeKind.Local), 954652m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 11, 6, 58, 0, 0, DateTimeKind.Local), 2014913m, new DateTime(2024, 4, 11, 5, 36, 0, 0, DateTimeKind.Local), 1340723m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 6, 2, 0, 0, DateTimeKind.Local), 2550058m, new DateTime(2024, 4, 12, 3, 38, 0, 0, DateTimeKind.Local), 1289122m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 11, 1, 57, 0, 0, DateTimeKind.Local), 2478472m, new DateTime(2024, 4, 10, 20, 55, 0, 0, DateTimeKind.Local), 1465720m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 10, 2, 1, 0, 0, DateTimeKind.Local), 2278759m, new DateTime(2024, 4, 9, 19, 1, 0, 0, DateTimeKind.Local), 849647m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 23, 23, 0, 0, DateTimeKind.Local), 2089018m, new DateTime(2024, 4, 11, 18, 0, 0, 0, DateTimeKind.Local), 1125552m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 9, 17, 51, 0, 0, DateTimeKind.Local), 2520169m, new DateTime(2024, 4, 9, 10, 24, 0, 0, DateTimeKind.Local), 991525m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 12, 12, 34, 0, 0, DateTimeKind.Local), 2752082m, new DateTime(2024, 4, 12, 8, 25, 0, 0, DateTimeKind.Local), 1147249m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 37, 0, 0, DateTimeKind.Local), 3425479m, new DateTime(2024, 4, 12, 15, 0, 0, 0, DateTimeKind.Local), 1375047m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 20, 52, 0, 0, DateTimeKind.Local), 3173894m, new DateTime(2024, 4, 12, 15, 5, 0, 0, DateTimeKind.Local), 996699m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 19, 50, 0, 0, DateTimeKind.Local), 2964106m, new DateTime(2024, 4, 11, 15, 14, 0, 0, DateTimeKind.Local), 1112403m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 13, 7, 5, 0, 0, DateTimeKind.Local), 3314930m, new DateTime(2024, 4, 12, 23, 8, 0, 0, DateTimeKind.Local), 1337650m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 15, 57, 0, 0, DateTimeKind.Local), 2760031m, new DateTime(2024, 4, 10, 13, 31, 0, 0, DateTimeKind.Local), 1281948m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 13, 17, 33, 0, 0, DateTimeKind.Local), 2842491m, new DateTime(2024, 4, 13, 15, 14, 0, 0, DateTimeKind.Local), 942859m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 12, 17, 16, 0, 0, DateTimeKind.Local), 2005302m, new DateTime(2024, 4, 12, 11, 2, 0, 0, DateTimeKind.Local), 1098377m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 9, 9, 43, 0, 0, DateTimeKind.Local), 2248590m, new DateTime(2024, 4, 9, 7, 49, 0, 0, DateTimeKind.Local), 873833m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 13, 2, 32, 0, 0, DateTimeKind.Local), 2366382m, new DateTime(2024, 4, 12, 20, 3, 0, 0, DateTimeKind.Local), 1154118m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 9, 10, 13, 0, 0, DateTimeKind.Local), 2058151m, new DateTime(2024, 4, 9, 4, 31, 0, 0, DateTimeKind.Local), 984798m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 10, 6, 23, 0, 0, DateTimeKind.Local), 2252666m, new DateTime(2024, 4, 10, 2, 43, 0, 0, DateTimeKind.Local), 1241244m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 10, 21, 59, 0, 0, DateTimeKind.Local), 2259568m, new DateTime(2024, 4, 10, 16, 27, 0, 0, DateTimeKind.Local), 1008577m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 10, 4, 32, 0, 0, DateTimeKind.Local), 2482190m, new DateTime(2024, 4, 10, 0, 24, 0, 0, DateTimeKind.Local), 1406890m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 10, 15, 46, 0, 0, DateTimeKind.Local), 2824246m, new DateTime(2024, 4, 10, 14, 45, 0, 0, DateTimeKind.Local), 1496651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 10, 17, 44, 0, 0, DateTimeKind.Local), 2196183m, new DateTime(2024, 4, 10, 11, 53, 0, 0, DateTimeKind.Local), 1362339m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 12, 20, 15, 0, 0, DateTimeKind.Local), 2409416m, new DateTime(2024, 4, 12, 15, 22, 0, 0, DateTimeKind.Local), 901035m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 13, 15, 6, 0, 0, DateTimeKind.Local), 2396704m, new DateTime(2024, 4, 13, 13, 27, 0, 0, DateTimeKind.Local), 1367199m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$by7sPifptIJbhYV92l6AauA1pPt/d7G4Sk8z10fJlaljhuqf1pP2m");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$/LKwVQetihprQSh6TzJPluvhDNgHpZEVO46bzXwQ1RIRCFbi.ZR9K");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 8, 6, 27, 0, 0, DateTimeKind.Local), 2454476m, new DateTime(2024, 4, 8, 1, 35, 0, 0, DateTimeKind.Local), 1063305m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 4, 15, 7, 0, 0, DateTimeKind.Local), 2590204m, new DateTime(2024, 4, 4, 8, 4, 0, 0, DateTimeKind.Local), 1352805m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 42, 0, 0, DateTimeKind.Local), 2200641m, new DateTime(2024, 4, 4, 13, 57, 0, 0, DateTimeKind.Local), 1262561m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 7, 23, 24, 0, 0, DateTimeKind.Local), 2041858m, new DateTime(2024, 4, 7, 15, 42, 0, 0, DateTimeKind.Local), 1483892m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 9, 1, 20, 0, 0, DateTimeKind.Local), 3484691m, new DateTime(2024, 4, 8, 21, 21, 0, 0, DateTimeKind.Local), 904794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 8, 11, 13, 0, 0, DateTimeKind.Local), 2192094m, new DateTime(2024, 4, 8, 4, 11, 0, 0, DateTimeKind.Local), 1014270m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 8, 5, 35, 0, 0, DateTimeKind.Local), 3148521m, new DateTime(2024, 4, 8, 1, 49, 0, 0, DateTimeKind.Local), 1337276m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 9, 5, 3, 0, 0, DateTimeKind.Local), 3467889m, new DateTime(2024, 4, 8, 21, 30, 0, 0, DateTimeKind.Local), 1284809m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 5, 9, 46, 0, 0, DateTimeKind.Local), 2954109m, new DateTime(2024, 4, 5, 1, 51, 0, 0, DateTimeKind.Local), 984483m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 6, 7, 11, 0, 0, DateTimeKind.Local), 2360868m, new DateTime(2024, 4, 6, 4, 33, 0, 0, DateTimeKind.Local), 1382023m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 4, 17, 34, 0, 0, DateTimeKind.Local), 2817777m, new DateTime(2024, 4, 4, 13, 32, 0, 0, DateTimeKind.Local), 1334785m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 5, 10, 26, 0, 0, DateTimeKind.Local), 3386263m, new DateTime(2024, 4, 5, 6, 16, 0, 0, DateTimeKind.Local), 1056398m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 5, 0, 34, 0, 0, DateTimeKind.Local), 2085246m, new DateTime(2024, 4, 4, 18, 13, 0, 0, DateTimeKind.Local), 1119559m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 7, 22, 16, 0, 0, DateTimeKind.Local), 2817474m, new DateTime(2024, 4, 7, 18, 9, 0, 0, DateTimeKind.Local), 1415067m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 4, 8, 19, 0, 0, DateTimeKind.Local), 2779336m, new DateTime(2024, 4, 4, 1, 58, 0, 0, DateTimeKind.Local), 1146873m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 21, 30, 0, 0, DateTimeKind.Local), 2545969m, new DateTime(2024, 4, 5, 19, 22, 0, 0, DateTimeKind.Local), 1099279m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 23, 0, 0, DateTimeKind.Local), 2106842m, new DateTime(2024, 4, 6, 8, 37, 0, 0, DateTimeKind.Local), 1302661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 6, 21, 1, 0, 0, DateTimeKind.Local), 2428267m, new DateTime(2024, 4, 6, 14, 16, 0, 0, DateTimeKind.Local), 1261187m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 18, 54, 0, 0, DateTimeKind.Local), 3319602m, new DateTime(2024, 4, 7, 12, 19, 0, 0, DateTimeKind.Local), 1263621m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 4, 6, 27, 0, 0, DateTimeKind.Local), 2723889m, new DateTime(2024, 4, 4, 1, 8, 0, 0, DateTimeKind.Local), 1294650m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 7, 16, 6, 0, 0, DateTimeKind.Local), 3171545m, new DateTime(2024, 4, 7, 9, 33, 0, 0, DateTimeKind.Local), 998789m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 6, 4, 5, 0, 0, DateTimeKind.Local), 2779039m, new DateTime(2024, 4, 6, 0, 48, 0, 0, DateTimeKind.Local), 1406374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 54, 0, 0, DateTimeKind.Local), 2852616m, new DateTime(2024, 4, 5, 10, 48, 0, 0, DateTimeKind.Local), 898424m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 24, 0, 0, DateTimeKind.Local), 2930010m, new DateTime(2024, 4, 4, 17, 23, 0, 0, DateTimeKind.Local), 1396206m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 8, 18, 58, 0, 0, DateTimeKind.Local), 2390991m, new DateTime(2024, 4, 8, 15, 21, 0, 0, DateTimeKind.Local), 814669m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 51, 0, 0, DateTimeKind.Local), 2451234m, new DateTime(2024, 4, 7, 7, 16, 0, 0, DateTimeKind.Local), 1137034m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 8, 23, 33, 0, 0, DateTimeKind.Local), 3158938m, new DateTime(2024, 4, 8, 18, 26, 0, 0, DateTimeKind.Local), 1364994m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 4, 20, 0, 0, 0, DateTimeKind.Local), 2196099m, new DateTime(2024, 4, 4, 17, 42, 0, 0, DateTimeKind.Local), 982346m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 5, 11, 3, 0, 0, DateTimeKind.Local), 2058594m, new DateTime(2024, 4, 5, 3, 6, 0, 0, DateTimeKind.Local), 1015649m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 5, 7, 3, 0, 0, DateTimeKind.Local), 2772103m, new DateTime(2024, 4, 5, 4, 0, 0, 0, DateTimeKind.Local), 1495920m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 6, 1, 23, 0, 0, DateTimeKind.Local), 2099073m, new DateTime(2024, 4, 5, 18, 5, 0, 0, DateTimeKind.Local), 1030969m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 7, 0, 15, 0, 0, DateTimeKind.Local), 2848762m, new DateTime(2024, 4, 6, 23, 10, 0, 0, DateTimeKind.Local), 1396172m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 5, 17, 40, 0, 0, DateTimeKind.Local), 3066539m, new DateTime(2024, 4, 5, 12, 36, 0, 0, DateTimeKind.Local), 1069605m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 6, 14, 36, 0, 0, DateTimeKind.Local), 2938583m, new DateTime(2024, 4, 6, 8, 58, 0, 0, DateTimeKind.Local), 1385062m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 13, 58, 0, 0, DateTimeKind.Local), 2095866m, new DateTime(2024, 4, 5, 11, 6, 0, 0, DateTimeKind.Local), 1216673m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 8, 13, 59, 0, 0, DateTimeKind.Local), 2837171m, new DateTime(2024, 4, 8, 8, 49, 0, 0, DateTimeKind.Local), 1389775m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 4, 4, 56, 0, 0, DateTimeKind.Local), 2391213m, new DateTime(2024, 4, 4, 3, 10, 0, 0, DateTimeKind.Local), 971600m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 3, 0, 0, DateTimeKind.Local), 2609868m, new DateTime(2024, 4, 7, 9, 12, 0, 0, DateTimeKind.Local), 1279558m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 7, 14, 32, 0, 0, DateTimeKind.Local), 3118002m, new DateTime(2024, 4, 7, 6, 43, 0, 0, DateTimeKind.Local), 1499738m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 8, 19, 20, 0, 0, DateTimeKind.Local), 2464454m, new DateTime(2024, 4, 8, 13, 19, 0, 0, DateTimeKind.Local), 1453716m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 5, 6, 0, 0, 0, DateTimeKind.Local), 2295824m, new DateTime(2024, 4, 5, 4, 51, 0, 0, DateTimeKind.Local), 1117015m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 23, 9, 0, 0, DateTimeKind.Local), 2201659m, new DateTime(2024, 4, 7, 20, 30, 0, 0, DateTimeKind.Local), 1249622m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 4, 11, 45, 0, 0, DateTimeKind.Local), 3028997m, new DateTime(2024, 4, 4, 10, 24, 0, 0, DateTimeKind.Local), 813099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 22, 26, 0, 0, DateTimeKind.Local), 3426697m, new DateTime(2024, 4, 5, 15, 23, 0, 0, DateTimeKind.Local), 1415512m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 6, 11, 35, 0, 0, DateTimeKind.Local), 2396494m, new DateTime(2024, 4, 6, 8, 36, 0, 0, DateTimeKind.Local), 1153339m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 37, 0, 0, DateTimeKind.Local), 2686880m, new DateTime(2024, 4, 7, 12, 50, 0, 0, DateTimeKind.Local), 1457958m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 7, 15, 4, 0, 0, DateTimeKind.Local), 3304318m, new DateTime(2024, 4, 7, 8, 29, 0, 0, DateTimeKind.Local), 874432m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 8, 7, 21, 0, 0, DateTimeKind.Local), 2987872m, new DateTime(2024, 4, 8, 1, 56, 0, 0, DateTimeKind.Local), 883243m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 7, 5, 46, 0, 0, DateTimeKind.Local), 3459818m, new DateTime(2024, 4, 7, 4, 39, 0, 0, DateTimeKind.Local), 944669m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 6, 4, 16, 0, 0, DateTimeKind.Local), 2570762m, new DateTime(2024, 4, 6, 2, 10, 0, 0, DateTimeKind.Local), 1122780m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 7, 6, 52, 0, 0, DateTimeKind.Local), 2864062m, new DateTime(2024, 4, 7, 1, 8, 0, 0, DateTimeKind.Local), 1120609m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 8, 23, 41, 0, 0, DateTimeKind.Local), 3439593m, new DateTime(2024, 4, 8, 17, 37, 0, 0, DateTimeKind.Local), 1294727m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 6, 8, 49, 0, 0, DateTimeKind.Local), 2924585m, new DateTime(2024, 4, 6, 2, 29, 0, 0, DateTimeKind.Local), 1270224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 8, 21, 5, 0, 0, DateTimeKind.Local), 2366790m, new DateTime(2024, 4, 8, 18, 43, 0, 0, DateTimeKind.Local), 987072m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 6, 8, 11, 0, 0, DateTimeKind.Local), 2496028m, new DateTime(2024, 4, 6, 4, 44, 0, 0, DateTimeKind.Local), 1385669m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 6, 1, 31, 0, 0, DateTimeKind.Local), 2216464m, new DateTime(2024, 4, 5, 21, 15, 0, 0, DateTimeKind.Local), 902983m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 5, 5, 59, 0, 0, DateTimeKind.Local), 3268545m, new DateTime(2024, 4, 5, 2, 17, 0, 0, DateTimeKind.Local), 958415m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 8, 6, 57, 0, 0, DateTimeKind.Local), 2161879m, new DateTime(2024, 4, 8, 4, 56, 0, 0, DateTimeKind.Local), 1219482m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 9, 4, 3, 0, 0, DateTimeKind.Local), 2615555m, new DateTime(2024, 4, 8, 22, 39, 0, 0, DateTimeKind.Local), 1268706m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 6, 5, 20, 0, 0, DateTimeKind.Local), 2873332m, new DateTime(2024, 4, 6, 2, 9, 0, 0, DateTimeKind.Local), 880380m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 4, 21, 11, 0, 0, DateTimeKind.Local), 2080913m, new DateTime(2024, 4, 4, 13, 13, 0, 0, DateTimeKind.Local), 1077174m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 6, 0, 24, 0, 0, DateTimeKind.Local), 2645859m, new DateTime(2024, 4, 5, 20, 12, 0, 0, DateTimeKind.Local), 958876m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 6, 9, 30, 0, 0, DateTimeKind.Local), 2002868m, new DateTime(2024, 4, 6, 5, 26, 0, 0, DateTimeKind.Local), 1302450m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 7, 5, 45, 0, 0, DateTimeKind.Local), 3435643m, new DateTime(2024, 4, 6, 23, 18, 0, 0, DateTimeKind.Local), 911483m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 4, 16, 36, 0, 0, DateTimeKind.Local), 2854455m, new DateTime(2024, 4, 4, 9, 30, 0, 0, DateTimeKind.Local), 947772m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 6, 0, 0, DateTimeKind.Local), 2563783m, new DateTime(2024, 4, 7, 11, 34, 0, 0, DateTimeKind.Local), 1251458m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 8, 22, 6, 0, 0, DateTimeKind.Local), 2735716m, new DateTime(2024, 4, 8, 19, 0, 0, 0, DateTimeKind.Local), 1384692m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 5, 23, 48, 0, 0, DateTimeKind.Local), 2815748m, new DateTime(2024, 4, 5, 20, 43, 0, 0, DateTimeKind.Local), 1226118m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 6, 18, 13, 0, 0, DateTimeKind.Local), 2471428m, new DateTime(2024, 4, 6, 12, 51, 0, 0, DateTimeKind.Local), 817333m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 6, 1, 10, 0, 0, DateTimeKind.Local), 2506659m, new DateTime(2024, 4, 6, 0, 1, 0, 0, DateTimeKind.Local), 954242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 4, 13, 28, 0, 0, DateTimeKind.Local), 2556229m, new DateTime(2024, 4, 4, 5, 54, 0, 0, DateTimeKind.Local), 1124649m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 23, 39, 0, 0, DateTimeKind.Local), 2316652m, new DateTime(2024, 4, 5, 21, 36, 0, 0, DateTimeKind.Local), 1279883m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 4, 6, 12, 0, 0, DateTimeKind.Local), 2306796m, new DateTime(2024, 4, 4, 1, 54, 0, 0, DateTimeKind.Local), 1091917m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 4, 6, 38, 0, 0, DateTimeKind.Local), 2968351m, new DateTime(2024, 4, 4, 2, 16, 0, 0, DateTimeKind.Local), 892099m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 8, 12, 23, 0, 0, DateTimeKind.Local), 3216187m, new DateTime(2024, 4, 8, 5, 46, 0, 0, DateTimeKind.Local), 1158520m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 6, 21, 57, 0, 0, DateTimeKind.Local), 2967619m, new DateTime(2024, 4, 6, 19, 6, 0, 0, DateTimeKind.Local), 852998m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 5, 23, 53, 0, 0, DateTimeKind.Local), 2041534m, new DateTime(2024, 4, 5, 17, 45, 0, 0, DateTimeKind.Local), 852025m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 7, 16, 15, 0, 0, DateTimeKind.Local), 2509329m, new DateTime(2024, 4, 7, 13, 20, 0, 0, DateTimeKind.Local), 968166m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 6, 17, 38, 0, 0, DateTimeKind.Local), 2726730m, new DateTime(2024, 4, 6, 10, 43, 0, 0, DateTimeKind.Local), 1039122m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 4, 21, 5, 0, 0, DateTimeKind.Local), 3417497m, new DateTime(2024, 4, 4, 16, 28, 0, 0, DateTimeKind.Local), 1206335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 8, 7, 58, 0, 0, DateTimeKind.Local), 2070537m, new DateTime(2024, 4, 8, 5, 21, 0, 0, DateTimeKind.Local), 1122576m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 7, 0, 22, 0, 0, DateTimeKind.Local), 3158277m, new DateTime(2024, 4, 6, 19, 11, 0, 0, DateTimeKind.Local), 1002052m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 6, 13, 15, 0, 0, DateTimeKind.Local), 2123022m, new DateTime(2024, 4, 6, 7, 34, 0, 0, DateTimeKind.Local), 1118297m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 38, 0, 0, DateTimeKind.Local), 3199509m, new DateTime(2024, 4, 4, 18, 47, 0, 0, DateTimeKind.Local), 1479612m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 8, 9, 12, 0, 0, DateTimeKind.Local), 2579559m, new DateTime(2024, 4, 8, 3, 49, 0, 0, DateTimeKind.Local), 850977m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 5, 11, 27, 0, 0, DateTimeKind.Local), 2485191m, new DateTime(2024, 4, 5, 3, 50, 0, 0, DateTimeKind.Local), 1267557m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 8, 5, 8, 0, 0, DateTimeKind.Local), 3188761m, new DateTime(2024, 4, 7, 21, 47, 0, 0, DateTimeKind.Local), 1284440m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 7, 7, 7, 0, 0, DateTimeKind.Local), 2416785m, new DateTime(2024, 4, 7, 3, 42, 0, 0, DateTimeKind.Local), 1329899m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 7, 4, 19, 0, 0, DateTimeKind.Local), 2736139m, new DateTime(2024, 4, 6, 23, 18, 0, 0, DateTimeKind.Local), 1354311m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 9, 0, 18, 0, 0, DateTimeKind.Local), 2890511m, new DateTime(2024, 4, 8, 18, 0, 0, 0, DateTimeKind.Local), 1116966m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 8, 15, 13, 0, 0, DateTimeKind.Local), 2910075m, new DateTime(2024, 4, 8, 8, 43, 0, 0, DateTimeKind.Local), 1012559m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 8, 18, 37, 0, 0, DateTimeKind.Local), 2505561m, new DateTime(2024, 4, 8, 11, 51, 0, 0, DateTimeKind.Local), 902319m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 7, 17, 27, 0, 0, DateTimeKind.Local), 2825548m, new DateTime(2024, 4, 7, 15, 54, 0, 0, DateTimeKind.Local), 1446438m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 8, 22, 46, 0, 0, DateTimeKind.Local), 2909359m, new DateTime(2024, 4, 8, 15, 52, 0, 0, DateTimeKind.Local), 1486701m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 5, 2, 0, 0, 0, DateTimeKind.Local), 2459263m, new DateTime(2024, 4, 5, 0, 31, 0, 0, DateTimeKind.Local), 877590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 5, 11, 44, 0, 0, DateTimeKind.Local), 2867653m, new DateTime(2024, 4, 5, 5, 24, 0, 0, DateTimeKind.Local), 1345627m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 5, 11, 52, 0, 0, DateTimeKind.Local), 3222684m, new DateTime(2024, 4, 5, 10, 35, 0, 0, DateTimeKind.Local), 1179557m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 7, 14, 22, 0, 0, DateTimeKind.Local), 2018320m, new DateTime(2024, 4, 7, 12, 10, 0, 0, DateTimeKind.Local), 980978m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 4, 12, 35, 0, 0, DateTimeKind.Local), 3220243m, new DateTime(2024, 4, 4, 7, 50, 0, 0, DateTimeKind.Local), 824466m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 4, 16, 41, 0, 0, DateTimeKind.Local), 2679776m, new DateTime(2024, 4, 4, 12, 42, 0, 0, DateTimeKind.Local), 1296640m });
        }
    }
}
