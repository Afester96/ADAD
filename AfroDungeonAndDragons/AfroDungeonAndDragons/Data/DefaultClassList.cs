using AfroDungeonAndDragons.Models.CharacterCreator;
using AfroDungeonAndDragons.Models.DefaultInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Data
{
    public static class DefaultClassList
    {
        private static List<DefaultClass> _defaultClassesList = new List<DefaultClass>
        {

        };
        public static List<DefaultClass> GetClassList()
        {
            return _defaultClassesList;
        }
    }
}
