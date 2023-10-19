using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class dbd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$K9LM9HvbggGcrTgrS0FIluMqtDh5qn6t7hKGoBrQ0sCvYqmZ9Fp5K");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$cD2MS3Te5eRrww/xQ6HTPO2Byv4aHrmPDACkTwHqySTB7/ZXmj/Zy");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 13, 12, 0, 0, DateTimeKind.Local), 3228181m, new DateTime(2023, 10, 21, 10, 42, 0, 0, DateTimeKind.Local), 1169825m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 24, 10, 54, 0, 0, DateTimeKind.Local), 2744801m, new DateTime(2023, 10, 24, 3, 23, 0, 0, DateTimeKind.Local), 1286224m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 13, 51, 0, 0, DateTimeKind.Local), 3337286m, new DateTime(2023, 10, 23, 11, 24, 0, 0, DateTimeKind.Local), 1388399m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 17, 48, 0, 0, DateTimeKind.Local), 2190398m, new DateTime(2023, 10, 22, 11, 27, 0, 0, DateTimeKind.Local), 1289365m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 20, 7, 59, 0, 0, DateTimeKind.Local), 2030140m, new DateTime(2023, 10, 20, 1, 1, 0, 0, DateTimeKind.Local), 1108150m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 17, 52, 0, 0, DateTimeKind.Local), 2373291m, new DateTime(2023, 10, 20, 13, 5, 0, 0, DateTimeKind.Local), 1052359m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 20, 22, 20, 0, 0, DateTimeKind.Local), 3344428m, new DateTime(2023, 10, 20, 20, 57, 0, 0, DateTimeKind.Local), 1105708m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 12, 33, 0, 0, DateTimeKind.Local), 3001376m, new DateTime(2023, 10, 22, 9, 50, 0, 0, DateTimeKind.Local), 1263028m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 22, 18, 58, 0, 0, DateTimeKind.Local), 3288176m, new DateTime(2023, 10, 22, 13, 27, 0, 0, DateTimeKind.Local), 1231719m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 24, 19, 50, 0, 0, DateTimeKind.Local), 2526345m, new DateTime(2023, 10, 24, 15, 48, 0, 0, DateTimeKind.Local), 1357197m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 6, 13, 0, 0, DateTimeKind.Local), 2118850m, new DateTime(2023, 10, 23, 2, 19, 0, 0, DateTimeKind.Local), 1141763m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 23, 13, 15, 0, 0, DateTimeKind.Local), 2081028m, new DateTime(2023, 10, 23, 10, 3, 0, 0, DateTimeKind.Local), 1444104m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 24, 12, 1, 0, 0, DateTimeKind.Local), 2234539m, new DateTime(2023, 10, 24, 10, 59, 0, 0, DateTimeKind.Local), 1440272m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 15, 19, 0, 0, DateTimeKind.Local), 3412374m, new DateTime(2023, 10, 23, 8, 8, 0, 0, DateTimeKind.Local), 1365759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 25, 1, 43, 0, 0, DateTimeKind.Local), 2489108m, new DateTime(2023, 10, 24, 22, 30, 0, 0, DateTimeKind.Local), 1136543m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 25, 1, 21, 0, 0, DateTimeKind.Local), 2185874m, new DateTime(2023, 10, 24, 19, 13, 0, 0, DateTimeKind.Local), 1470846m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 24, 1, 52, 0, 0, DateTimeKind.Local), 2791943m, new DateTime(2023, 10, 23, 17, 53, 0, 0, DateTimeKind.Local), 1028114m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 19, 43, 0, 0, DateTimeKind.Local), 3325823m, new DateTime(2023, 10, 22, 18, 13, 0, 0, DateTimeKind.Local), 1069717m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 22, 17, 0, 0, DateTimeKind.Local), 2604256m, new DateTime(2023, 10, 20, 16, 15, 0, 0, DateTimeKind.Local), 1195798m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 18, 31, 0, 0, DateTimeKind.Local), 3102821m, new DateTime(2023, 10, 23, 16, 8, 0, 0, DateTimeKind.Local), 1420203m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 22, 21, 55, 0, 0, DateTimeKind.Local), 2202437m, new DateTime(2023, 10, 22, 16, 27, 0, 0, DateTimeKind.Local), 1048321m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 19, 39, 0, 0, DateTimeKind.Local), 2449987m, new DateTime(2023, 10, 23, 15, 56, 0, 0, DateTimeKind.Local), 1282522m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 11, 5, 0, 0, DateTimeKind.Local), 2706848m, new DateTime(2023, 10, 22, 5, 50, 0, 0, DateTimeKind.Local), 925335m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 24, 19, 53, 0, 0, DateTimeKind.Local), 2767545m, new DateTime(2023, 10, 24, 16, 20, 0, 0, DateTimeKind.Local), 1318660m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 18, 28, 0, 0, DateTimeKind.Local), 2953129m, new DateTime(2023, 10, 23, 13, 44, 0, 0, DateTimeKind.Local), 976526m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 14, 25, 0, 0, DateTimeKind.Local), 2767337m, new DateTime(2023, 10, 21, 12, 51, 0, 0, DateTimeKind.Local), 1022394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 24, 5, 55, 0, 0, DateTimeKind.Local), 2171039m, new DateTime(2023, 10, 23, 23, 25, 0, 0, DateTimeKind.Local), 1495272m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 22, 1, 0, 0, DateTimeKind.Local), 3288957m, new DateTime(2023, 10, 20, 16, 55, 0, 0, DateTimeKind.Local), 953242m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 21, 7, 35, 0, 0, DateTimeKind.Local), 2524536m, new DateTime(2023, 10, 21, 4, 54, 0, 0, DateTimeKind.Local), 1303220m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 10, 36, 0, 0, DateTimeKind.Local), 3182433m, new DateTime(2023, 10, 20, 4, 29, 0, 0, DateTimeKind.Local), 1100969m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 22, 17, 45, 0, 0, DateTimeKind.Local), 2078461m, new DateTime(2023, 10, 22, 14, 13, 0, 0, DateTimeKind.Local), 914774m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 23, 11, 59, 0, 0, DateTimeKind.Local), 2794170m, new DateTime(2023, 10, 23, 6, 32, 0, 0, DateTimeKind.Local), 1138956m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 24, 11, 20, 0, 0, DateTimeKind.Local), 2038890m, new DateTime(2023, 10, 24, 9, 41, 0, 0, DateTimeKind.Local), 1058808m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 23, 11, 6, 0, 0, DateTimeKind.Local), 3143368m, new DateTime(2023, 10, 23, 9, 59, 0, 0, DateTimeKind.Local), 953340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 22, 44, 0, 0, DateTimeKind.Local), 2400198m, new DateTime(2023, 10, 23, 16, 42, 0, 0, DateTimeKind.Local), 1464683m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 21, 20, 3, 0, 0, DateTimeKind.Local), 2683706m, new DateTime(2023, 10, 21, 18, 4, 0, 0, DateTimeKind.Local), 920113m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 4, 44, 0, 0, DateTimeKind.Local), 3044274m, new DateTime(2023, 10, 21, 0, 33, 0, 0, DateTimeKind.Local), 1103710m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 21, 22, 17, 0, 0, DateTimeKind.Local), 2629287m, new DateTime(2023, 10, 21, 19, 28, 0, 0, DateTimeKind.Local), 1081359m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 7, 45, 0, 0, DateTimeKind.Local), 2726248m, new DateTime(2023, 10, 22, 0, 30, 0, 0, DateTimeKind.Local), 964516m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 21, 3, 47, 0, 0, DateTimeKind.Local), 3378094m, new DateTime(2023, 10, 20, 22, 47, 0, 0, DateTimeKind.Local), 1147764m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 20, 6, 7, 0, 0, DateTimeKind.Local), 2590747m, new DateTime(2023, 10, 20, 1, 41, 0, 0, DateTimeKind.Local), 824332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 23, 7, 14, 0, 0, DateTimeKind.Local), 3106672m, new DateTime(2023, 10, 23, 3, 48, 0, 0, DateTimeKind.Local), 981926m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2023, 10, 21, 18, 50, 0, 0, DateTimeKind.Local), 3207678m, new DateTime(2023, 10, 21, 16, 37, 0, 0, DateTimeKind.Local), 1289113m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 20, 19, 46, 0, 0, DateTimeKind.Local), 2129393m, new DateTime(2023, 10, 20, 15, 14, 0, 0, DateTimeKind.Local), 1004577m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 22, 20, 30, 0, 0, DateTimeKind.Local), 2015786m, new DateTime(2023, 10, 22, 12, 33, 0, 0, DateTimeKind.Local), 883131m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 19, 15, 0, 0, DateTimeKind.Local), 2132763m, new DateTime(2023, 10, 21, 17, 23, 0, 0, DateTimeKind.Local), 1007685m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 24, 2, 28, 0, 0, DateTimeKind.Local), 2884802m, new DateTime(2023, 10, 24, 1, 12, 0, 0, DateTimeKind.Local), 1083509m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 12, 27, 0, 0, DateTimeKind.Local), 3103488m, new DateTime(2023, 10, 20, 11, 4, 0, 0, DateTimeKind.Local), 1091326m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 23, 3, 28, 0, 0, DateTimeKind.Local), 2440104m, new DateTime(2023, 10, 22, 23, 59, 0, 0, DateTimeKind.Local), 853405m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 8, 44, 0, 0, DateTimeKind.Local), 2446082m, new DateTime(2023, 10, 21, 1, 41, 0, 0, DateTimeKind.Local), 1132994m });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets",
                column: "BookingId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets");

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 23, 2, 0, 0, DateTimeKind.Local), 3157264m, new DateTime(2023, 10, 22, 21, 4, 0, 0, DateTimeKind.Local), 840583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 11, 25, 0, 0, DateTimeKind.Local), 2352022m, new DateTime(2023, 10, 22, 5, 30, 0, 0, DateTimeKind.Local), 1383282m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 20, 22, 29, 0, 0, DateTimeKind.Local), 3466222m, new DateTime(2023, 10, 20, 18, 18, 0, 0, DateTimeKind.Local), 819061m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 23, 23, 30, 0, 0, DateTimeKind.Local), 2154469m, new DateTime(2023, 10, 23, 16, 53, 0, 0, DateTimeKind.Local), 804798m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 1, 56, 0, 0, DateTimeKind.Local), 2957116m, new DateTime(2023, 10, 21, 22, 57, 0, 0, DateTimeKind.Local), 1323646m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 36, 0, 0, DateTimeKind.Local), 2516542m, new DateTime(2023, 10, 19, 18, 40, 0, 0, DateTimeKind.Local), 873115m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 14, 14, 0, 0, DateTimeKind.Local), 2356307m, new DateTime(2023, 10, 19, 8, 26, 0, 0, DateTimeKind.Local), 1260420m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2023, 10, 20, 1, 5, 0, 0, DateTimeKind.Local), 3169286m, new DateTime(2023, 10, 19, 17, 25, 0, 0, DateTimeKind.Local), 1387754m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 21, 30, 0, 0, DateTimeKind.Local), 2471437m, new DateTime(2023, 10, 22, 17, 45, 0, 0, DateTimeKind.Local), 1435195m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 20, 0, 43, 0, 0, DateTimeKind.Local), 2557523m, new DateTime(2023, 10, 19, 22, 49, 0, 0, DateTimeKind.Local), 1158192m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2023, 10, 19, 10, 36, 0, 0, DateTimeKind.Local), 3250062m, new DateTime(2023, 10, 19, 9, 35, 0, 0, DateTimeKind.Local), 1425050m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 19, 18, 50, 0, 0, DateTimeKind.Local), 3053141m, new DateTime(2023, 10, 19, 14, 21, 0, 0, DateTimeKind.Local), 828823m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2023, 10, 21, 2, 37, 0, 0, DateTimeKind.Local), 2391720m, new DateTime(2023, 10, 20, 20, 50, 0, 0, DateTimeKind.Local), 1247156m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2023, 10, 19, 21, 14, 0, 0, DateTimeKind.Local), 3151171m, new DateTime(2023, 10, 19, 16, 36, 0, 0, DateTimeKind.Local), 863846m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 22, 0, 3, 0, 0, DateTimeKind.Local), 2680135m, new DateTime(2023, 10, 21, 20, 57, 0, 0, DateTimeKind.Local), 1345912m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 2, 0, 0, DateTimeKind.Local), 2489611m, new DateTime(2023, 10, 20, 17, 54, 0, 0, DateTimeKind.Local), 1238822m });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets",
                column: "BookingId");
        }
    }
}
