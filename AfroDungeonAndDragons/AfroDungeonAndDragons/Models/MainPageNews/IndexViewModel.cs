using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.MainPageNews
{
    public class IndexViewModel
    {
        public IEnumerable<News> News { get; set; }
        public PageViewModel PageViewModel { get; set; }
    }
}
