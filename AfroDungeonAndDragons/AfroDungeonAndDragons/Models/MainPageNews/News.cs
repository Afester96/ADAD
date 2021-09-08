using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.Models.MainPageNews
{
    public class News
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не введён заголовок новости")]
        public string NewsTitle { get; set; }
        public string ShortNewsDescription { get; set; }
        public string NewsDescription { get; set; }
        public byte[] Image { get; set; }
    }
}
