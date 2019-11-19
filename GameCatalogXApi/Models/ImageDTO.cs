using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameCatalogXApi.Models
{
    public class ImageDTO
    {
        [Required]
        public string ImageUrl { get; set; }

    }
}