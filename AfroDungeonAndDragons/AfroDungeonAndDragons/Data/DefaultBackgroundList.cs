using AfroDungeonAndDragons.Models.CharacterCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Data
{
    public static class DefaultBackgroundList
    {
        private static List<Background> _defaultBackgroundsList = new List<Background>
        {

        };
        public static List<Background> GetBackgroundList()
        {
            return _defaultBackgroundsList;
        }
    }
}
