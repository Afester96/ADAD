using Microsoft.EntityFrameworkCore.Migrations;

namespace AfroDungeonAndDragons.Migrations
{
    public partial class added_persanal_lists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Best",
                table: "Races",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Races",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Best",
                table: "Classes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Best",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Best",
                table: "Backgrounds",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Backgrounds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Races_UserId",
                table: "Races",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_UserId",
                table: "Classes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Backgrounds_UserId",
                table: "Backgrounds",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_Users_UserId",
                table: "Backgrounds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Users_UserId",
                table: "Classes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Users_UserId",
                table: "Races",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_Users_UserId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Users_UserId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Users_UserId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_UserId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Classes_UserId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Backgrounds_UserId",
                table: "Backgrounds");

            migrationBuilder.DropColumn(
                name: "Best",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Best",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Best",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Best",
                table: "Backgrounds");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Backgrounds");
        }
    }
}
