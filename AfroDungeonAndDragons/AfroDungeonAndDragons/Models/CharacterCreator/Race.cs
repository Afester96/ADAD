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
        [Required]
        public string Name { get; set; }
        public string FromBook { get; set; }
        public string ShortDescription { get; set; }
        public string LitratureDescription { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Names { get; set; }
        public string Subrace { get; set; }
        public string RacialTrait { get; set; }
        public int Speed { get; set; }
    }
}
