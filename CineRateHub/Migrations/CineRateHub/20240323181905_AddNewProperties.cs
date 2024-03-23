using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CineRateHub.Migrations.CineRateHub
{
    /// <inheritdoc />
    public partial class AddNewProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

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

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Job",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Job",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

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
    }
}
