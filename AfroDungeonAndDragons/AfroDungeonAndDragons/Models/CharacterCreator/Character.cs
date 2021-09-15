using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Character
    {
        public int Id { get; set; }
        [Required]
        public string CharacterName { get; set; }
        public Class Class { get; set; }
        public int Level { get; set; }
        public Background Background { get; set; }
        [Required]
        public string PlayerName { get; set; }
        public Race Race { get; set; }
        [Required]
        public string Alignment { get; set; }
        public int EperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity {get;set;}
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public User User { get; set; }
        public bool Best { get; set; }
    }
}
