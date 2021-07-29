using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.CharacterCreator
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Character> Characters { get; set; }
        public User()
        {
            Characters = new List<Character>();
        }
    }
}
