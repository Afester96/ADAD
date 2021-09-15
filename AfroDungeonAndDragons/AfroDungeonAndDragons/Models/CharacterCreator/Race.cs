using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Race
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не указано название расы")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Не указано краткое описание")]
        public string ShortDescription { get; set; }
        public string LitratureDescription { get; set; }
        public string Description { get; set; }
        [Required (ErrorMessage = "Не указан краткий список особенностей")]
        public string ShortRacialTraitDescription { get; set; }
        public string RacialTraitDescription { get; set; }
        public string NamesMan { get; set; }
        public string NamesFemale { get; set; }
        public string NamesClan { get; set; }
        public string RacialCharacteristics { get; set; }
        public string RacialAge { get; set; }
        public string RacialIdeology { get; set; }
        public string RaceSize { get; set; }
        public string RacialSpellDescription { get; set; }
        public string RacialLanguages { get; set; }
        public string NamesDescription { get; set; }
        public string RaceSpeed { get; set; }
        public string SubraceDescription { get; set; }
        public string SubraceFeatureDescription { get; set; }

        public User User { get; set; }
        public bool Best { get; set; }
    }
}
