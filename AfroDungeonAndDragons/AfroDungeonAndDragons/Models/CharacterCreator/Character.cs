using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Character
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Backgrount { get; set; }
        public string PlayerName { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public int EperiencePoints { get; set; }
    }
}
