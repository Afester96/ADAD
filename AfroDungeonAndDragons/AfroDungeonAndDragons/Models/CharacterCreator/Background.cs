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
        [Required (ErrorMessage = "Не указано название предыстории")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Не указано описание")]
        public string Introduction { get; set; }
        public string SkillProficienciesDescription { get; set; }
        public string ToolProficienciesDescription { get; set; }
        public string EquipmentDescriptions { get; set; }
        public string FeatureDescription { get; set; }
        public string SuggestedCharcteristicsDescription { get; set; }
        public string SpellListIntroductionDescription { get; set; }
        public string SpellListExtendedDescription { get; set; }
        public string BackgroundVariantDescription { get; set; }
        public string LanguagesDescription { get; set; }
        public string BackgroundSpecificDescription { get; set; }
    }
}
