namespace GameCatalogXApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemRequirement
    {
        public int Id { get; set; }

        public int? GameId { get; set; }

        [StringLength(100)]
        public string OS { get; set; }

        [StringLength(200)]
        public string Processor { get; set; }

        public long? Memory { get; set; }

        [StringLength(100)]
        public string Graphics { get; set; }

        public int? DirectX { get; set; }

        public long? Storage { get; set; }

        public virtual Game Game { get; set; }
    }
}
