using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Background
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Introduction { get; set; }
        public string SkillProficienciesDescription { get; set; }
        public string ToolProficienciesDescription { get; set; }
        public string LanguageDescriptions { get; set; }
        public string EquipmentDescriptions { get; set; }
        [Required]
        public string FeatureName { get; set; }
        public string FeatureDescription { get; set; }
        [Required]
        public string SuggestedCharcteristicsDescription { get; set; }
        public string SpellListIntroductionDescription { get; set; }
        public string SpellListExtendedDescription { get; set; }
        public string ContactDescription { get; set; }
    }
}
