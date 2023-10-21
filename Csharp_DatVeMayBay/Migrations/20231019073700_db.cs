using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$9S07o92BELWyXD0CwKmFduxC434LadnXd6wJWwcRc.cq9GSpa08G6");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$6HDJxto6o1xnbqX3.h5ka.tKbRI..27VII9wZvqhyzRFG/apfQowS");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 8, 24, 0, 0, DateTimeKind.Local), 3035086m, new DateTime(2023, 10, 23, 4, 26, 0, 0, DateTimeKind.Local), 947564m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 23, 2, 0, 0, DateTimeKind.Local), 3157264m, new DateTime(2023, 10, 22, 21, 4, 0, 0, DateTimeKind.Local), 840583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 11, 25, 0, 0, DateTimeKind.Local), 2352022m, new DateTime(2023, 10, 22, 5, 30, 0, 0, DateTimeKind.Local), 1383282m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 22, 1, 0, 0, DateTimeKind.Local), 2461137m, new DateTime(2023, 10, 20, 17, 54, 0, 0, DateTimeKind.Local), 920789m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 3, 48, 0, 0, DateTimeKind.Local), 2539978m, new DateTime(2023, 10, 21, 21, 24, 0, 0, DateTimeKind.Local), 1439682m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 5, 27, 0, 0, DateTimeKind.Local), 2045213m, new DateTime(2023, 10, 19, 22, 2, 0, 0, DateTimeKind.Local), 1376059m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 14, 47, 0, 0, DateTimeKind.Local), 2447641m, new DateTime(2023, 10, 20, 11, 27, 0, 0, DateTimeKind.Local), 1166944m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 1, 1, 0, 0, DateTimeKind.Local), 2845011m, new DateTime(2023, 10, 20, 23, 7, 0, 0, DateTimeKind.Local), 1293452m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 22, 29, 0, 0, DateTimeKind.Local), 3466222m, new DateTime(2023, 10, 20, 18, 18, 0, 0, DateTimeKind.Local), 819061m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 23, 30, 0, 0, DateTimeKind.Local), 2154469m, new DateTime(2023, 10, 23, 16, 53, 0, 0, DateTimeKind.Local), 804798m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 21, 7, 59, 0, 0, DateTimeKind.Local), 3035258m, new DateTime(2023, 10, 21, 0, 34, 0, 0, DateTimeKind.Local), 1256625m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 19, 3, 22, 0, 0, DateTimeKind.Local), 2850567m, new DateTime(2023, 10, 19, 0, 48, 0, 0, DateTimeKind.Local), 1268423m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 11, 22, 0, 0, DateTimeKind.Local), 2819519m, new DateTime(2023, 10, 20, 9, 2, 0, 0, DateTimeKind.Local), 1031411m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 1, 56, 0, 0, DateTimeKind.Local), 2957116m, new DateTime(2023, 10, 21, 22, 57, 0, 0, DateTimeKind.Local), 1323646m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 0, 36, 0, 0, DateTimeKind.Local), 2516542m, new DateTime(2023, 10, 19, 18, 40, 0, 0, DateTimeKind.Local), 873115m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 0, 36, 0, 0, DateTimeKind.Local), 3470700m, new DateTime(2023, 10, 19, 18, 49, 0, 0, DateTimeKind.Local), 1244217m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 3, 53, 0, 0, DateTimeKind.Local), 2935730m, new DateTime(2023, 10, 21, 2, 21, 0, 0, DateTimeKind.Local), 973332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 19, 14, 14, 0, 0, DateTimeKind.Local), 2356307m, new DateTime(2023, 10, 19, 8, 26, 0, 0, DateTimeKind.Local), 1260420m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 19, 22, 14, 0, 0, DateTimeKind.Local), 2533786m, new DateTime(2023, 10, 19, 18, 30, 0, 0, DateTimeKind.Local), 1311571m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 1, 5, 0, 0, DateTimeKind.Local), 3169286m, new DateTime(2023, 10, 19, 17, 25, 0, 0, DateTimeKind.Local), 1387754m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 22, 8, 0, 0, DateTimeKind.Local), 2796987m, new DateTime(2023, 10, 22, 19, 37, 0, 0, DateTimeKind.Local), 1406656m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 16, 52, 0, 0, DateTimeKind.Local), 2494328m, new DateTime(2023, 10, 21, 10, 58, 0, 0, DateTimeKind.Local), 878875m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 19, 58, 0, 0, DateTimeKind.Local), 3228129m, new DateTime(2023, 10, 22, 18, 14, 0, 0, DateTimeKind.Local), 948817m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 2, 52, 0, 0, DateTimeKind.Local), 2442420m, new DateTime(2023, 10, 20, 19, 31, 0, 0, DateTimeKind.Local), 1442456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 21, 30, 0, 0, DateTimeKind.Local), 2471437m, new DateTime(2023, 10, 22, 17, 45, 0, 0, DateTimeKind.Local), 1435195m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 3, 46, 0, 0, DateTimeKind.Local), 3309180m, new DateTime(2023, 10, 22, 21, 1, 0, 0, DateTimeKind.Local), 1374333m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 17, 38, 0, 0, DateTimeKind.Local), 3346174m, new DateTime(2023, 10, 20, 15, 4, 0, 0, DateTimeKind.Local), 1253657m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 0, 47, 0, 0, DateTimeKind.Local), 3069806m, new DateTime(2023, 10, 19, 16, 58, 0, 0, DateTimeKind.Local), 1001313m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 23, 0, 27, 0, 0, DateTimeKind.Local), 2929643m, new DateTime(2023, 10, 22, 17, 51, 0, 0, DateTimeKind.Local), 1216231m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 43, 0, 0, DateTimeKind.Local), 2557523m, new DateTime(2023, 10, 19, 22, 49, 0, 0, DateTimeKind.Local), 1158192m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 10, 36, 0, 0, DateTimeKind.Local), 3250062m, new DateTime(2023, 10, 19, 9, 35, 0, 0, DateTimeKind.Local), 1425050m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 9, 19, 0, 0, DateTimeKind.Local), 2446554m, new DateTime(2023, 10, 23, 6, 42, 0, 0, DateTimeKind.Local), 1302931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 19, 15, 44, 0, 0, DateTimeKind.Local), 3196083m, new DateTime(2023, 10, 19, 9, 26, 0, 0, DateTimeKind.Local), 1147886m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 19, 12, 44, 0, 0, DateTimeKind.Local), 2758011m, new DateTime(2023, 10, 19, 6, 41, 0, 0, DateTimeKind.Local), 1161683m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 19, 18, 50, 0, 0, DateTimeKind.Local), 3053141m, new DateTime(2023, 10, 19, 14, 21, 0, 0, DateTimeKind.Local), 828823m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 19, 10, 53, 0, 0, DateTimeKind.Local), 3119956m, new DateTime(2023, 10, 19, 7, 11, 0, 0, DateTimeKind.Local), 892174m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 11, 12, 0, 0, DateTimeKind.Local), 2949666m, new DateTime(2023, 10, 22, 3, 33, 0, 0, DateTimeKind.Local), 1484507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 22, 18, 26, 0, 0, DateTimeKind.Local), 3381758m, new DateTime(2023, 10, 22, 12, 28, 0, 0, DateTimeKind.Local), 1408631m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 2, 37, 0, 0, DateTimeKind.Local), 2391720m, new DateTime(2023, 10, 20, 20, 50, 0, 0, DateTimeKind.Local), 1247156m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 4, 1, 0, 0, DateTimeKind.Local), 2324492m, new DateTime(2023, 10, 22, 0, 36, 0, 0, DateTimeKind.Local), 1395531m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 19, 23, 24, 0, 0, DateTimeKind.Local), 2158227m, new DateTime(2023, 10, 19, 15, 25, 0, 0, DateTimeKind.Local), 972795m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 19, 21, 33, 0, 0, DateTimeKind.Local), 2593507m, new DateTime(2023, 10, 19, 16, 4, 0, 0, DateTimeKind.Local), 1026520m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 21, 14, 0, 0, DateTimeKind.Local), 3151171m, new DateTime(2023, 10, 19, 16, 36, 0, 0, DateTimeKind.Local), 863846m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 21, 20, 0, 0, DateTimeKind.Local), 3200857m, new DateTime(2023, 10, 22, 15, 26, 0, 0, DateTimeKind.Local), 1098852m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 21, 48, 0, 0, DateTimeKind.Local), 2494083m, new DateTime(2023, 10, 22, 15, 6, 0, 0, DateTimeKind.Local), 872271m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 21, 18, 44, 0, 0, DateTimeKind.Local), 2072993m, new DateTime(2023, 10, 21, 10, 51, 0, 0, DateTimeKind.Local), 1449219m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 22, 0, 3, 0, 0, DateTimeKind.Local), 2680135m, new DateTime(2023, 10, 21, 20, 57, 0, 0, DateTimeKind.Local), 1345912m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 13, 38, 0, 0, DateTimeKind.Local), 3333983m, new DateTime(2023, 10, 22, 8, 59, 0, 0, DateTimeKind.Local), 1240757m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 20, 6, 11, 0, 0, DateTimeKind.Local), 2550560m, new DateTime(2023, 10, 20, 3, 7, 0, 0, DateTimeKind.Local), 1418191m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 1, 2, 0, 0, DateTimeKind.Local), 2489611m, new DateTime(2023, 10, 20, 17, 54, 0, 0, DateTimeKind.Local), 1238822m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$Z4vFUPLeU4pi6ziSIwTK9ekvopX1AWJgTMTTAEGaezsxplrMmlUeO");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$l/pWlkmYp7Gv6WKZ.VHsa.uDsBhoOZAc3eH7x5NgnrsSoQ2.4UXqO");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 19, 21, 49, 0, 0, DateTimeKind.Local), 2479469m, new DateTime(2023, 10, 19, 20, 16, 0, 0, DateTimeKind.Local), 1297678m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 7, 1, 0, 0, DateTimeKind.Local), 2555399m, new DateTime(2023, 10, 23, 4, 54, 0, 0, DateTimeKind.Local), 1125389m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 20, 7, 56, 0, 0, DateTimeKind.Local), 2560437m, new DateTime(2023, 10, 20, 4, 22, 0, 0, DateTimeKind.Local), 1212318m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 3, 0, 0, 0, DateTimeKind.Local), 2601244m, new DateTime(2023, 10, 21, 1, 25, 0, 0, DateTimeKind.Local), 1354034m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 22, 6, 0, 0, DateTimeKind.Local), 3495148m, new DateTime(2023, 10, 22, 15, 55, 0, 0, DateTimeKind.Local), 817770m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 22, 1, 47, 0, 0, DateTimeKind.Local), 2731864m, new DateTime(2023, 10, 21, 20, 22, 0, 0, DateTimeKind.Local), 1462181m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 8, 5, 0, 0, DateTimeKind.Local), 3344265m, new DateTime(2023, 10, 22, 5, 38, 0, 0, DateTimeKind.Local), 841560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 20, 16, 43, 0, 0, DateTimeKind.Local), 2931965m, new DateTime(2023, 10, 20, 10, 57, 0, 0, DateTimeKind.Local), 1190712m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 2, 16, 0, 0, DateTimeKind.Local), 2202485m, new DateTime(2023, 10, 21, 1, 12, 0, 0, DateTimeKind.Local), 877365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 15, 26, 0, 0, DateTimeKind.Local), 2945834m, new DateTime(2023, 10, 22, 9, 28, 0, 0, DateTimeKind.Local), 1277661m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 10, 17, 0, 0, DateTimeKind.Local), 2559885m, new DateTime(2023, 10, 20, 2, 19, 0, 0, DateTimeKind.Local), 1190897m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 23, 1, 57, 0, 0, DateTimeKind.Local), 2181158m, new DateTime(2023, 10, 23, 0, 9, 0, 0, DateTimeKind.Local), 1065220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 23, 7, 13, 0, 0, DateTimeKind.Local), 2656687m, new DateTime(2023, 10, 23, 4, 5, 0, 0, DateTimeKind.Local), 1180507m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 9, 51, 0, 0, DateTimeKind.Local), 2792839m, new DateTime(2023, 10, 23, 6, 43, 0, 0, DateTimeKind.Local), 1082588m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 23, 35, 0, 0, DateTimeKind.Local), 3378831m, new DateTime(2023, 10, 21, 16, 40, 0, 0, DateTimeKind.Local), 867726m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 23, 19, 4, 0, 0, DateTimeKind.Local), 2483176m, new DateTime(2023, 10, 23, 13, 21, 0, 0, DateTimeKind.Local), 980018m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 12, 33, 0, 0, DateTimeKind.Local), 3049850m, new DateTime(2023, 10, 23, 6, 17, 0, 0, DateTimeKind.Local), 1124782m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 23, 21, 5, 0, 0, DateTimeKind.Local), 2719597m, new DateTime(2023, 10, 23, 17, 11, 0, 0, DateTimeKind.Local), 1378691m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 13, 43, 0, 0, DateTimeKind.Local), 2743760m, new DateTime(2023, 10, 23, 7, 41, 0, 0, DateTimeKind.Local), 961847m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 18, 2, 0, 0, DateTimeKind.Local), 2891508m, new DateTime(2023, 10, 22, 13, 35, 0, 0, DateTimeKind.Local), 965141m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 18, 45, 0, 0, DateTimeKind.Local), 3184306m, new DateTime(2023, 10, 20, 16, 22, 0, 0, DateTimeKind.Local), 1445590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 14, 36, 0, 0, DateTimeKind.Local), 3098167m, new DateTime(2023, 10, 19, 7, 2, 0, 0, DateTimeKind.Local), 1330575m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 16, 21, 0, 0, DateTimeKind.Local), 3076467m, new DateTime(2023, 10, 22, 11, 49, 0, 0, DateTimeKind.Local), 1386974m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 19, 6, 38, 0, 0, DateTimeKind.Local), 2669694m, new DateTime(2023, 10, 19, 2, 29, 0, 0, DateTimeKind.Local), 1194872m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 19, 17, 41, 0, 0, DateTimeKind.Local), 2693308m, new DateTime(2023, 10, 19, 14, 30, 0, 0, DateTimeKind.Local), 901460m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 16, 48, 0, 0, DateTimeKind.Local), 2885824m, new DateTime(2023, 10, 21, 9, 5, 0, 0, DateTimeKind.Local), 1305984m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 19, 5, 0, 0, DateTimeKind.Local), 2136192m, new DateTime(2023, 10, 20, 16, 43, 0, 0, DateTimeKind.Local), 1088772m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 23, 22, 38, 0, 0, DateTimeKind.Local), 3004903m, new DateTime(2023, 10, 23, 15, 4, 0, 0, DateTimeKind.Local), 1377033m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 19, 15, 24, 0, 0, DateTimeKind.Local), 2177682m, new DateTime(2023, 10, 19, 12, 57, 0, 0, DateTimeKind.Local), 1031901m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 14, 15, 0, 0, DateTimeKind.Local), 3262227m, new DateTime(2023, 10, 21, 6, 41, 0, 0, DateTimeKind.Local), 1123681m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 11, 34, 0, 0, DateTimeKind.Local), 2222944m, new DateTime(2023, 10, 21, 8, 16, 0, 0, DateTimeKind.Local), 852935m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 13, 55, 0, 0, DateTimeKind.Local), 3074825m, new DateTime(2023, 10, 20, 8, 22, 0, 0, DateTimeKind.Local), 1006706m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 21, 11, 43, 0, 0, DateTimeKind.Local), 2524832m, new DateTime(2023, 10, 21, 5, 19, 0, 0, DateTimeKind.Local), 937444m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 19, 21, 47, 0, 0, DateTimeKind.Local), 2087952m, new DateTime(2023, 10, 19, 14, 4, 0, 0, DateTimeKind.Local), 1090511m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 20, 39, 0, 0, DateTimeKind.Local), 3364278m, new DateTime(2023, 10, 20, 17, 56, 0, 0, DateTimeKind.Local), 1310518m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 19, 8, 41, 0, 0, DateTimeKind.Local), 2406734m, new DateTime(2023, 10, 19, 3, 0, 0, 0, DateTimeKind.Local), 1023194m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 19, 11, 31, 0, 0, DateTimeKind.Local), 2971589m, new DateTime(2023, 10, 19, 8, 7, 0, 0, DateTimeKind.Local), 1011995m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 8, 7, 0, 0, DateTimeKind.Local), 2434783m, new DateTime(2023, 10, 23, 1, 12, 0, 0, DateTimeKind.Local), 1293531m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 2, 16, 0, 0, DateTimeKind.Local), 2248155m, new DateTime(2023, 10, 20, 20, 26, 0, 0, DateTimeKind.Local), 807679m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 12, 45, 0, 0, DateTimeKind.Local), 2164501m, new DateTime(2023, 10, 20, 6, 0, 0, 0, DateTimeKind.Local), 912545m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 21, 13, 39, 0, 0, DateTimeKind.Local), 3055841m, new DateTime(2023, 10, 21, 12, 38, 0, 0, DateTimeKind.Local), 941489m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 23, 18, 0, 0, DateTimeKind.Local), 2015954m, new DateTime(2023, 10, 22, 21, 19, 0, 0, DateTimeKind.Local), 1266651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 23, 0, 0, DateTimeKind.Local), 2825559m, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1433519m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 6, 38, 0, 0, DateTimeKind.Local), 3395092m, new DateTime(2023, 10, 20, 4, 12, 0, 0, DateTimeKind.Local), 802777m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 19, 8, 0, 0, DateTimeKind.Local), 2674435m, new DateTime(2023, 10, 21, 13, 24, 0, 0, DateTimeKind.Local), 1412224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 8, 34, 0, 0, DateTimeKind.Local), 3419580m, new DateTime(2023, 10, 20, 7, 26, 0, 0, DateTimeKind.Local), 1375870m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 17, 7, 0, 0, DateTimeKind.Local), 3114112m, new DateTime(2023, 10, 22, 11, 17, 0, 0, DateTimeKind.Local), 1101143m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 20, 15, 8, 0, 0, DateTimeKind.Local), 2357501m, new DateTime(2023, 10, 20, 12, 23, 0, 0, DateTimeKind.Local), 929945m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 22, 51, 0, 0, DateTimeKind.Local), 2281233m, new DateTime(2023, 10, 21, 20, 3, 0, 0, DateTimeKind.Local), 964207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 15, 50, 0, 0, DateTimeKind.Local), 2186693m, new DateTime(2023, 10, 22, 8, 57, 0, 0, DateTimeKind.Local), 1435865m });
        }
    }
}
