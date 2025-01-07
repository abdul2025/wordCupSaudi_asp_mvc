using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace worldcup.Migrations
{
    /// <inheritdoc />
    public partial class deleteCityFromSheduleandAddItToStidum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_provinces_ProvinceId",
                table: "cities");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_cities_CityId",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_schedule_stadiums_StadiumId",
                table: "schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_scheduleTeam_schedule_ScheduleId",
                table: "scheduleTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_scheduleTeam_stadiums_StadiumId",
                table: "scheduleTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeams_schedule_ScheduleId",
                table: "ScheduleTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeams_team_TeamsId",
                table: "ScheduleTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_transport_categoriesTransports_VehicleId",
                table: "transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transport",
                table: "transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_stadiums",
                table: "stadiums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_scheduleTeam",
                table: "scheduleTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schedule",
                table: "schedule");

            migrationBuilder.DropIndex(
                name: "IX_schedule_CityId",
                table: "schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_provinces",
                table: "provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cities",
                table: "cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_team",
                table: "team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoriesTransports",
                table: "categoriesTransports");

            migrationBuilder.DropColumn(
                name: "City",
                table: "stadiums");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "schedule");

            migrationBuilder.RenameTable(
                name: "transport",
                newName: "Transport");

            migrationBuilder.RenameTable(
                name: "stadiums",
                newName: "Stadiums");

            migrationBuilder.RenameTable(
                name: "scheduleTeam",
                newName: "ScheduleTeam");

            migrationBuilder.RenameTable(
                name: "schedule",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "provinces",
                newName: "Provinces");

            migrationBuilder.RenameTable(
                name: "cities",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "categoriesTransports",
                newName: "CategoriesTransport");

            migrationBuilder.RenameIndex(
                name: "IX_transport_VehicleId",
                table: "Transport",
                newName: "IX_Transport_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_scheduleTeam_StadiumId",
                table: "ScheduleTeam",
                newName: "IX_ScheduleTeam_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_scheduleTeam_ScheduleId",
                table: "ScheduleTeam",
                newName: "IX_ScheduleTeam_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_schedule_StadiumId",
                table: "Schedule",
                newName: "IX_Schedule_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_cities_ProvinceId",
                table: "Cities",
                newName: "IX_Cities_ProvinceId");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Stadiums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transport",
                table: "Transport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ScheduleTeam",
                table: "ScheduleTeam",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriesTransport",
                table: "CategoriesTransport",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_CityId",
                table: "Stadiums",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Stadiums_StadiumId",
                table: "Schedule",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeam_Schedule_ScheduleId",
                table: "ScheduleTeam",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeam_Stadiums_StadiumId",
                table: "ScheduleTeam",
                column: "StadiumId",
                principalTable: "Stadiums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeams_Schedule_ScheduleId",
                table: "ScheduleTeams",
                column: "ScheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeams_Teams_TeamsId",
                table: "ScheduleTeams",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Cities_CityId",
                table: "Stadiums",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transport_CategoriesTransport_VehicleId",
                table: "Transport",
                column: "VehicleId",
                principalTable: "CategoriesTransport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Provinces_ProvinceId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Stadiums_StadiumId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeam_Schedule_ScheduleId",
                table: "ScheduleTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeam_Stadiums_StadiumId",
                table: "ScheduleTeam");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeams_Schedule_ScheduleId",
                table: "ScheduleTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleTeams_Teams_TeamsId",
                table: "ScheduleTeams");

            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Cities_CityId",
                table: "Stadiums");

            migrationBuilder.DropForeignKey(
                name: "FK_Transport_CategoriesTransport_VehicleId",
                table: "Transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transport",
                table: "Transport");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stadiums",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_CityId",
                table: "Stadiums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ScheduleTeam",
                table: "ScheduleTeam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Provinces",
                table: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriesTransport",
                table: "CategoriesTransport");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Stadiums");

            migrationBuilder.RenameTable(
                name: "Transport",
                newName: "transport");

            migrationBuilder.RenameTable(
                name: "Stadiums",
                newName: "stadiums");

            migrationBuilder.RenameTable(
                name: "ScheduleTeam",
                newName: "scheduleTeam");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "schedule");

            migrationBuilder.RenameTable(
                name: "Provinces",
                newName: "provinces");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "cities");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "team");

            migrationBuilder.RenameTable(
                name: "CategoriesTransport",
                newName: "categoriesTransports");

            migrationBuilder.RenameIndex(
                name: "IX_Transport_VehicleId",
                table: "transport",
                newName: "IX_transport_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleTeam_StadiumId",
                table: "scheduleTeam",
                newName: "IX_scheduleTeam_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_ScheduleTeam_ScheduleId",
                table: "scheduleTeam",
                newName: "IX_scheduleTeam_ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_StadiumId",
                table: "schedule",
                newName: "IX_schedule_StadiumId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ProvinceId",
                table: "cities",
                newName: "IX_cities_ProvinceId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "stadiums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transport",
                table: "transport",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_stadiums",
                table: "stadiums",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_scheduleTeam",
                table: "scheduleTeam",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schedule",
                table: "schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_provinces",
                table: "provinces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cities",
                table: "cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_team",
                table: "team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoriesTransports",
                table: "categoriesTransports",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_schedule_CityId",
                table: "schedule",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_provinces_ProvinceId",
                table: "cities",
                column: "ProvinceId",
                principalTable: "provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_cities_CityId",
                table: "schedule",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedule_stadiums_StadiumId",
                table: "schedule",
                column: "StadiumId",
                principalTable: "stadiums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_scheduleTeam_schedule_ScheduleId",
                table: "scheduleTeam",
                column: "ScheduleId",
                principalTable: "schedule",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_scheduleTeam_stadiums_StadiumId",
                table: "scheduleTeam",
                column: "StadiumId",
                principalTable: "stadiums",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeams_schedule_ScheduleId",
                table: "ScheduleTeams",
                column: "ScheduleId",
                principalTable: "schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleTeams_team_TeamsId",
                table: "ScheduleTeams",
                column: "TeamsId",
                principalTable: "team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transport_categoriesTransports_VehicleId",
                table: "transport",
                column: "VehicleId",
                principalTable: "categoriesTransports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
