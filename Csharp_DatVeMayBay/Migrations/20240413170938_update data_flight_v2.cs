using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updatedata_flight_v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$iiiBLnCmHUdMXGTPyvZ4gu8l6SiMAVHHVLQ7GFEprmG7BdJCnzutW");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$9B.kXSAK/3RmvkDYR.Dnme4kTQQRgmwfjQ29Kz.2v4xACSi3QkkpK");

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 15, 19, 3, 0, 0, DateTimeKind.Local), 3450529m, new DateTime(2024, 4, 15, 13, 2, 0, 0, DateTimeKind.Local), 897852m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 21, 33, 0, 0, DateTimeKind.Local), 3422374m, new DateTime(2024, 4, 14, 19, 15, 0, 0, DateTimeKind.Local), 1345461m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 23, 50, 0, 0, DateTimeKind.Local), 3274802m, new DateTime(2024, 4, 16, 17, 53, 0, 0, DateTimeKind.Local), 1463071m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 15, 10, 32, 0, 0, DateTimeKind.Local), 2550247m, new DateTime(2024, 4, 15, 7, 33, 0, 0, DateTimeKind.Local), 970645m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 13, 28, 0, 0, DateTimeKind.Local), 2163892m, new DateTime(2024, 4, 16, 12, 2, 0, 0, DateTimeKind.Local), 1156957m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 23, 0, 0, DateTimeKind.Local), 3448643m, new DateTime(2024, 4, 15, 16, 16, 0, 0, DateTimeKind.Local), 1330107m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 15, 17, 14, 0, 0, DateTimeKind.Local), 2970160m, new DateTime(2024, 4, 15, 14, 46, 0, 0, DateTimeKind.Local), 1134051m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 14, 28, 0, 0, DateTimeKind.Local), 2593310m, new DateTime(2024, 4, 16, 7, 41, 0, 0, DateTimeKind.Local), 1381134m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 1, 6, 0, 0, DateTimeKind.Local), 2184516m, new DateTime(2024, 4, 15, 21, 18, 0, 0, DateTimeKind.Local), 1128647m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 18, 2, 11, 0, 0, DateTimeKind.Local), 2824961m, new DateTime(2024, 4, 17, 18, 41, 0, 0, DateTimeKind.Local), 1396814m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 19, 4, 28, 0, 0, DateTimeKind.Local), 3060411m, new DateTime(2024, 4, 18, 23, 31, 0, 0, DateTimeKind.Local), 1222773m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 14, 11, 23, 0, 0, DateTimeKind.Local), 2862157m, new DateTime(2024, 4, 14, 7, 22, 0, 0, DateTimeKind.Local), 814343m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 15, 6, 0, 0, 0, DateTimeKind.Local), 3017167m, new DateTime(2024, 4, 15, 2, 50, 0, 0, DateTimeKind.Local), 1226728m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 22, 3, 0, 0, DateTimeKind.Local), 2060347m, new DateTime(2024, 4, 16, 15, 17, 0, 0, DateTimeKind.Local), 877698m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 18, 6, 35, 0, 0, DateTimeKind.Local), 3176545m, new DateTime(2024, 4, 18, 1, 41, 0, 0, DateTimeKind.Local), 1183035m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 19, 4, 38, 0, 0, DateTimeKind.Local), 2487493m, new DateTime(2024, 4, 18, 23, 52, 0, 0, DateTimeKind.Local), 905869m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 15, 3, 0, 0, DateTimeKind.Local), 2563087m, new DateTime(2024, 4, 18, 10, 25, 0, 0, DateTimeKind.Local), 1388681m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 16, 2, 17, 0, 0, DateTimeKind.Local), 3038812m, new DateTime(2024, 4, 15, 22, 2, 0, 0, DateTimeKind.Local), 1404397m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 21, 40, 0, 0, DateTimeKind.Local), 3141359m, new DateTime(2024, 4, 18, 19, 25, 0, 0, DateTimeKind.Local), 1454038m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 3, 11, 0, 0, DateTimeKind.Local), 2415960m, new DateTime(2024, 4, 15, 22, 12, 0, 0, DateTimeKind.Local), 1142395m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 14, 1, 39, 0, 0, DateTimeKind.Local), 2817393m, new DateTime(2024, 4, 14, 0, 9, 0, 0, DateTimeKind.Local), 1198037m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 18, 5, 53, 0, 0, DateTimeKind.Local), 3288527m, new DateTime(2024, 4, 18, 3, 16, 0, 0, DateTimeKind.Local), 1329204m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 16, 18, 29, 0, 0, DateTimeKind.Local), 2164995m, new DateTime(2024, 4, 16, 14, 15, 0, 0, DateTimeKind.Local), 1081459m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 9, 2, 0, 0, DateTimeKind.Local), 2501564m, new DateTime(2024, 4, 18, 5, 9, 0, 0, DateTimeKind.Local), 1369583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 15, 1, 8, 0, 0, DateTimeKind.Local), 2471536m, new DateTime(2024, 4, 14, 19, 46, 0, 0, DateTimeKind.Local), 1464258m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 3, 28, 0, 0, DateTimeKind.Local), 2770630m, new DateTime(2024, 4, 16, 0, 21, 0, 0, DateTimeKind.Local), 1056899m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 14, 18, 54, 0, 0, DateTimeKind.Local), 2519620m, new DateTime(2024, 4, 14, 12, 22, 0, 0, DateTimeKind.Local), 1360370m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 10, 7, 0, 0, DateTimeKind.Local), 3429885m, new DateTime(2024, 4, 18, 7, 33, 0, 0, DateTimeKind.Local), 1118916m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 20, 22, 0, 0, DateTimeKind.Local), 2049942m, new DateTime(2024, 4, 16, 16, 52, 0, 0, DateTimeKind.Local), 977024m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 17, 16, 56, 0, 0, DateTimeKind.Local), 2235090m, new DateTime(2024, 4, 17, 10, 6, 0, 0, DateTimeKind.Local), 1314161m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 17, 8, 18, 0, 0, DateTimeKind.Local), 2180113m, new DateTime(2024, 4, 17, 3, 7, 0, 0, DateTimeKind.Local), 1034287m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 17, 11, 8, 0, 0, DateTimeKind.Local), 2482911m, new DateTime(2024, 4, 17, 5, 52, 0, 0, DateTimeKind.Local), 946854m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 14, 6, 48, 0, 0, DateTimeKind.Local), 2821815m, new DateTime(2024, 4, 14, 4, 11, 0, 0, DateTimeKind.Local), 1054587m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 17, 0, 9, 0, 0, DateTimeKind.Local), 2502294m, new DateTime(2024, 4, 16, 17, 53, 0, 0, DateTimeKind.Local), 1044334m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 11, 37, 0, 0, DateTimeKind.Local), 3220852m, new DateTime(2024, 4, 14, 4, 58, 0, 0, DateTimeKind.Local), 976567m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 5, 9, 0, 0, DateTimeKind.Local), 2212438m, new DateTime(2024, 4, 15, 21, 19, 0, 0, DateTimeKind.Local), 902400m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 15, 21, 4, 0, 0, DateTimeKind.Local), 2913950m, new DateTime(2024, 4, 15, 19, 31, 0, 0, DateTimeKind.Local), 1332637m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 14, 20, 30, 0, 0, DateTimeKind.Local), 3015979m, new DateTime(2024, 4, 14, 14, 34, 0, 0, DateTimeKind.Local), 989568m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 14, 18, 4, 0, 0, DateTimeKind.Local), 3154531m, new DateTime(2024, 4, 14, 15, 25, 0, 0, DateTimeKind.Local), 857353m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 15, 3, 25, 0, 0, DateTimeKind.Local), 2124017m, new DateTime(2024, 4, 15, 2, 7, 0, 0, DateTimeKind.Local), 1349369m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 17, 4, 5, 0, 0, DateTimeKind.Local), 2663563m, new DateTime(2024, 4, 17, 1, 12, 0, 0, DateTimeKind.Local), 1047585m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 18, 5, 22, 0, 0, DateTimeKind.Local), 2011501m, new DateTime(2024, 4, 18, 4, 19, 0, 0, DateTimeKind.Local), 1318174m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 1, 11, 0, 0, DateTimeKind.Local), 2918778m, new DateTime(2024, 4, 15, 20, 38, 0, 0, DateTimeKind.Local), 1216675m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 36, 0, 0, DateTimeKind.Local), 2654673m, new DateTime(2024, 4, 16, 0, 5, 0, 0, DateTimeKind.Local), 860104m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 16, 5, 27, 0, 0, DateTimeKind.Local), 3176492m, new DateTime(2024, 4, 15, 22, 56, 0, 0, DateTimeKind.Local), 1089394m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 15, 1, 59, 0, 0, DateTimeKind.Local), 2393305m, new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Local), 1278378m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 15, 20, 27, 0, 0, DateTimeKind.Local), 3467864m, new DateTime(2024, 4, 15, 14, 14, 0, 0, DateTimeKind.Local), 964062m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 17, 20, 42, 0, 0, DateTimeKind.Local), 3378613m, new DateTime(2024, 4, 17, 18, 24, 0, 0, DateTimeKind.Local), 1293402m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 10, 0, 0, DateTimeKind.Local), 2665346m, new DateTime(2024, 4, 17, 19, 43, 0, 0, DateTimeKind.Local), 1405952m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 15, 11, 38, 0, 0, DateTimeKind.Local), 2554069m, new DateTime(2024, 4, 15, 6, 31, 0, 0, DateTimeKind.Local), 1271582m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 16, 32, 0, 0, DateTimeKind.Local), 2461590m, new DateTime(2024, 4, 18, 14, 15, 0, 0, DateTimeKind.Local), 988090m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 15, 2, 22, 0, 0, DateTimeKind.Local), 2619258m, new DateTime(2024, 4, 15, 0, 53, 0, 0, DateTimeKind.Local), 1123848m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 2, 32, 0, 0, DateTimeKind.Local), 2504799m, new DateTime(2024, 4, 14, 19, 28, 0, 0, DateTimeKind.Local), 1275396m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 5, 58, 0, 0, DateTimeKind.Local), 2803061m, new DateTime(2024, 4, 14, 4, 25, 0, 0, DateTimeKind.Local), 1398549m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 21, 7, 0, 0, DateTimeKind.Local), 2992736m, new DateTime(2024, 4, 16, 17, 41, 0, 0, DateTimeKind.Local), 955632m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 23, 8, 0, 0, DateTimeKind.Local), 2121191m, new DateTime(2024, 4, 15, 20, 22, 0, 0, DateTimeKind.Local), 1380498m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 10, 55, 0, 0, DateTimeKind.Local), 3237418m, new DateTime(2024, 4, 16, 9, 10, 0, 0, DateTimeKind.Local), 847709m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 14, 10, 16, 0, 0, DateTimeKind.Local), 3185758m, new DateTime(2024, 4, 14, 8, 33, 0, 0, DateTimeKind.Local), 1490783m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 36, 0, 0, DateTimeKind.Local), 3122069m, new DateTime(2024, 4, 16, 16, 34, 0, 0, DateTimeKind.Local), 1020925m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 23, 23, 0, 0, DateTimeKind.Local), 2493617m, new DateTime(2024, 4, 15, 19, 38, 0, 0, DateTimeKind.Local), 1249594m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 16, 16, 10, 0, 0, DateTimeKind.Local), 2132725m, new DateTime(2024, 4, 16, 13, 30, 0, 0, DateTimeKind.Local), 1074467m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 18, 13, 49, 0, 0, DateTimeKind.Local), 2097258m, new DateTime(2024, 4, 18, 9, 12, 0, 0, DateTimeKind.Local), 1458931m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 16, 14, 7, 0, 0, DateTimeKind.Local), 2981882m, new DateTime(2024, 4, 16, 11, 46, 0, 0, DateTimeKind.Local), 1164911m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 3, 40, 0, 0, DateTimeKind.Local), 3344125m, new DateTime(2024, 4, 15, 22, 14, 0, 0, DateTimeKind.Local), 874749m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 18, 17, 59, 0, 0, DateTimeKind.Local), 2397337m, new DateTime(2024, 4, 18, 10, 4, 0, 0, DateTimeKind.Local), 1446094m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 16, 15, 2, 0, 0, DateTimeKind.Local), 2705171m, new DateTime(2024, 4, 16, 9, 59, 0, 0, DateTimeKind.Local), 1279579m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 18, 12, 26, 0, 0, DateTimeKind.Local), 2600942m, new DateTime(2024, 4, 18, 4, 30, 0, 0, DateTimeKind.Local), 1057535m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 18, 21, 31, 0, 0, DateTimeKind.Local), 2188857m, new DateTime(2024, 4, 18, 15, 23, 0, 0, DateTimeKind.Local), 1443962m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 17, 14, 39, 0, 0, DateTimeKind.Local), 3491974m, new DateTime(2024, 4, 17, 7, 12, 0, 0, DateTimeKind.Local), 1020973m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 16, 2, 54, 0, 0, DateTimeKind.Local), 3385024m, new DateTime(2024, 4, 15, 20, 38, 0, 0, DateTimeKind.Local), 1065208m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 19, 0, 4, 0, 0, DateTimeKind.Local), 3227587m, new DateTime(2024, 4, 18, 20, 6, 0, 0, DateTimeKind.Local), 1445672m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 18, 1, 16, 0, 0, DateTimeKind.Local), 2631244m, new DateTime(2024, 4, 17, 23, 32, 0, 0, DateTimeKind.Local), 998812m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 22, 43, 0, 0, DateTimeKind.Local), 2627379m, new DateTime(2024, 4, 18, 19, 14, 0, 0, DateTimeKind.Local), 958643m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 0, 34, 0, 0, DateTimeKind.Local), 2967091m, new DateTime(2024, 4, 15, 21, 28, 0, 0, DateTimeKind.Local), 1348428m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 4, 3, 0, 0, DateTimeKind.Local), 3308843m, new DateTime(2024, 4, 16, 1, 6, 0, 0, DateTimeKind.Local), 1132974m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 16, 48, 0, 0, DateTimeKind.Local), 2990764m, new DateTime(2024, 4, 18, 14, 1, 0, 0, DateTimeKind.Local), 947609m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 11, 20, 0, 0, DateTimeKind.Local), 2527362m, new DateTime(2024, 4, 16, 7, 20, 0, 0, DateTimeKind.Local), 1008849m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 14, 4, 11, 0, 0, DateTimeKind.Local), 2800319m, new DateTime(2024, 4, 14, 2, 45, 0, 0, DateTimeKind.Local), 1270822m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 15, 11, 10, 0, 0, DateTimeKind.Local), 2358311m, new DateTime(2024, 4, 15, 6, 42, 0, 0, DateTimeKind.Local), 1260045m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 14, 17, 37, 0, 0, DateTimeKind.Local), 3221520m, new DateTime(2024, 4, 14, 13, 41, 0, 0, DateTimeKind.Local), 1178464m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 2, 20, 0, 0, DateTimeKind.Local), 2089786m, new DateTime(2024, 4, 14, 19, 37, 0, 0, DateTimeKind.Local), 969248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 14, 8, 13, 0, 0, DateTimeKind.Local), 3137522m, new DateTime(2024, 4, 14, 4, 11, 0, 0, DateTimeKind.Local), 1144815m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 17, 18, 32, 0, 0, DateTimeKind.Local), 2573032m, new DateTime(2024, 4, 17, 12, 9, 0, 0, DateTimeKind.Local), 1391410m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 16, 15, 35, 0, 0, DateTimeKind.Local), 3339517m, new DateTime(2024, 4, 16, 12, 25, 0, 0, DateTimeKind.Local), 1455085m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 23, 0, 0, DateTimeKind.Local), 3179802m, new DateTime(2024, 4, 18, 11, 3, 0, 0, DateTimeKind.Local), 1278640m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 16, 12, 7, 0, 0, DateTimeKind.Local), 2743652m, new DateTime(2024, 4, 16, 7, 43, 0, 0, DateTimeKind.Local), 810875m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 15, 1, 23, 0, 0, DateTimeKind.Local), 2243911m, new DateTime(2024, 4, 14, 17, 58, 0, 0, DateTimeKind.Local), 1056651m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 22, 16, 0, 0, DateTimeKind.Local), 2792853m, new DateTime(2024, 4, 16, 15, 40, 0, 0, DateTimeKind.Local), 1376639m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 14, 2, 27, 0, 0, DateTimeKind.Local), 2115579m, new DateTime(2024, 4, 14, 0, 11, 0, 0, DateTimeKind.Local), 1499570m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 13, 35, 0, 0, DateTimeKind.Local), 2472169m, new DateTime(2024, 4, 15, 11, 10, 0, 0, DateTimeKind.Local), 1400976m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 17, 14, 39, 0, 0, DateTimeKind.Local), 2496390m, new DateTime(2024, 4, 17, 10, 47, 0, 0, DateTimeKind.Local), 837101m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 15, 5, 27, 0, 0, DateTimeKind.Local), 2540294m, new DateTime(2024, 4, 15, 3, 8, 0, 0, DateTimeKind.Local), 1140940m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 17, 59, 0, 0, DateTimeKind.Local), 2759120m, new DateTime(2024, 4, 15, 14, 51, 0, 0, DateTimeKind.Local), 1036773m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 5, 18, 0, 0, DateTimeKind.Local), 2937091m, new DateTime(2024, 4, 15, 4, 12, 0, 0, DateTimeKind.Local), 948845m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 14, 9, 6, 0, 0, DateTimeKind.Local), 3225529m, new DateTime(2024, 4, 14, 2, 24, 0, 0, DateTimeKind.Local), 1153942m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 18, 1, 59, 0, 0, DateTimeKind.Local), 2750594m, new DateTime(2024, 4, 17, 21, 6, 0, 0, DateTimeKind.Local), 926632m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 17, 16, 51, 0, 0, DateTimeKind.Local), 2773527m, new DateTime(2024, 4, 17, 11, 5, 0, 0, DateTimeKind.Local), 1142575m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 14, 22, 47, 0, 0, DateTimeKind.Local), 2500354m, new DateTime(2024, 4, 14, 21, 23, 0, 0, DateTimeKind.Local), 1126149m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 15, 15, 5, 0, 0, DateTimeKind.Local), 2108912m, new DateTime(2024, 4, 15, 11, 51, 0, 0, DateTimeKind.Local), 1059554m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 15, 2, 12, 0, 0, DateTimeKind.Local), 2448931m, new DateTime(2024, 4, 14, 19, 20, 0, 0, DateTimeKind.Local), 1291978m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                column: "Password",
                value: "$2a$13$wwrfitGVywpnNrmgtDhW7uFK2IfCO9RyEQjmDn7.5l9COLg3rHLBm");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                column: "Password",
                value: "$2a$13$mDkCo8tUGM/KX8p/6YcLoex40iGti4R9Qo7Z5nUuysizc8QgLgrl.");

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 29, 0, 0, DateTimeKind.Local), 3341596m, new DateTime(2024, 4, 11, 10, 53, 0, 0, DateTimeKind.Local), 1398788m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 20, 23, 0, 0, DateTimeKind.Local), 2098617m, new DateTime(2024, 4, 12, 18, 0, 0, 0, DateTimeKind.Local), 974444m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 13, 9, 16, 0, 0, DateTimeKind.Local), 3357576m, new DateTime(2024, 4, 13, 3, 55, 0, 0, DateTimeKind.Local), 1440218m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 10, 7, 18, 0, 0, DateTimeKind.Local), 3116797m, new DateTime(2024, 4, 10, 5, 21, 0, 0, DateTimeKind.Local), 1038505m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 10, 9, 0, 0, DateTimeKind.Local), 3240955m, new DateTime(2024, 4, 11, 7, 42, 0, 0, DateTimeKind.Local), 1059215m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 11, 11, 21, 0, 0, DateTimeKind.Local), 2268724m, new DateTime(2024, 4, 11, 3, 43, 0, 0, DateTimeKind.Local), 1416745m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 11, 20, 5, 0, 0, DateTimeKind.Local), 2514418m, new DateTime(2024, 4, 11, 17, 45, 0, 0, DateTimeKind.Local), 1462537m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 10, 3, 7, 0, 0, DateTimeKind.Local), 2801080m, new DateTime(2024, 4, 10, 0, 38, 0, 0, DateTimeKind.Local), 1199230m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 2, 29, 0, 0, DateTimeKind.Local), 2896669m, new DateTime(2024, 4, 11, 19, 26, 0, 0, DateTimeKind.Local), 1156909m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 13, 21, 2, 0, 0, DateTimeKind.Local), 2181020m, new DateTime(2024, 4, 13, 19, 49, 0, 0, DateTimeKind.Local), 1449896m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 8, 3, 0, 0, DateTimeKind.Local), 2048490m, new DateTime(2024, 4, 11, 6, 31, 0, 0, DateTimeKind.Local), 1332547m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 23, 14, 0, 0, DateTimeKind.Local), 3098365m, new DateTime(2024, 4, 12, 16, 53, 0, 0, DateTimeKind.Local), 1263560m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 5, 55, 0, 0, DateTimeKind.Local), 2466753m, new DateTime(2024, 4, 10, 22, 56, 0, 0, DateTimeKind.Local), 1209442m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 18, 50, 0, 0, DateTimeKind.Local), 3446792m, new DateTime(2024, 4, 13, 11, 27, 0, 0, DateTimeKind.Local), 1125991m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 10, 7, 7, 0, 0, DateTimeKind.Local), 3164443m, new DateTime(2024, 4, 10, 3, 51, 0, 0, DateTimeKind.Local), 965049m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 11, 4, 0, 0, 0, DateTimeKind.Local), 2458172m, new DateTime(2024, 4, 10, 20, 54, 0, 0, DateTimeKind.Local), 809674m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 5, 55, 0, 0, DateTimeKind.Local), 3236995m, new DateTime(2024, 4, 11, 23, 9, 0, 0, DateTimeKind.Local), 1299916m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 12, 12, 17, 0, 0, DateTimeKind.Local), 3214155m, new DateTime(2024, 4, 12, 8, 41, 0, 0, DateTimeKind.Local), 1314340m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 13, 18, 47, 0, 0, DateTimeKind.Local), 2809286m, new DateTime(2024, 4, 13, 16, 49, 0, 0, DateTimeKind.Local), 1260009m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 13, 13, 53, 0, 0, DateTimeKind.Local), 2443077m, new DateTime(2024, 4, 13, 6, 28, 0, 0, DateTimeKind.Local), 1442238m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 9, 19, 56, 0, 0, DateTimeKind.Local), 2041346m, new DateTime(2024, 4, 9, 13, 54, 0, 0, DateTimeKind.Local), 1193425m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 11, 23, 23, 0, 0, DateTimeKind.Local), 2089018m, new DateTime(2024, 4, 11, 18, 0, 0, 0, DateTimeKind.Local), 1125552m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 12, 16, 37, 0, 0, DateTimeKind.Local), 3425479m, new DateTime(2024, 4, 12, 15, 0, 0, 0, DateTimeKind.Local), 1375047m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 12, 20, 52, 0, 0, DateTimeKind.Local), 3173894m, new DateTime(2024, 4, 12, 15, 5, 0, 0, DateTimeKind.Local), 996699m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 13, 17, 33, 0, 0, DateTimeKind.Local), 2842491m, new DateTime(2024, 4, 13, 15, 14, 0, 0, DateTimeKind.Local), 942859m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 9, 9, 43, 0, 0, DateTimeKind.Local), 2248590m, new DateTime(2024, 4, 9, 7, 49, 0, 0, DateTimeKind.Local), 873833m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 10, 6, 23, 0, 0, DateTimeKind.Local), 2252666m, new DateTime(2024, 4, 10, 2, 43, 0, 0, DateTimeKind.Local), 1241244m });

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
    }
}
