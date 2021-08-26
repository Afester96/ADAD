using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Class
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не указано название класса")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Не указано краткое описание")]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string LitratureDescription { get; set; }
        public string ClassCreationDescription { get; set; }
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
        public string Equipment { get; set; }
        public string ClassSpells { get; set; }
        public string TypeTitle { get; set; }
        public string TypeDescriprion { get; set; }
        public string VariantDescription { get; set; }
    }
}
