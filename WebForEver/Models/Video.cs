namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Video")]
    public partial class Video
    {
        public int id { get; set; }

        [StringLength(50)]
        public string VideoName { get; set; }

        public string videoSrc { get; set; }

        public int? IdVideoCategory { get; set; }

        public virtual VideoCategory VideoCategory { get; set; }
    }
}
