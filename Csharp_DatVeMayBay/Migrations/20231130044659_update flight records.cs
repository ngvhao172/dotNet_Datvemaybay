using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updateflightrecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 11, 30, 2, 12, 0, 0, DateTimeKind.Local), 2838563m, new DateTime(2023, 11, 30, 0, 9, 0, 0, DateTimeKind.Local), 1450987m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 21, 25, 0, 0, DateTimeKind.Local), 3208980m, new DateTime(2023, 12, 4, 20, 24, 0, 0, DateTimeKind.Local), 1306150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 2, 47, 0, 0, DateTimeKind.Local), 2838276m, new DateTime(2023, 11, 30, 23, 24, 0, 0, DateTimeKind.Local), 1444999m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 1, 8, 55, 0, 0, DateTimeKind.Local), 2951708m, new DateTime(2023, 12, 1, 3, 47, 0, 0, DateTimeKind.Local), 1478351m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 3, 2, 11, 0, 0, DateTimeKind.Local), 2174478m, new DateTime(2023, 12, 2, 18, 42, 0, 0, DateTimeKind.Local), 1482214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 2, 26, 0, 0, DateTimeKind.Local), 2656942m, new DateTime(2023, 12, 3, 20, 51, 0, 0, DateTimeKind.Local), 1132844m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 2, 6, 7, 0, 0, DateTimeKind.Local), 3199080m, new DateTime(2023, 12, 2, 4, 1, 0, 0, DateTimeKind.Local), 1117357m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 22, 25, 0, 0, DateTimeKind.Local), 3081299m, new DateTime(2023, 12, 4, 15, 4, 0, 0, DateTimeKind.Local), 894037m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 4, 19, 34, 0, 0, DateTimeKind.Local), 2456763m, new DateTime(2023, 12, 4, 17, 47, 0, 0, DateTimeKind.Local), 821241m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 12, 4, 23, 50, 0, 0, DateTimeKind.Local), 2090302m, new DateTime(2023, 12, 4, 20, 21, 0, 0, DateTimeKind.Local), 1473426m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 2, 15, 15, 0, 0, DateTimeKind.Local), 2280106m, new DateTime(2023, 12, 2, 9, 15, 0, 0, DateTimeKind.Local), 1155229m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 1, 6, 45, 0, 0, DateTimeKind.Local), 2233649m, new DateTime(2023, 11, 30, 23, 9, 0, 0, DateTimeKind.Local), 1154955m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 12, 1, 5, 36, 0, 0, DateTimeKind.Local), 2251403m, new DateTime(2023, 12, 1, 1, 4, 0, 0, DateTimeKind.Local), 1449300m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 12, 4, 6, 25, 0, 0, DateTimeKind.Local), 3225561m, new DateTime(2023, 12, 4, 0, 24, 0, 0, DateTimeKind.Local), 1072548m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 12, 4, 23, 7, 0, 0, DateTimeKind.Local), 3221747m, new DateTime(2023, 12, 4, 18, 10, 0, 0, DateTimeKind.Local), 1387286m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 12, 3, 2, 15, 0, 0, DateTimeKind.Local), 2696441m, new DateTime(2023, 12, 2, 23, 44, 0, 0, DateTimeKind.Local), 1386483m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 3, 0, 0, 0, DateTimeKind.Local), 2601244m, new DateTime(2023, 10, 21, 1, 25, 0, 0, DateTimeKind.Local), 1354034m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 8, 5, 0, 0, DateTimeKind.Local), 3344265m, new DateTime(2023, 10, 22, 5, 38, 0, 0, DateTimeKind.Local), 841560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 16, 43, 0, 0, DateTimeKind.Local), 2931965m, new DateTime(2023, 10, 20, 10, 57, 0, 0, DateTimeKind.Local), 1190712m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 10, 17, 0, 0, DateTimeKind.Local), 2559885m, new DateTime(2023, 10, 20, 2, 19, 0, 0, DateTimeKind.Local), 1190897m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 12, 33, 0, 0, DateTimeKind.Local), 3049850m, new DateTime(2023, 10, 23, 6, 17, 0, 0, DateTimeKind.Local), 1124782m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 22, 18, 2, 0, 0, DateTimeKind.Local), 2891508m, new DateTime(2023, 10, 22, 13, 35, 0, 0, DateTimeKind.Local), 965141m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 18, 45, 0, 0, DateTimeKind.Local), 3184306m, new DateTime(2023, 10, 20, 16, 22, 0, 0, DateTimeKind.Local), 1445590m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 19, 14, 36, 0, 0, DateTimeKind.Local), 3098167m, new DateTime(2023, 10, 19, 7, 2, 0, 0, DateTimeKind.Local), 1330575m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 6, 38, 0, 0, DateTimeKind.Local), 2669694m, new DateTime(2023, 10, 19, 2, 29, 0, 0, DateTimeKind.Local), 1194872m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 15, 24, 0, 0, DateTimeKind.Local), 2177682m, new DateTime(2023, 10, 19, 12, 57, 0, 0, DateTimeKind.Local), 1031901m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 14, 15, 0, 0, DateTimeKind.Local), 3262227m, new DateTime(2023, 10, 21, 6, 41, 0, 0, DateTimeKind.Local), 1123681m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 11, 34, 0, 0, DateTimeKind.Local), 2222944m, new DateTime(2023, 10, 21, 8, 16, 0, 0, DateTimeKind.Local), 852935m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 2, 16, 0, 0, DateTimeKind.Local), 2248155m, new DateTime(2023, 10, 20, 20, 26, 0, 0, DateTimeKind.Local), 807679m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 1, 23, 0, 0, DateTimeKind.Local), 2825559m, new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Local), 1433519m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 15, 8, 0, 0, DateTimeKind.Local), 2357501m, new DateTime(2023, 10, 20, 12, 23, 0, 0, DateTimeKind.Local), 929945m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 22, 51, 0, 0, DateTimeKind.Local), 2281233m, new DateTime(2023, 10, 21, 20, 3, 0, 0, DateTimeKind.Local), 964207m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 15, 50, 0, 0, DateTimeKind.Local), 2186693m, new DateTime(2023, 10, 22, 8, 57, 0, 0, DateTimeKind.Local), 1435865m });
        }
    }
}
