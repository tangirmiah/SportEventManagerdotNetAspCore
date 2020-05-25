using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportEvent.Migrations
{
    public partial class resetMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventInformations",
                columns: table => new
                {
                    eventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    dateOfEvent = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventInformations", x => x.eventID);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(nullable: true),
                    userSurname = table.Column<string>(nullable: true),
                    userDateOfBirth = table.Column<DateTime>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    userEmail = table.Column<string>(nullable: true),
                    userContactNumber = table.Column<string>(nullable: true),
                    userAddress = table.Column<string>(nullable: true),
                    userPostCode = table.Column<string>(nullable: true),
                    userRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.userID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventInformations");

            migrationBuilder.DropTable(
                name: "UserInformation");
        }
    }
}
