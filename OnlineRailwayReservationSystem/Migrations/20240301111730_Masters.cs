using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRailwayReservationSystem.Migrations
{
    public partial class Masters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_CancellationFees",
                columns: table => new
                {
                    CancellationFees_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cancellation_24Hours = table.Column<int>(type: "int", nullable: false),
                    Cancellation_12Hours = table.Column<int>(type: "int", nullable: false),
                    Cancellation_1Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_CancellationFees", x => x.CancellationFees_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_FareRule",
                columns: table => new
                {
                    Fare_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coach_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance_From = table.Column<int>(type: "int", nullable: false),
                    Distance_To = table.Column<int>(type: "int", nullable: false),
                    Ticket_Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_FareRule", x => x.Fare_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_ReservationFees",
                columns: table => new
                {
                    ReservationFees_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coach_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reservation_Fees = table.Column<int>(type: "int", nullable: false),
                    Super_Fast_Fees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_ReservationFees", x => x.ReservationFees_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_StationMaster",
                columns: table => new
                {
                    Station_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StationMaster", x => x.Station_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrainMaster",
                columns: table => new
                {
                    Train_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Train_No = table.Column<int>(type: "int", nullable: false),
                    Train_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Train_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedule_Mon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Tue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Wed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Thu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Fri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Sat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule_Sun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coach_A1 = table.Column<int>(type: "int", nullable: false),
                    Coach_A2 = table.Column<int>(type: "int", nullable: false),
                    Coach_A3 = table.Column<int>(type: "int", nullable: false),
                    Coach_SL = table.Column<int>(type: "int", nullable: false),
                    Coach_GN = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrainMaster", x => x.Train_Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_TrainScheduleMaster",
                columns: table => new
                {
                    Schedule_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Schedule_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Train_No = table.Column<int>(type: "int", nullable: false),
                    Station_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Arrival_Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Departure_Time = table.Column<TimeSpan>(type: "time", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_TrainScheduleMaster", x => x.Schedule_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_CancellationFees");

            migrationBuilder.DropTable(
                name: "tbl_FareRule");

            migrationBuilder.DropTable(
                name: "tbl_ReservationFees");

            migrationBuilder.DropTable(
                name: "tbl_StationMaster");

            migrationBuilder.DropTable(
                name: "tbl_TrainMaster");

            migrationBuilder.DropTable(
                name: "tbl_TrainScheduleMaster");
        }
    }
}
