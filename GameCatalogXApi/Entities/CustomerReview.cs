namespace GameCatalogXApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerReview
    {
        public int Id { get; set; }

        public int? GameId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public string Review { get; set; }

        public int? Rating { get; set; }

        public virtual Game Game { get; set; }
    }
}
