using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csharp_DatVeMayBay.Migrations
{
    /// <inheritdoc />
    public partial class addinguser_testaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Dob", "FirstName", "LastName", "PhoneNumber", "UserEmail" },
                values: new object[] { 3, "Huế, Việt Nam", new DateTime(2003, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", "", "0777777778", "user@gmail.com" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "UserEmail", "Enable", "Password", "UserId", "Verified" },
                values: new object[] { "user@gmail.com", true, "$2a$13$n5EehFMMl2Jmz90UTP4qouXmDBB7xYn.Em1Q.rq/ddkGY9CrVOpDO", 3, true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
