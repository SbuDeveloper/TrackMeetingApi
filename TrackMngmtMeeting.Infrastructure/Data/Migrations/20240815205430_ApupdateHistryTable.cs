using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMngmtMeeting.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApupdateHistryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingItemHistories_ActionItems_ActionId",
                table: "MeetingItemHistories");

            migrationBuilder.DropIndex(
                name: "IX_MeetingItemHistories_ActionId",
                table: "MeetingItemHistories");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "MeetingItemHistories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "MeetingItemHistories",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MeetingItemHistories_ActionId",
                table: "MeetingItemHistories",
                column: "ActionId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingItemHistories_ActionItems_ActionId",
                table: "MeetingItemHistories",
                column: "ActionId",
                principalTable: "ActionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
