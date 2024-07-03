using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8de5f26f-250f-48f8-a94a-13039d239b06", null, "User", "USER" },
                    { "b8690997-cf3e-41e8-b606-095ae84d9d73", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "557ce5cc-a790-4870-931f-905e95e9208d", 0, "214e2c5c-d372-4a30-9bde-0a0c945bfff6", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEOLFGyJCAI9fqPMJV9yHOyHtO+48qwoH3yopnacOpZsvmHqGCACoO23X4J85JxIMWQ==", null, false, "c4fc4b65-e284-4a95-becd-f0221713f062", false, "admin@bookstore.com" },
                    { "9da14ac2-b2a4-445a-89cf-0d586d563f7d", 0, "0aa57691-3744-4078-86ec-7161ef8e6392", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEIJY7ZHahxWtRpwsgA9RkfLR8oXaFaRkxKlhruYpwEktuLf1wSVwDrobOUwRTqsK8w==", null, false, "b9b5256d-132b-451d-b817-fb8454eb52db", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b8690997-cf3e-41e8-b606-095ae84d9d73", "557ce5cc-a790-4870-931f-905e95e9208d" },
                    { "8de5f26f-250f-48f8-a94a-13039d239b06", "9da14ac2-b2a4-445a-89cf-0d586d563f7d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b8690997-cf3e-41e8-b606-095ae84d9d73", "557ce5cc-a790-4870-931f-905e95e9208d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8de5f26f-250f-48f8-a94a-13039d239b06", "9da14ac2-b2a4-445a-89cf-0d586d563f7d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8de5f26f-250f-48f8-a94a-13039d239b06");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8690997-cf3e-41e8-b606-095ae84d9d73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "557ce5cc-a790-4870-931f-905e95e9208d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9da14ac2-b2a4-445a-89cf-0d586d563f7d");
        }
    }
}
