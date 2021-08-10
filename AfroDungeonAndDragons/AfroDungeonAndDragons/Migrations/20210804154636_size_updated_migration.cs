using Microsoft.EntityFrameworkCore.Migrations;

namespace AfroDungeonAndDragons.Migrations
{
    public partial class size_updated_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Alignments_AlignmentId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_CanCastSpellses_CanCastSpellsId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Sizes_SizeId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Races_SizeId",
                table: "Races");

            migrationBuilder.DropIndex(
                name: "IX_Classes_CanCastSpellsId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AlignmentId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "CanCastSpellsId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "AlignmentId",
                table: "Characters");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CanCastSpells",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Alignment",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "CanCastSpells",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Alignment",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Races",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CanCastSpellsId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlignmentId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Races_SizeId",
                table: "Races",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_CanCastSpellsId",
                table: "Classes",
                column: "CanCastSpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AlignmentId",
                table: "Characters",
                column: "AlignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Alignments_AlignmentId",
                table: "Characters",
                column: "AlignmentId",
                principalTable: "Alignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_CanCastSpellses_CanCastSpellsId",
                table: "Classes",
                column: "CanCastSpellsId",
                principalTable: "CanCastSpellses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Sizes_SizeId",
                table: "Races",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
