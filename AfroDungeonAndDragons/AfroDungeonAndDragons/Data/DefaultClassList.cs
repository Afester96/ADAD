using AfroDungeonAndDragons.Models.CharacterCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Data
{
    public static class DefaultClassList
    {
        private static List<Class> _defaultClassesList = new List<Class>
        {

        };
        public static List<Class> GetClassList()
        {
            return _defaultClassesList;
        }
    }
}
