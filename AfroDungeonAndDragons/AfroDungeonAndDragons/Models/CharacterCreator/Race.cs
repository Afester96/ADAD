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
        public Size Size { get; set; }
        public int Speed { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string RacialTrait { get; set; }
        public string FromBook { get; set; }
    }
}
