using AfroDungeonAndDragons.Models.CharacterCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Data
{
    public static class DefeaultRaceList
    {
        private static List<Race> _defaultRaceList = new List<Race>
        {
            new Race{ Id= 1},
            new Race{ Id= 2},
            new Race{ Id= 3},
            new Race{ Id= 4},
            new Race{ Id= 5},
            new Race{ Id= 6},
            new Race{ Id= 7},
            new Race{ Id= 8},
            new Race{ Id= 9},
            new Race{ Id= 10},
            new Race{ Id= 11},
            new Race{ Id= 12},
            new Race{ Id= 13},
            new Race{ Id= 14},
            new Race{ Id= 15},
            new Race{ Id= 16},
            new Race{ Id= 17},
            new Race{ Id= 18},
            new Race{ Id= 19},
            new Race{ Id= 20},
            new Race{ Id= 21},
            new Race{ Id= 22},
            new Race{ Id= 23},
            new Race{ Id= 24},
            new Race{ Id= 25},
            new Race{ Id= 26},
            new Race{ Id= 27},
            new Race{ Id= 28},
            new Race{ Id= 29},
            new Race{ Id= 30},
            new Race{ Id= 31},
            new Race{ Id= 32},
            new Race{ Id= 33},
            new Race{ Id= 34},
            new Race{ Id= 35},
            new Race{ Id= 36},
            new Race{ Id= 37},
            new Race{ Id= 38},
            new Race{ Id= 39},
            new Race{ Id= 40}
        };
        public static List<Race> GetList()
        {
            return _defaultRaceList;
        }
    }
}
