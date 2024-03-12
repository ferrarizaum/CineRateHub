using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineRateHub.Migrations.CineRateHub
{
    /// <inheritdoc />
    public partial class SeedDataAndUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "James Cameron", "Action", 7.9m, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avatar" },
                    { 2, "Zack Snyder", "Action", 7.7m, new DateTime(2007, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "300" },
                    { 3, "Martin Scorsese", "Biography", 8.2m, new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wolf of Wall Street" },
                    { 4, "Christopher Nolan", "Adventure", 8.6m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Age", "Email", "Job", "Name", "Password" },
                values: new object[,]
                {
                    { 1, 22, "joseferrari17@hotmail.com", "Fullstack Developer", "Jose Carlos Ferrari", "coxinha123" },
                    { 2, 23, "hernandeszanella@hotmail.com", "Agronomist", "Hernandes Zanella", "coxinha123" },
                    { 3, 23, "leoaraujo@hotmail.com", "Agronomist", "Leonardo Araujo", "coxinha123" },
                    { 4, 21, "jucabala123@hotmail.com", "Unemployed", "Juca", "coxinha123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");
        }
    }
}
