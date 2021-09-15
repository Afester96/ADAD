using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AfroDungeonAndDragons.ViewModels
{
    public class NewsViewModel
    {
        [Required(ErrorMessage = "Не введён заголовок новости")]
        public string NewsTitle { get; set; }
        public string ShortNewsDescription { get; set; }
        public string NewsDescription { get; set; }

        [Display(Name = "Image")]
        public IFormFile ViewImage { get; set; }
    }
}
