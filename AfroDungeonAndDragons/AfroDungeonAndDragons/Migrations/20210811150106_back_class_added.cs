using Microsoft.EntityFrameworkCore.Migrations;

namespace AfroDungeonAndDragons.Migrations
{
    public partial class back_class_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DefaultBackgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillProficienciesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToolProficienciesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuggestedCharcteristicsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellListIntroductionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellListExtendedDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundVariant = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultBackgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefaultClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellCastingAbility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CanCastSpells = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultClasses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DefaultBackgrounds");

            migrationBuilder.DropTable(
                name: "DefaultClasses");
        }
    }
}
