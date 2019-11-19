using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace GameCatalogXApi.Models
{

    public class SystemRequirementsDTO
    {
        [Required]
        [MaxLength(100, ErrorMessage = "You have exceeded max length for OS")]
        public string OS { get; set; }

        [MaxLength(200, ErrorMessage = "You have exceeded max length for Processor")]
        public string Processor { get; set; }

        public long? Memory { get; set; }

        [MaxLength(200, ErrorMessage = "You have exceeded max length for Graphics")]
        public string Graphics { get; set; }

        public int? DirectX { get; set; }

        public long? Storage { get; set; }

    }
}