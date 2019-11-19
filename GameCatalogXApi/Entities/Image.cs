namespace GameCatalogXApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Image
    {
        public int Id { get; set; }

        public int? GameId { get; set; }

        [StringLength(200)]
        public string ImageUrl { get; set; }

        public virtual Game Game { get; set; }
    }
}
