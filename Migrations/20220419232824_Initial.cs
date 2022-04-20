using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlightBookingSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAdmin",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAdmin", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "TblAirline",
                columns: table => new
                {
                    AirlineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AirlineName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false),
                    AirlineStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAirline", x => x.AirlineID);
                });

            migrationBuilder.CreateTable(
                name: "TblTicketBooking",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoofSeats = table.Column<int>(type: "int", nullable: false),
                    MealPreference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeatSelected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PNR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTicketBooking", x => x.BookingID);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Phoneno = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "TblFlightInfo",
                columns: table => new
                {
                    FlightID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FromPlace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ToPlace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ScheduledDeparture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScheduledArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AirlineID = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    FlightModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoofBSeats = table.Column<int>(type: "int", nullable: false),
                    NoofEconomySeats = table.Column<int>(type: "int", nullable: false),
                    NoofRows = table.Column<int>(type: "int", nullable: false),
                    MealsAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFlightInfo", x => x.FlightID);
                    table.ForeignKey(
                        name: "FK_TblFlightInfo_TblAirline_AirlineID",
                        column: x => x.AirlineID,
                        principalTable: "TblAirline",
                        principalColumn: "AirlineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblPassenger",
                columns: table => new
                {
                    PassengerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TicketBookingBookingID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPassenger", x => x.PassengerID);
                    table.ForeignKey(
                        name: "FK_TblPassenger_TblTicketBooking_TicketBookingBookingID",
                        column: x => x.TicketBookingBookingID,
                        principalTable: "TblTicketBooking",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "TblAirline",
                columns: new[] { "AirlineID", "AirlineName", "AirlineStatus", "SeatingCapacity" },
                values: new object[] { 1, "Indigo", "Active", 200 });

            migrationBuilder.InsertData(
                table: "TblUser",
                columns: new[] { "UserID", "Age", "Email", "Password", "Phoneno", "UserName" },
                values: new object[] { 1, 25, "ashishankitmishra@gmail.com", "P@ssword", "9667516101", "Ashish" });

            migrationBuilder.InsertData(
                table: "tblAdmin",
                columns: new[] { "AdminID", "AdminName", "Password" },
                values: new object[] { 1, "Admin", "P@ssword" });

            migrationBuilder.CreateIndex(
                name: "IX_TblFlightInfo_AirlineID",
                table: "TblFlightInfo",
                column: "AirlineID");

            migrationBuilder.CreateIndex(
                name: "IX_TblPassenger_TicketBookingBookingID",
                table: "TblPassenger",
                column: "TicketBookingBookingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblAdmin");

            migrationBuilder.DropTable(
                name: "TblFlightInfo");

            migrationBuilder.DropTable(
                name: "TblPassenger");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblAirline");

            migrationBuilder.DropTable(
                name: "TblTicketBooking");
        }
    }
}
