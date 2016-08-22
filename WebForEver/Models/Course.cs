namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            CourseDetails = new HashSet<CourseDetail>();
            UserProfiles = new HashSet<UserProfile>();
            VideoCategories = new HashSet<VideoCategory>();
        }

        [Key]
        public int IdCourse { get; set; }

        [StringLength(50)]
        public string CoursName { get; set; }

        [StringLength(50)]
        public string shortDescription { get; set; }

        public DateTime? dateExpected { get; set; }

        public int? hoursNO { get; set; }

        public bool? feature { get; set; }

        [StringLength(50)]
        public string imgsrc { get; set; }

        [StringLength(50)]
        public string vediosrc { get; set; }

        public int? idsubcategory { get; set; }

        public virtual Subcategory Subcategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseDetail> CourseDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoCategory> VideoCategories { get; set; }
    }
}
