using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameCatalogXApi.Models
{
    public class CustomerReviewDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Review { get; set; }

        [Required]
        public int? Rating { get; set; }

    }
}