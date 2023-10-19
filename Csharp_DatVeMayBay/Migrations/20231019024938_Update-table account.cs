using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class Updatetableaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                columns: new[] { "Password", "Verified" },
                values: new object[] { "$2a$13$Z4vFUPLeU4pi6ziSIwTK9ekvopX1AWJgTMTTAEGaezsxplrMmlUeO", true });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                columns: new[] { "Password", "Verified" },
                values: new object[] { "$2a$13$l/pWlkmYp7Gv6WKZ.VHsa.uDsBhoOZAc3eH7x5NgnrsSoQ2.4UXqO", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "admin@gmail.com",
                columns: new[] { "Password", "Verified" },
                values: new object[] { "$2a$13$r7Qmq3j/9.5y2PtijBJ0VukIRfS.LIMuol5CrIWucGN1ncArJqd02", false });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserEmail",
                keyValue: "ngvhao@gmail.com",
                columns: new[] { "Password", "Verified" },
                values: new object[] { "$2a$13$Elr0QMG9ASrcGR8DcweAEOQvnzUwUHbOU3ckFl48Vok2h09JFLgY2", false });
        }
    }
}
