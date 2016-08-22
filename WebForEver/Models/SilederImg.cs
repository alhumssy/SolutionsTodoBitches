namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SilederImg")]
    public partial class SilederImg
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string imgslidsrc { get; set; }
    }
}
