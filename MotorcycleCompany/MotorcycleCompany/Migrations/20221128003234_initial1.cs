using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MotorcycleCompany.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agencies",
                columns: table => new
                {
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Population = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agencies", x => x.AgencyId);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CP = table.Column<int>(type: "int", maxLength: 60, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Residents = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    FirstSurname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAgency = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_phones_agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agencies",
                        principalColumn: "AgencyId");
                });

            migrationBuilder.CreateTable(
                name: "garages",
                columns: table => new
                {
                    GarageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CP = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Num = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_garages", x => x.GarageId);
                    table.ForeignKey(
                        name: "FK_garages_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "motorcycles",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mat = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumBast = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CP = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Num = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    NameAgency = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    GarageId = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorcycles", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_motorcycles_agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agencies",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_motorcycles_garages_GarageId",
                        column: x => x.GarageId,
                        principalTable: "garages",
                        principalColumn: "GarageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rents",
                columns: table => new
                {
                    RentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NameAgency = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DNIClient = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DateI = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    DateF = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    DateR = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 60, nullable: false),
                    Paid = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MotorcycleId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rents", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_rents_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rents_agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "agencies",
                        principalColumn: "AgencyId");
                    table.ForeignKey(
                        name: "FK_rents_motorcycles_MotorcycleId",
                        column: x => x.MotorcycleId,
                        principalTable: "motorcycles",
                        principalColumn: "MotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "agencies",
                columns: new[] { "AgencyId", "Address", "Name", "Population" },
                values: new object[,]
                {
                    { 1, "calle del recuerdo", "Agenciao1", "Santa barbara" },
                    { 2, "calle del suicidio", "Agenciao2", "Santana" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_garages_CityId",
                table: "garages",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_motorcycles_AgencyId",
                table: "motorcycles",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_motorcycles_GarageId",
                table: "motorcycles",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_phones_AgencyId",
                table: "phones",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_rents_AgencyId",
                table: "rents",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_rents_ClientId",
                table: "rents",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_rents_MotorcycleId",
                table: "rents",
                column: "MotorcycleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "phones");

            migrationBuilder.DropTable(
                name: "rents");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "motorcycles");

            migrationBuilder.DropTable(
                name: "agencies");

            migrationBuilder.DropTable(
                name: "garages");

            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
