using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectOneApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "BloodPressureRecords",
                columns: table => new
                {
                    ReadingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Systolic = table.Column<int>(type: "int", nullable: false),
                    Diastolic = table.Column<int>(type: "int", nullable: false),
                    Pulse = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressureRecords", x => x.ReadingId);
                    table.ForeignKey(
                        name: "FK_BloodPressureRecords_UserProfiles_UserProfileUserId",
                        column: x => x.UserProfileUserId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BloodPressureRecords_UserProfileUserId",
                table: "BloodPressureRecords",
                column: "UserProfileUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodPressureRecords");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
