using Microsoft.EntityFrameworkCore.Migrations;

namespace AfroDungeonAndDragons.Migrations
{
    public partial class charactercreatormodelsupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "FeatureName",
                table: "Backgrounds");

            migrationBuilder.RenameColumn(
                name: "Subrace",
                table: "Races",
                newName: "SubraceFeatureDescription");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Races",
                newName: "SubraceDescription");

            migrationBuilder.RenameColumn(
                name: "RacialTrait",
                table: "Races",
                newName: "RacialTraitDescription");

            migrationBuilder.RenameColumn(
                name: "Names",
                table: "Races",
                newName: "RacialSpellDescription");

            migrationBuilder.RenameColumn(
                name: "FromBook",
                table: "Races",
                newName: "RacialLanguages");

            migrationBuilder.RenameColumn(
                name: "SpellCastingAbility",
                table: "Classes",
                newName: "Weapons");

            migrationBuilder.RenameColumn(
                name: "CanCastSpells",
                table: "Classes",
                newName: "VariantDescription");

            migrationBuilder.RenameColumn(
                name: "LanguageDescriptions",
                table: "Backgrounds",
                newName: "LanguagesDescription");

            migrationBuilder.RenameColumn(
                name: "ContactDescription",
                table: "Backgrounds",
                newName: "BackgroundVariantDescription");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamesClan",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamesDescription",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamesFemale",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NamesMan",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RaceSize",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RaceSpeed",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RacialAge",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RacialCharacteristics",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RacialIdeology",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortRacialTraitDescription",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Armor",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassCreationDescription",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassCreationTable",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassSpells",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Equipment",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HitDice",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HitPointsAtFirstLevel",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HitPointsAtHigherLevels",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LitratureDescription",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Multiclass",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuickBuild",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SavingThrows",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tools",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeDescriprion",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeTitle",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SuggestedCharcteristicsDescription",
                table: "Backgrounds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundSpecificDescription",
                table: "Backgrounds",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NamesClan",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "NamesDescription",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "NamesFemale",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "NamesMan",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RaceSize",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RaceSpeed",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RacialAge",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RacialCharacteristics",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "RacialIdeology",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "ShortRacialTraitDescription",
                table: "Races");

            migrationBuilder.DropColumn(
                name: "Armor",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassCreationDescription",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassCreationTable",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ClassSpells",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Equipment",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "HitDice",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "HitPointsAtFirstLevel",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "HitPointsAtHigherLevels",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "LitratureDescription",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Multiclass",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "QuickBuild",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "SavingThrows",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "Tools",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TypeDescriprion",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "TypeTitle",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "BackgroundSpecificDescription",
                table: "Backgrounds");

            migrationBuilder.RenameColumn(
                name: "SubraceFeatureDescription",
                table: "Races",
                newName: "Subrace");

            migrationBuilder.RenameColumn(
                name: "SubraceDescription",
                table: "Races",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "RacialTraitDescription",
                table: "Races",
                newName: "RacialTrait");

            migrationBuilder.RenameColumn(
                name: "RacialSpellDescription",
                table: "Races",
                newName: "Names");

            migrationBuilder.RenameColumn(
                name: "RacialLanguages",
                table: "Races",
                newName: "FromBook");

            migrationBuilder.RenameColumn(
                name: "Weapons",
                table: "Classes",
                newName: "SpellCastingAbility");

            migrationBuilder.RenameColumn(
                name: "VariantDescription",
                table: "Classes",
                newName: "CanCastSpells");

            migrationBuilder.RenameColumn(
                name: "LanguagesDescription",
                table: "Backgrounds",
                newName: "LanguageDescriptions");

            migrationBuilder.RenameColumn(
                name: "BackgroundVariantDescription",
                table: "Backgrounds",
                newName: "ContactDescription");

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SuggestedCharcteristicsDescription",
                table: "Backgrounds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FeatureName",
                table: "Backgrounds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
