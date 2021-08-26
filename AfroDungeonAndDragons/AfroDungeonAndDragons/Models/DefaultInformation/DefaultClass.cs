using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.DefaultInformation
{
    public class DefaultClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string[] Description { get; set; }
        public string FromBook { get; set; }
        public string LitratureDescription { get; set; }
        public string[] DescriptionTitle { get; set; }
        public string ClassCreationTitle { get; set; }
        public string ClassCreationDescription { get; set; }
        public string ClassCreationTableTitle { get; set; }
        public string ClassCreationTable { get; set; }
        public string QuickBuild { get; set; }
        public string Multiclass { get; set; }
        public string HitDice { get; set; }
        public string HitPointsAtFirstLevel { get; set; }
        public string HitPointsAtHigherLevels { get; set; }
        public string Armor { get; set; }
        public string Weapons { get; set; }
        public string Tools { get; set; }
        public string SavingThrows { get; set; }
        public string Skills { get; set; }
        public string[] Equipment { get; set; }
        public string[] ClassSpellTitle { get; set; }
        public string[] ClassSpellDescription { get; set; }
        public string TypeTitle { get; set; }
        public string TypeDescriprion { get; set; }
        public string[] VariantsTitle { get; set; }
        public string[] VariantDescription { get; set; }
        public string[] VariantSpellsTitle { get; set; }
        public string[] VariantSpellsDescription { get; set; }
    }
}
