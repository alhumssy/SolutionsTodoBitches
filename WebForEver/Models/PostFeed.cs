namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PostFeed")]
    public partial class PostFeed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostFeed()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string PostSubject { get; set; }

        public string PostContent { get; set; }

        [StringLength(50)]
        public string postImg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
