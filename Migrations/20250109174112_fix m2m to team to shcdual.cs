using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace worldcup.Migrations
{
    /// <inheritdoc />
    public partial class fixm2mtoteamtoshcdual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleTeam");

            migrationBuilder.CreateTable(
                name: "ScheduleTeams",
                columns: table => new
                {
                    SchedulesId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTeams", x => new { x.SchedulesId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_ScheduleTeams_Schedule_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleTeams_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTeams_TeamsId",
                table: "ScheduleTeams",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleTeams");

            migrationBuilder.CreateTable(
                name: "ScheduleTeam",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTeam", x => new { x.ScheduleId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_ScheduleTeam_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleTeam_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTeam_TeamId",
                table: "ScheduleTeam",
                column: "TeamId");
        }
    }
}
