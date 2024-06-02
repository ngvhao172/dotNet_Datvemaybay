using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class updatedataflight_v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 24, 4, 33, 0, 0, DateTimeKind.Local), 2794214m, new DateTime(2024, 4, 24, 0, 39, 0, 0, DateTimeKind.Local), 961530m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 24, 15, 49, 0, 0, DateTimeKind.Local), 2457651m, new DateTime(2024, 4, 24, 8, 3, 0, 0, DateTimeKind.Local), 926199m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 10, 38, 0, 0, DateTimeKind.Local), 3075685m, new DateTime(2024, 4, 27, 2, 47, 0, 0, DateTimeKind.Local), 1027124m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 24, 23, 44, 0, 0, DateTimeKind.Local), 2615572m, new DateTime(2024, 4, 24, 20, 55, 0, 0, DateTimeKind.Local), 1376663m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 14, 58, 0, 0, DateTimeKind.Local), 3195547m, new DateTime(2024, 4, 27, 8, 23, 0, 0, DateTimeKind.Local), 894148m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 6,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 24, 23, 43, 0, 0, DateTimeKind.Local), 2666182m, new DateTime(2024, 4, 24, 15, 51, 0, 0, DateTimeKind.Local), 1468573m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 7,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 24, 11, 21, 0, 0, DateTimeKind.Local), 3249578m, new DateTime(2024, 4, 24, 7, 2, 0, 0, DateTimeKind.Local), 1374801m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 8,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 8, 23, 0, 0, DateTimeKind.Local), 2071069m, new DateTime(2024, 4, 26, 4, 43, 0, 0, DateTimeKind.Local), 802198m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 9,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 24, 7, 3, 0, 0, DateTimeKind.Local), 2756613m, new DateTime(2024, 4, 24, 3, 52, 0, 0, DateTimeKind.Local), 1213782m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 10,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 7, 35, 0, 0, DateTimeKind.Local), 2555618m, new DateTime(2024, 4, 28, 2, 13, 0, 0, DateTimeKind.Local), 1319566m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 11,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 15, 4, 0, 0, DateTimeKind.Local), 2322991m, new DateTime(2024, 4, 26, 11, 51, 0, 0, DateTimeKind.Local), 1205582m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 12,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 28, 1, 28, 0, 0, DateTimeKind.Local), 2546486m, new DateTime(2024, 4, 27, 18, 4, 0, 0, DateTimeKind.Local), 885469m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 13,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 24, 10, 31, 0, 0, DateTimeKind.Local), 3483928m, new DateTime(2024, 4, 24, 8, 37, 0, 0, DateTimeKind.Local), 1275583m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 14,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 27, 4, 5, 0, 0, DateTimeKind.Local), 2195606m, new DateTime(2024, 4, 26, 21, 25, 0, 0, DateTimeKind.Local), 811589m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 15,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 11, 24, 0, 0, DateTimeKind.Local), 2972429m, new DateTime(2024, 4, 25, 4, 31, 0, 0, DateTimeKind.Local), 1478938m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 16,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 1, 58, 0, 0, DateTimeKind.Local), 2996816m, new DateTime(2024, 4, 25, 20, 16, 0, 0, DateTimeKind.Local), 978848m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 17,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 12, 30, 0, 0, DateTimeKind.Local), 3442796m, new DateTime(2024, 4, 28, 5, 45, 0, 0, DateTimeKind.Local), 1475847m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 18,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 1, 33, 0, 0, DateTimeKind.Local), 3387442m, new DateTime(2024, 4, 26, 18, 4, 0, 0, DateTimeKind.Local), 1484701m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 19,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 17, 49, 0, 0, DateTimeKind.Local), 2450006m, new DateTime(2024, 4, 25, 16, 15, 0, 0, DateTimeKind.Local), 1410797m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 20,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 9, 59, 0, 0, DateTimeKind.Local), 3232781m, new DateTime(2024, 4, 25, 7, 55, 0, 0, DateTimeKind.Local), 980649m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 21,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 22, 31, 0, 0, DateTimeKind.Local), 3322142m, new DateTime(2024, 4, 25, 16, 48, 0, 0, DateTimeKind.Local), 1258042m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 22,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 8, 0, 0, DateTimeKind.Local), 2144013m, new DateTime(2024, 4, 25, 11, 22, 0, 0, DateTimeKind.Local), 1052116m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 23,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 24, 12, 32, 0, 0, DateTimeKind.Local), 2262890m, new DateTime(2024, 4, 24, 5, 13, 0, 0, DateTimeKind.Local), 1070589m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 24,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 9, 44, 0, 0, DateTimeKind.Local), 3029895m, new DateTime(2024, 4, 27, 2, 39, 0, 0, DateTimeKind.Local), 1175079m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 25,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 24, 20, 39, 0, 0, DateTimeKind.Local), 2981437m, new DateTime(2024, 4, 24, 12, 42, 0, 0, DateTimeKind.Local), 895277m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 26,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 10, 3, 0, 0, DateTimeKind.Local), 3144332m, new DateTime(2024, 4, 28, 2, 27, 0, 0, DateTimeKind.Local), 1391773m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 27,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 10, 9, 0, 0, DateTimeKind.Local), 2282392m, new DateTime(2024, 4, 27, 5, 47, 0, 0, DateTimeKind.Local), 1361254m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 28,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 8, 9, 0, 0, DateTimeKind.Local), 3041110m, new DateTime(2024, 4, 26, 4, 2, 0, 0, DateTimeKind.Local), 1260328m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 29,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 25, 3, 23, 0, 0, DateTimeKind.Local), 2956651m, new DateTime(2024, 4, 25, 1, 33, 0, 0, DateTimeKind.Local), 974024m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 30,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 20, 58, 0, 0, DateTimeKind.Local), 2191612m, new DateTime(2024, 4, 25, 19, 37, 0, 0, DateTimeKind.Local), 1320611m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 31,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 24, 15, 30, 0, 0, DateTimeKind.Local), 2408518m, new DateTime(2024, 4, 24, 8, 2, 0, 0, DateTimeKind.Local), 1363871m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 32,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 28, 15, 48, 0, 0, DateTimeKind.Local), 3373561m, new DateTime(2024, 4, 28, 8, 50, 0, 0, DateTimeKind.Local), 837444m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 33,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 2, 52, 0, 0, DateTimeKind.Local), 2493325m, new DateTime(2024, 4, 25, 23, 13, 0, 0, DateTimeKind.Local), 1251413m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 34,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 6, 0, 0, DateTimeKind.Local), 3355400m, new DateTime(2024, 4, 24, 3, 19, 0, 0, DateTimeKind.Local), 1444909m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 35,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 10, 28, 0, 0, DateTimeKind.Local), 3120318m, new DateTime(2024, 4, 26, 4, 16, 0, 0, DateTimeKind.Local), 834226m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 36,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 12, 58, 0, 0, DateTimeKind.Local), 3156895m, new DateTime(2024, 4, 26, 6, 13, 0, 0, DateTimeKind.Local), 1048262m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 37,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 21, 30, 0, 0, DateTimeKind.Local), 3356429m, new DateTime(2024, 4, 25, 16, 22, 0, 0, DateTimeKind.Local), 1364618m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 38,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 25, 19, 29, 0, 0, DateTimeKind.Local), 2316228m, new DateTime(2024, 4, 25, 15, 19, 0, 0, DateTimeKind.Local), 1401988m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 1, 33, 0, 0, DateTimeKind.Local), 3116469m, new DateTime(2024, 4, 24, 19, 12, 0, 0, DateTimeKind.Local), 914123m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 40,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 24, 10, 8, 0, 0, DateTimeKind.Local), 2889855m, new DateTime(2024, 4, 24, 8, 58, 0, 0, DateTimeKind.Local), 1329338m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 41,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 26, 8, 48, 0, 0, DateTimeKind.Local), 3233220m, new DateTime(2024, 4, 26, 1, 50, 0, 0, DateTimeKind.Local), 986633m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 42,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 10, 35, 0, 0, DateTimeKind.Local), 2211997m, new DateTime(2024, 4, 25, 3, 9, 0, 0, DateTimeKind.Local), 901602m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 43,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 9, 27, 0, 0, DateTimeKind.Local), 2051058m, new DateTime(2024, 4, 27, 2, 11, 0, 0, DateTimeKind.Local), 1253371m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 44,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 25, 21, 54, 0, 0, DateTimeKind.Local), 2250000m, new DateTime(2024, 4, 25, 15, 56, 0, 0, DateTimeKind.Local), 1289812m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 45,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 18, 42, 0, 0, DateTimeKind.Local), 2226527m, new DateTime(2024, 4, 26, 12, 26, 0, 0, DateTimeKind.Local), 1404935m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 46,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 2, 58, 0, 0, DateTimeKind.Local), 2384897m, new DateTime(2024, 4, 25, 21, 36, 0, 0, DateTimeKind.Local), 1058798m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 47,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 1, 5, 0, 0, DateTimeKind.Local), 3403525m, new DateTime(2024, 4, 28, 22, 35, 0, 0, DateTimeKind.Local), 891618m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 48,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 19, 2, 0, 0, DateTimeKind.Local), 2657238m, new DateTime(2024, 4, 26, 11, 30, 0, 0, DateTimeKind.Local), 909813m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 49,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 25, 0, 0, DateTimeKind.Local), 2065219m, new DateTime(2024, 4, 25, 14, 10, 0, 0, DateTimeKind.Local), 920893m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 50,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 18, 4, 0, 0, DateTimeKind.Local), 2257993m, new DateTime(2024, 4, 25, 15, 29, 0, 0, DateTimeKind.Local), 1001068m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 24, 8, 16, 0, 0, DateTimeKind.Local), 2011692m, new DateTime(2024, 4, 24, 3, 29, 0, 0, DateTimeKind.Local), 1209384m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 13, 17, 0, 0, DateTimeKind.Local), 2922006m, new DateTime(2024, 4, 26, 10, 52, 0, 0, DateTimeKind.Local), 1324597m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 53,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 19, 5, 0, 0, DateTimeKind.Local), 2746065m, new DateTime(2024, 4, 25, 16, 12, 0, 0, DateTimeKind.Local), 915434m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 54,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 25, 5, 57, 0, 0, DateTimeKind.Local), 2730827m, new DateTime(2024, 4, 25, 3, 45, 0, 0, DateTimeKind.Local), 981197m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 55,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 18, 0, 0, DateTimeKind.Local), 2960966m, new DateTime(2024, 4, 26, 12, 8, 0, 0, DateTimeKind.Local), 1165055m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 21, 24, 0, 0, DateTimeKind.Local), 3406182m, new DateTime(2024, 4, 27, 17, 13, 0, 0, DateTimeKind.Local), 1029759m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 57,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 2, 24, 0, 0, DateTimeKind.Local), 2111950m, new DateTime(2024, 4, 27, 0, 10, 0, 0, DateTimeKind.Local), 854863m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 58,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 28, 23, 14, 0, 0, DateTimeKind.Local), 2902068m, new DateTime(2024, 4, 28, 21, 47, 0, 0, DateTimeKind.Local), 914447m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 59,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 12, 28, 0, 0, DateTimeKind.Local), 2559731m, new DateTime(2024, 4, 27, 5, 25, 0, 0, DateTimeKind.Local), 929342m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 60,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 22, 9, 0, 0, DateTimeKind.Local), 3170210m, new DateTime(2024, 4, 28, 17, 30, 0, 0, DateTimeKind.Local), 1379630m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 61,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 20, 45, 0, 0, DateTimeKind.Local), 2228879m, new DateTime(2024, 4, 26, 15, 56, 0, 0, DateTimeKind.Local), 1471917m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 62,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 24, 12, 50, 0, 0, DateTimeKind.Local), 3420343m, new DateTime(2024, 4, 24, 6, 58, 0, 0, DateTimeKind.Local), 952557m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 63,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 26, 10, 58, 0, 0, DateTimeKind.Local), 3382614m, new DateTime(2024, 4, 26, 5, 7, 0, 0, DateTimeKind.Local), 979051m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 64,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 24, 9, 4, 0, 0, DateTimeKind.Local), 2453649m, new DateTime(2024, 4, 24, 2, 53, 0, 0, DateTimeKind.Local), 1436992m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 65,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 1, 36, 0, 0, DateTimeKind.Local), 3138025m, new DateTime(2024, 4, 26, 22, 38, 0, 0, DateTimeKind.Local), 1108790m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 66,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 21, 0, 0, DateTimeKind.Local), 2395668m, new DateTime(2024, 4, 28, 1, 19, 0, 0, DateTimeKind.Local), 1341058m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 67,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 27, 6, 11, 0, 0, DateTimeKind.Local), 2097540m, new DateTime(2024, 4, 27, 3, 29, 0, 0, DateTimeKind.Local), 955456m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 68,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 21, 0, 0, DateTimeKind.Local), 2365409m, new DateTime(2024, 4, 26, 10, 18, 0, 0, DateTimeKind.Local), 979332m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 69,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 28, 11, 47, 0, 0, DateTimeKind.Local), 2918551m, new DateTime(2024, 4, 28, 9, 40, 0, 0, DateTimeKind.Local), 992431m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 70,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 27, 4, 50, 0, 0, DateTimeKind.Local), 2883132m, new DateTime(2024, 4, 26, 23, 31, 0, 0, DateTimeKind.Local), 1342233m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 71,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 4, 0, 0, 0, DateTimeKind.Local), 2407730m, new DateTime(2024, 4, 25, 22, 6, 0, 0, DateTimeKind.Local), 1277721m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 72,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 26, 23, 35, 0, 0, DateTimeKind.Local), 3219308m, new DateTime(2024, 4, 26, 18, 26, 0, 0, DateTimeKind.Local), 1303821m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 73,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 16, 6, 0, 0, DateTimeKind.Local), 2456473m, new DateTime(2024, 4, 28, 9, 11, 0, 0, DateTimeKind.Local), 1369379m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 74,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 6, 25, 0, 0, DateTimeKind.Local), 2093943m, new DateTime(2024, 4, 28, 2, 8, 0, 0, DateTimeKind.Local), 873187m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 75,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 27, 7, 46, 0, 0, DateTimeKind.Local), 3079018m, new DateTime(2024, 4, 27, 3, 28, 0, 0, DateTimeKind.Local), 1209900m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 76,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 27, 12, 42, 0, 0, DateTimeKind.Local), 3135019m, new DateTime(2024, 4, 27, 7, 17, 0, 0, DateTimeKind.Local), 1358572m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 23, 1, 0, 0, DateTimeKind.Local), 2674228m, new DateTime(2024, 4, 25, 15, 48, 0, 0, DateTimeKind.Local), 1403808m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 78,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 24, 12, 30, 0, 0, DateTimeKind.Local), 2995836m, new DateTime(2024, 4, 24, 11, 23, 0, 0, DateTimeKind.Local), 1405961m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 79,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 21, 51, 0, 0, DateTimeKind.Local), 3201122m, new DateTime(2024, 4, 28, 15, 46, 0, 0, DateTimeKind.Local), 1328193m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 80,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 26, 1, 8, 0, 0, DateTimeKind.Local), 2486062m, new DateTime(2024, 4, 25, 18, 34, 0, 0, DateTimeKind.Local), 937320m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 81,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 14, 3, 0, 0, DateTimeKind.Local), 2185222m, new DateTime(2024, 4, 28, 8, 41, 0, 0, DateTimeKind.Local), 1100154m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 28, 23, 47, 0, 0, DateTimeKind.Local), 3217405m, new DateTime(2024, 4, 28, 18, 43, 0, 0, DateTimeKind.Local), 1122002m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 83,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 28, 21, 47, 0, 0, DateTimeKind.Local), 2417917m, new DateTime(2024, 4, 28, 17, 11, 0, 0, DateTimeKind.Local), 868641m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 84,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 11, 7, 0, 0, DateTimeKind.Local), 3207585m, new DateTime(2024, 4, 26, 6, 1, 0, 0, DateTimeKind.Local), 1358183m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 85,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 17, 55, 0, 0, DateTimeKind.Local), 2836066m, new DateTime(2024, 4, 25, 15, 12, 0, 0, DateTimeKind.Local), 1050741m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 86,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 12, 2, 0, 0, DateTimeKind.Local), 2842139m, new DateTime(2024, 4, 26, 11, 0, 0, 0, DateTimeKind.Local), 820948m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 87,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 29, 5, 30, 0, 0, DateTimeKind.Local), 2329738m, new DateTime(2024, 4, 28, 22, 13, 0, 0, DateTimeKind.Local), 853370m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 88,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 20, 21, 0, 0, DateTimeKind.Local), 2838656m, new DateTime(2024, 4, 28, 17, 36, 0, 0, DateTimeKind.Local), 1458422m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 89,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 26, 3, 11, 0, 0, DateTimeKind.Local), 3040142m, new DateTime(2024, 4, 25, 22, 33, 0, 0, DateTimeKind.Local), 1136828m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 90,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 28, 16, 9, 0, 0, DateTimeKind.Local), 3270881m, new DateTime(2024, 4, 28, 9, 14, 0, 0, DateTimeKind.Local), 1373214m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 91,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 28, 23, 13, 0, 0, DateTimeKind.Local), 2828802m, new DateTime(2024, 4, 28, 16, 9, 0, 0, DateTimeKind.Local), 1428907m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 92,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 25, 22, 53, 0, 0, DateTimeKind.Local), 2637490m, new DateTime(2024, 4, 25, 20, 58, 0, 0, DateTimeKind.Local), 1314837m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 93,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 26, 5, 29, 0, 0, DateTimeKind.Local), 2617192m, new DateTime(2024, 4, 26, 2, 38, 0, 0, DateTimeKind.Local), 1223864m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 94,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 26, 19, 35, 0, 0, DateTimeKind.Local), 2587824m, new DateTime(2024, 4, 26, 15, 14, 0, 0, DateTimeKind.Local), 1175371m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 95,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 28, 19, 52, 0, 0, DateTimeKind.Local), 2877155m, new DateTime(2024, 4, 28, 14, 38, 0, 0, DateTimeKind.Local), 1055541m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 96,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 29, 3, 3, 0, 0, DateTimeKind.Local), 3122890m, new DateTime(2024, 4, 28, 19, 54, 0, 0, DateTimeKind.Local), 1340554m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 97,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 7, 48, 0, 0, DateTimeKind.Local), 2680374m, new DateTime(2024, 4, 25, 2, 16, 0, 0, DateTimeKind.Local), 843319m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 98,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 25, 7, 13, 0, 0, DateTimeKind.Local), 2219364m, new DateTime(2024, 4, 25, 0, 37, 0, 0, DateTimeKind.Local), 976406m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 99,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 27, 13, 35, 0, 0, DateTimeKind.Local), 2799822m, new DateTime(2024, 4, 27, 9, 44, 0, 0, DateTimeKind.Local), 953199m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 100,
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 25, 11, 26, 0, 0, DateTimeKind.Local), 2568238m, new DateTime(2024, 4, 25, 6, 23, 0, 0, DateTimeKind.Local), 1327136m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 23, 50, 0, 0, DateTimeKind.Local), 3274802m, new DateTime(2024, 4, 16, 17, 53, 0, 0, DateTimeKind.Local), 1463071m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 15, 21, 23, 0, 0, DateTimeKind.Local), 3448643m, new DateTime(2024, 4, 15, 16, 16, 0, 0, DateTimeKind.Local), 1330107m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 3, 11, 0, 0, DateTimeKind.Local), 2415960m, new DateTime(2024, 4, 15, 22, 12, 0, 0, DateTimeKind.Local), 1142395m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 5, 53, 0, 0, DateTimeKind.Local), 3288527m, new DateTime(2024, 4, 18, 3, 16, 0, 0, DateTimeKind.Local), 1329204m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 17, 0, 9, 0, 0, DateTimeKind.Local), 2502294m, new DateTime(2024, 4, 16, 17, 53, 0, 0, DateTimeKind.Local), 1044334m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 14, 20, 30, 0, 0, DateTimeKind.Local), 3015979m, new DateTime(2024, 4, 14, 14, 34, 0, 0, DateTimeKind.Local), 989568m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 39,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 14, 18, 4, 0, 0, DateTimeKind.Local), 3154531m, new DateTime(2024, 4, 14, 15, 25, 0, 0, DateTimeKind.Local), 857353m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 17, 4, 5, 0, 0, DateTimeKind.Local), 2663563m, new DateTime(2024, 4, 17, 1, 12, 0, 0, DateTimeKind.Local), 1047585m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 16, 4, 36, 0, 0, DateTimeKind.Local), 2654673m, new DateTime(2024, 4, 16, 0, 5, 0, 0, DateTimeKind.Local), 860104m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 1, 59, 0, 0, DateTimeKind.Local), 2393305m, new DateTime(2024, 4, 14, 22, 0, 0, 0, DateTimeKind.Local), 1278378m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 17, 20, 42, 0, 0, DateTimeKind.Local), 3378613m, new DateTime(2024, 4, 17, 18, 24, 0, 0, DateTimeKind.Local), 1293402m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 11, 38, 0, 0, DateTimeKind.Local), 2554069m, new DateTime(2024, 4, 15, 6, 31, 0, 0, DateTimeKind.Local), 1271582m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 51,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 32, 0, 0, DateTimeKind.Local), 2461590m, new DateTime(2024, 4, 18, 14, 15, 0, 0, DateTimeKind.Local), 988090m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 52,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 2, 22, 0, 0, DateTimeKind.Local), 2619258m, new DateTime(2024, 4, 15, 0, 53, 0, 0, DateTimeKind.Local), 1123848m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 21, 7, 0, 0, DateTimeKind.Local), 2992736m, new DateTime(2024, 4, 16, 17, 41, 0, 0, DateTimeKind.Local), 955632m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 56,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 8, 0, 0, DateTimeKind.Local), 2121191m, new DateTime(2024, 4, 15, 20, 22, 0, 0, DateTimeKind.Local), 1380498m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 17, 36, 0, 0, DateTimeKind.Local), 3122069m, new DateTime(2024, 4, 16, 16, 34, 0, 0, DateTimeKind.Local), 1020925m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 2, 0, 0, DateTimeKind.Local), 2705171m, new DateTime(2024, 4, 16, 9, 59, 0, 0, DateTimeKind.Local), 1279579m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 21, 31, 0, 0, DateTimeKind.Local), 2188857m, new DateTime(2024, 4, 18, 15, 23, 0, 0, DateTimeKind.Local), 1443962m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 1, new DateTime(2024, 4, 18, 22, 43, 0, 0, DateTimeKind.Local), 2627379m, new DateTime(2024, 4, 18, 19, 14, 0, 0, DateTimeKind.Local), 958643m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 48, 0, 0, DateTimeKind.Local), 2990764m, new DateTime(2024, 4, 18, 14, 1, 0, 0, DateTimeKind.Local), 947609m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 77,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 16, 11, 20, 0, 0, DateTimeKind.Local), 2527362m, new DateTime(2024, 4, 16, 7, 20, 0, 0, DateTimeKind.Local), 1008849m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 3, new DateTime(2024, 4, 15, 2, 20, 0, 0, DateTimeKind.Local), 2089786m, new DateTime(2024, 4, 14, 19, 37, 0, 0, DateTimeKind.Local), 969248m });

            migrationBuilder.UpdateData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 82,
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 14, 8, 13, 0, 0, DateTimeKind.Local), 3137522m, new DateTime(2024, 4, 14, 4, 11, 0, 0, DateTimeKind.Local), 1144815m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 2, new DateTime(2024, 4, 18, 15, 23, 0, 0, DateTimeKind.Local), 3179802m, new DateTime(2024, 4, 18, 11, 3, 0, 0, DateTimeKind.Local), 1278640m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 4, new DateTime(2024, 4, 14, 2, 27, 0, 0, DateTimeKind.Local), 2115579m, new DateTime(2024, 4, 14, 0, 11, 0, 0, DateTimeKind.Local), 1499570m });

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
                columns: new[] { "AirlineId", "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { 5, new DateTime(2024, 4, 15, 5, 18, 0, 0, DateTimeKind.Local), 2937091m, new DateTime(2024, 4, 15, 4, 12, 0, 0, DateTimeKind.Local), 948845m });

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
                columns: new[] { "ArrivalDatetime", "BussinessPrice", "DepartureDatetime", "EconomyPrice" },
                values: new object[] { new DateTime(2024, 4, 14, 22, 47, 0, 0, DateTimeKind.Local), 2500354m, new DateTime(2024, 4, 14, 21, 23, 0, 0, DateTimeKind.Local), 1126149m });

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
    }
}
