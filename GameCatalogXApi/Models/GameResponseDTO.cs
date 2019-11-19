using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameCatalogXApi.Models
{
    public class GameResponseDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "You have exceeded the max length for Name")]
        public string Name { get; set; }

        [MaxLength(1000, ErrorMessage = "You have exceeded the max length for Description")]
        public string Description { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public string About { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [MaxLength(100, ErrorMessage = "You have exceeded the max length for developer")]
        public string Developer { get; set; }

        [MaxLength(100, ErrorMessage = "You have exceeded the max length for publisher")]
        public string Publisher { get; set; }

        public ICollection<CustomerReviewResponseDTO> CustomerReviews { get; set; }

        public ICollection<ImageResponseDTO> Images { get; set; }

        public ICollection<SystemRequirementsResponseDTO> SystemRequirements { get; set; }

    }
}