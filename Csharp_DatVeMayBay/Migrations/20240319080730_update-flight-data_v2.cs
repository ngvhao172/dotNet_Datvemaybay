using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updateflightdata_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$r3WOXMSCimAeUWfn1bztFua1N/GwoONJwc1DaeY4YzVZMQwTnTb6S");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$UnxlAqjVknAS6FrOlVIrDOIx3HJ3K9qMfaeznjoY0QgUlinZW50oa");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 23, 10, 41, 0, 0, DateTimeKind.Local), 3353794m, new DateTime(2024, 3, 23, 5, 21, 0, 0, DateTimeKind.Local), 839959m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 13, 35, 0, 0, DateTimeKind.Local), 2887266m, new DateTime(2024, 3, 20, 10, 49, 0, 0, DateTimeKind.Local), 966513m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 24, 3, 12, 0, 0, DateTimeKind.Local), 2762656m, new DateTime(2024, 3, 23, 21, 36, 0, 0, DateTimeKind.Local), 932873m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 22, 22, 33, 0, 0, DateTimeKind.Local), 2488670m, new DateTime(2024, 3, 22, 19, 6, 0, 0, DateTimeKind.Local), 1141076m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 3, 22, 2, 2, 0, 0, DateTimeKind.Local), 2369912m, new DateTime(2024, 3, 21, 22, 46, 0, 0, DateTimeKind.Local), 1105218m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 23, 16, 27, 0, 0, DateTimeKind.Local), 2059480m, new DateTime(2024, 3, 23, 11, 11, 0, 0, DateTimeKind.Local), 836232m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 20, 19, 47, 0, 0, DateTimeKind.Local), 2750428m, new DateTime(2024, 3, 20, 13, 45, 0, 0, DateTimeKind.Local), 1090891m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 22, 5, 5, 0, 0, DateTimeKind.Local), 3154706m, new DateTime(2024, 3, 22, 3, 47, 0, 0, DateTimeKind.Local), 1345329m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 22, 5, 7, 0, 0, DateTimeKind.Local), 2063528m, new DateTime(2024, 3, 22, 0, 31, 0, 0, DateTimeKind.Local), 975590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 14, 11, 0, 0, DateTimeKind.Local), 2792376m, new DateTime(2024, 3, 20, 10, 15, 0, 0, DateTimeKind.Local), 887794m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 21, 7, 9, 0, 0, DateTimeKind.Local), 3499751m, new DateTime(2024, 3, 20, 23, 46, 0, 0, DateTimeKind.Local), 1405906m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 20, 12, 22, 0, 0, DateTimeKind.Local), 2260929m, new DateTime(2024, 3, 20, 5, 33, 0, 0, DateTimeKind.Local), 933230m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 23, 19, 44, 0, 0, DateTimeKind.Local), 2858328m, new DateTime(2024, 3, 23, 14, 34, 0, 0, DateTimeKind.Local), 1193474m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 21, 20, 34, 0, 0, DateTimeKind.Local), 2692660m, new DateTime(2024, 3, 21, 13, 3, 0, 0, DateTimeKind.Local), 1052400m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 23, 16, 10, 0, 0, DateTimeKind.Local), 3182255m, new DateTime(2024, 3, 23, 8, 25, 0, 0, DateTimeKind.Local), 1404550m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 3, 20, 4, 49, 0, 0, DateTimeKind.Local), 2090094m, new DateTime(2024, 3, 20, 2, 45, 0, 0, DateTimeKind.Local), 1386123m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 23, 14, 14, 0, 0, DateTimeKind.Local), 2220278m, new DateTime(2024, 3, 23, 10, 10, 0, 0, DateTimeKind.Local), 1017507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 22, 2, 51, 0, 0, DateTimeKind.Local), 2008288m, new DateTime(2024, 3, 21, 22, 8, 0, 0, DateTimeKind.Local), 827220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 3, 23, 21, 32, 0, 0, DateTimeKind.Local), 2449731m, new DateTime(2024, 3, 23, 15, 11, 0, 0, DateTimeKind.Local), 1401081m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 3, 19, 16, 12, 0, 0, DateTimeKind.Local), 2702017m, new DateTime(2024, 3, 19, 11, 2, 0, 0, DateTimeKind.Local), 1327415m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 19, 22, 30, 0, 0, DateTimeKind.Local), 2130239m, new DateTime(2024, 3, 19, 16, 46, 0, 0, DateTimeKind.Local), 964346m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 24, 7, 22, 0, 0, DateTimeKind.Local), 3342622m, new DateTime(2024, 3, 23, 23, 36, 0, 0, DateTimeKind.Local), 1443374m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 3, 19, 20, 26, 0, 0, DateTimeKind.Local), 2563260m, new DateTime(2024, 3, 19, 18, 42, 0, 0, DateTimeKind.Local), 1066103m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 23, 13, 26, 0, 0, DateTimeKind.Local), 2658978m, new DateTime(2024, 3, 23, 8, 18, 0, 0, DateTimeKind.Local), 935397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 22, 0, 35, 0, 0, DateTimeKind.Local), 2885664m, new DateTime(2024, 3, 21, 23, 15, 0, 0, DateTimeKind.Local), 1320524m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 8, 0, 0, DateTimeKind.Local), 2846337m, new DateTime(2024, 3, 22, 18, 19, 0, 0, DateTimeKind.Local), 1117865m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 3, 22, 1, 11, 0, 0, DateTimeKind.Local), 2177873m, new DateTime(2024, 3, 21, 17, 19, 0, 0, DateTimeKind.Local), 1305033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 21, 12, 30, 0, 0, DateTimeKind.Local), 2685966m, new DateTime(2024, 3, 21, 6, 10, 0, 0, DateTimeKind.Local), 1263201m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 7, 14, 0, 0, DateTimeKind.Local), 2084058m, new DateTime(2024, 3, 19, 23, 17, 0, 0, DateTimeKind.Local), 1098738m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 8, 57, 0, 0, DateTimeKind.Local), 2666646m, new DateTime(2024, 3, 20, 3, 9, 0, 0, DateTimeKind.Local), 970826m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 19, 12, 53, 0, 0, DateTimeKind.Local), 2479771m, new DateTime(2024, 3, 19, 10, 17, 0, 0, DateTimeKind.Local), 827835m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 0, 38, 0, 0, DateTimeKind.Local), 3016738m, new DateTime(2024, 3, 19, 21, 41, 0, 0, DateTimeKind.Local), 1436190m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 1, 16, 0, 0, DateTimeKind.Local), 2909750m, new DateTime(2024, 3, 19, 20, 51, 0, 0, DateTimeKind.Local), 1459957m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 22, 11, 26, 0, 0, DateTimeKind.Local), 2319310m, new DateTime(2024, 3, 22, 6, 32, 0, 0, DateTimeKind.Local), 801497m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 1, 59, 0, 0, DateTimeKind.Local), 3212429m, new DateTime(2024, 3, 19, 19, 29, 0, 0, DateTimeKind.Local), 1155238m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 22, 13, 16, 0, 0, DateTimeKind.Local), 3487546m, new DateTime(2024, 3, 22, 10, 49, 0, 0, DateTimeKind.Local), 1467356m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 3, 19, 19, 22, 0, 0, DateTimeKind.Local), 2460070m, new DateTime(2024, 3, 19, 11, 45, 0, 0, DateTimeKind.Local), 1337416m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 20, 4, 28, 0, 0, DateTimeKind.Local), 3455862m, new DateTime(2024, 3, 19, 21, 39, 0, 0, DateTimeKind.Local), 1405247m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 22, 1, 39, 0, 0, DateTimeKind.Local), 3024419m, new DateTime(2024, 3, 22, 0, 1, 0, 0, DateTimeKind.Local), 1249344m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 19, 18, 23, 0, 0, DateTimeKind.Local), 2550385m, new DateTime(2024, 3, 19, 10, 54, 0, 0, DateTimeKind.Local), 1428514m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 3, 23, 2, 12, 0, 0, DateTimeKind.Local), 2050070m, new DateTime(2024, 3, 22, 20, 49, 0, 0, DateTimeKind.Local), 812733m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 23, 23, 54, 0, 0, DateTimeKind.Local), 2876172m, new DateTime(2024, 3, 23, 21, 13, 0, 0, DateTimeKind.Local), 1344408m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 20, 12, 40, 0, 0, DateTimeKind.Local), 3405598m, new DateTime(2024, 3, 20, 6, 58, 0, 0, DateTimeKind.Local), 1030269m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 3, 21, 16, 18, 0, 0, DateTimeKind.Local), 2164222m, new DateTime(2024, 3, 21, 14, 3, 0, 0, DateTimeKind.Local), 1133235m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 3, 19, 17, 21, 0, 0, DateTimeKind.Local), 3210839m, new DateTime(2024, 3, 19, 13, 26, 0, 0, DateTimeKind.Local), 891537m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 21, 8, 16, 0, 0, DateTimeKind.Local), 2787070m, new DateTime(2024, 3, 21, 0, 26, 0, 0, DateTimeKind.Local), 1004262m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 21, 23, 28, 0, 0, DateTimeKind.Local), 3017820m, new DateTime(2024, 3, 21, 21, 22, 0, 0, DateTimeKind.Local), 801402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 3, 23, 7, 40, 0, 0, DateTimeKind.Local), 2295537m, new DateTime(2024, 3, 23, 1, 8, 0, 0, DateTimeKind.Local), 1146127m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 3, 21, 12, 13, 0, 0, DateTimeKind.Local), 2986275m, new DateTime(2024, 3, 21, 6, 36, 0, 0, DateTimeKind.Local), 1174470m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 3, 20, 14, 3, 0, 0, DateTimeKind.Local), 2875947m, new DateTime(2024, 3, 20, 11, 17, 0, 0, DateTimeKind.Local), 1324694m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$uQD16xQaAe45EOYXo2eyU.tDDoSRCe9I8OPruLTCEVqppgdx6QuPS");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$kyhbY2mjiF1ggJ2OgI.erO6jz1h9BeiLw4GIhW9i1f8yMu2NtiaPy");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 2, 16, 28, 0, 0, DateTimeKind.Local), 3250212m, new DateTime(2023, 12, 2, 13, 28, 0, 0, DateTimeKind.Local), 928690m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 11, 30, 6, 34, 0, 0, DateTimeKind.Local), 2113690m, new DateTime(2023, 11, 30, 1, 41, 0, 0, DateTimeKind.Local), 1283775m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 7, 36, 0, 0, DateTimeKind.Local), 2681523m, new DateTime(2023, 11, 30, 1, 43, 0, 0, DateTimeKind.Local), 1257999m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 11, 30, 2, 12, 0, 0, DateTimeKind.Local), 2838563m, new DateTime(2023, 11, 30, 0, 9, 0, 0, DateTimeKind.Local), 1450987m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 3, 18, 20, 0, 0, DateTimeKind.Local), 2717854m, new DateTime(2023, 12, 3, 15, 28, 0, 0, DateTimeKind.Local), 1467925m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 11, 30, 18, 41, 0, 0, DateTimeKind.Local), 2303592m, new DateTime(2023, 11, 30, 15, 47, 0, 0, DateTimeKind.Local), 804359m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 4, 21, 25, 0, 0, DateTimeKind.Local), 3208980m, new DateTime(2023, 12, 4, 20, 24, 0, 0, DateTimeKind.Local), 1306150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 1, 2, 47, 0, 0, DateTimeKind.Local), 2838276m, new DateTime(2023, 11, 30, 23, 24, 0, 0, DateTimeKind.Local), 1444999m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 1, 8, 55, 0, 0, DateTimeKind.Local), 2951708m, new DateTime(2023, 12, 1, 3, 47, 0, 0, DateTimeKind.Local), 1478351m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 3, 2, 11, 0, 0, DateTimeKind.Local), 2174478m, new DateTime(2023, 12, 2, 18, 42, 0, 0, DateTimeKind.Local), 1482214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 4, 2, 26, 0, 0, DateTimeKind.Local), 2656942m, new DateTime(2023, 12, 3, 20, 51, 0, 0, DateTimeKind.Local), 1132844m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 3, 14, 30, 0, 0, DateTimeKind.Local), 2653022m, new DateTime(2023, 12, 3, 7, 37, 0, 0, DateTimeKind.Local), 955509m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 7, 4, 0, 0, DateTimeKind.Local), 3174632m, new DateTime(2023, 12, 1, 4, 19, 0, 0, DateTimeKind.Local), 906872m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 2, 6, 7, 0, 0, DateTimeKind.Local), 3199080m, new DateTime(2023, 12, 2, 4, 1, 0, 0, DateTimeKind.Local), 1117357m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 11, 30, 14, 54, 0, 0, DateTimeKind.Local), 2142851m, new DateTime(2023, 11, 30, 11, 55, 0, 0, DateTimeKind.Local), 887110m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 4, 18, 21, 0, 0, DateTimeKind.Local), 2877650m, new DateTime(2023, 12, 4, 14, 23, 0, 0, DateTimeKind.Local), 864516m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 4, 22, 25, 0, 0, DateTimeKind.Local), 3081299m, new DateTime(2023, 12, 4, 15, 4, 0, 0, DateTimeKind.Local), 894037m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 2, 23, 43, 0, 0, DateTimeKind.Local), 2753662m, new DateTime(2023, 12, 2, 22, 21, 0, 0, DateTimeKind.Local), 1135716m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 2, 16, 15, 0, 0, DateTimeKind.Local), 3034226m, new DateTime(2023, 12, 2, 15, 4, 0, 0, DateTimeKind.Local), 1144343m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 19, 57, 0, 0, DateTimeKind.Local), 3499466m, new DateTime(2023, 12, 3, 18, 0, 0, 0, DateTimeKind.Local), 1478829m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 4, 19, 34, 0, 0, DateTimeKind.Local), 2456763m, new DateTime(2023, 12, 4, 17, 47, 0, 0, DateTimeKind.Local), 821241m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 23, 50, 0, 0, DateTimeKind.Local), 2090302m, new DateTime(2023, 12, 4, 20, 21, 0, 0, DateTimeKind.Local), 1473426m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 3, 6, 46, 0, 0, DateTimeKind.Local), 3255396m, new DateTime(2023, 12, 3, 3, 46, 0, 0, DateTimeKind.Local), 1397967m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 2, 15, 15, 0, 0, DateTimeKind.Local), 2280106m, new DateTime(2023, 12, 2, 9, 15, 0, 0, DateTimeKind.Local), 1155229m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 5, 0, 48, 0, 0, DateTimeKind.Local), 3458247m, new DateTime(2023, 12, 4, 22, 21, 0, 0, DateTimeKind.Local), 1295630m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 6, 45, 0, 0, DateTimeKind.Local), 2233649m, new DateTime(2023, 11, 30, 23, 9, 0, 0, DateTimeKind.Local), 1154955m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 4, 3, 36, 0, 0, DateTimeKind.Local), 2621722m, new DateTime(2023, 12, 3, 20, 55, 0, 0, DateTimeKind.Local), 801508m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 21, 13, 0, 0, DateTimeKind.Local), 2184647m, new DateTime(2023, 12, 1, 17, 0, 0, 0, DateTimeKind.Local), 1189886m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 3, 6, 58, 0, 0, DateTimeKind.Local), 2252226m, new DateTime(2023, 12, 3, 1, 1, 0, 0, DateTimeKind.Local), 1144395m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 21, 10, 0, 0, DateTimeKind.Local), 3063178m, new DateTime(2023, 12, 1, 19, 20, 0, 0, DateTimeKind.Local), 862410m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 7, 19, 0, 0, DateTimeKind.Local), 3107396m, new DateTime(2023, 12, 1, 5, 13, 0, 0, DateTimeKind.Local), 833315m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 1, 20, 52, 0, 0, DateTimeKind.Local), 2340570m, new DateTime(2023, 12, 1, 16, 19, 0, 0, DateTimeKind.Local), 1379383m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 2, 4, 21, 0, 0, DateTimeKind.Local), 2865162m, new DateTime(2023, 12, 2, 0, 13, 0, 0, DateTimeKind.Local), 1055852m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 5, 36, 0, 0, DateTimeKind.Local), 2251403m, new DateTime(2023, 12, 1, 1, 4, 0, 0, DateTimeKind.Local), 1449300m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 2, 1, 47, 0, 0, DateTimeKind.Local), 3145556m, new DateTime(2023, 12, 1, 18, 40, 0, 0, DateTimeKind.Local), 1204635m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 2, 16, 30, 0, 0, DateTimeKind.Local), 2662428m, new DateTime(2023, 12, 2, 12, 30, 0, 0, DateTimeKind.Local), 984443m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 1, 13, 53, 0, 0, DateTimeKind.Local), 2736697m, new DateTime(2023, 12, 1, 12, 31, 0, 0, DateTimeKind.Local), 1091686m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 6, 25, 0, 0, DateTimeKind.Local), 3225561m, new DateTime(2023, 12, 4, 0, 24, 0, 0, DateTimeKind.Local), 1072548m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 2, 6, 52, 0, 0, DateTimeKind.Local), 2655585m, new DateTime(2023, 12, 2, 2, 20, 0, 0, DateTimeKind.Local), 988818m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 22, 52, 0, 0, DateTimeKind.Local), 3190711m, new DateTime(2023, 12, 3, 15, 54, 0, 0, DateTimeKind.Local), 1315085m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 1, 11, 49, 0, 0, DateTimeKind.Local), 2748964m, new DateTime(2023, 12, 1, 5, 55, 0, 0, DateTimeKind.Local), 1442130m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 9, 46, 0, 0, DateTimeKind.Local), 2893234m, new DateTime(2023, 11, 30, 6, 24, 0, 0, DateTimeKind.Local), 813719m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 12, 3, 17, 18, 0, 0, DateTimeKind.Local), 2919398m, new DateTime(2023, 12, 3, 10, 1, 0, 0, DateTimeKind.Local), 800963m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 4, 21, 5, 0, 0, DateTimeKind.Local), 3487372m, new DateTime(2023, 12, 4, 16, 50, 0, 0, DateTimeKind.Local), 1086120m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 11, 30, 13, 48, 0, 0, DateTimeKind.Local), 3372665m, new DateTime(2023, 11, 30, 8, 12, 0, 0, DateTimeKind.Local), 1380394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 23, 7, 0, 0, DateTimeKind.Local), 3221747m, new DateTime(2023, 12, 4, 18, 10, 0, 0, DateTimeKind.Local), 1387286m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 11, 30, 18, 52, 0, 0, DateTimeKind.Local), 3193919m, new DateTime(2023, 11, 30, 12, 40, 0, 0, DateTimeKind.Local), 895970m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 3, 2, 15, 0, 0, DateTimeKind.Local), 2696441m, new DateTime(2023, 12, 2, 23, 44, 0, 0, DateTimeKind.Local), 1386483m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 19, 3, 0, 0, DateTimeKind.Local), 2340065m, new DateTime(2023, 12, 1, 17, 58, 0, 0, DateTimeKind.Local), 1021694m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 11, 30, 22, 31, 0, 0, DateTimeKind.Local), 3460361m, new DateTime(2023, 11, 30, 17, 25, 0, 0, DateTimeKind.Local), 1208625m });
        }
    }
}
