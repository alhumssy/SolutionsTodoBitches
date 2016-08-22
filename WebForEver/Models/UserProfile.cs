namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserProfile")]
    public partial class UserProfile
    {
        [Key]
        public int iduserpor { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }

        public int? CourseId { get; set; }

        public bool? isregister { get; set; }

        public int? phonenum { get; set; }

        public bool? Intrested { get; set; }

        public int? PostId { get; set; }

        public virtual Course Course { get; set; }

        public virtual PostFeed PostFeed { get; set; }

        public virtual ApplicationUser User { get; set; }
         public string ApplicationUserId  {get;set;}
    }
}
