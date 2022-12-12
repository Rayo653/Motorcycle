using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleCompany.Migrations
{
    public partial class configuration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    AgencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Population = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAgency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.AgencyId);
                });

            migrationBuilder.CreateTable(
                name: "City",
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
                    table.PrimaryKey("PK_City", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Client",
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
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AgencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phone_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "AgencyId");
                });

            migrationBuilder.CreateTable(
                name: "Garage",
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
                    table.PrimaryKey("PK_Garage", x => x.GarageId);
                    table.ForeignKey(
                        name: "FK_Garage_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motorcycle",
                columns: table => new
                {
                    MotorcycleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mat = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumBast = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CP = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Num = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    NameAgency = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    GarageId = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<int>(type: "int", nullable: false),
                    AgencyId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycle", x => x.MotorcycleId);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Agency_AgencyId1",
                        column: x => x.AgencyId1,
                        principalTable: "Agency",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycle_Garage_GarageId",
                        column: x => x.GarageId,
                        principalTable: "Garage",
                        principalColumn: "GarageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rent",
                columns: table => new
                {
                    RentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberPlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NameAgency = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DNIClient = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    DateS = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    DateE = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    DateR = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false),
                    Price = table.Column<double>(type: "float", maxLength: 60, nullable: false),
                    Paid = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    MotorcycleId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    AgencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rent", x => x.RentId);
                    table.ForeignKey(
                        name: "FK_Rent_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "AgencyId");
                    table.ForeignKey(
                        name: "FK_Rent_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rent_Motorcycle_MotorcycleId",
                        column: x => x.MotorcycleId,
                        principalTable: "Motorcycle",
                        principalColumn: "MotorcycleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Agency",
                columns: new[] { "AgencyId", "Address", "Name", "NameAgency", "Population" },
                values: new object[] { new Guid("4bed0933-bd8e-4ca7-999b-e424da44893e"), "Calle del futuro", "Agencia02", 0, "Santa Ana" });

            migrationBuilder.InsertData(
                table: "Agency",
                columns: new[] { "AgencyId", "Address", "Name", "NameAgency", "Population" },
                values: new object[] { new Guid("68c08f84-b5e5-4157-a337-37280ee22f3d"), "Calle del recuerdo", "Agencia01", 0, "Santa Barbara" });

            migrationBuilder.CreateIndex(
                name: "IX_Garage_CityId",
                table: "Garage",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_AgencyId1",
                table: "Motorcycle",
                column: "AgencyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycle_GarageId",
                table: "Motorcycle",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_AgencyId",
                table: "Phone",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_AgencyId",
                table: "Rent",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_ClientId",
                table: "Rent",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rent_MotorcycleId",
                table: "Rent",
                column: "MotorcycleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Rent");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Motorcycle");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "Garage");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
