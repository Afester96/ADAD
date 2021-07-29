using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public SpellCastingAbility SpellCastingAbility { get;set;}
        public CanCastSpells CanCastSpells { get; set; }
    }
}
