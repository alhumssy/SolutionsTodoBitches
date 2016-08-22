//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datalogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.CourseDetails = new HashSet<CourseDetail>();
            this.UserProfiles = new HashSet<UserProfile>();
            this.VideoCategories = new HashSet<VideoCategory>();
        }
    
        public int IdCourse { get; set; }
        public string CoursName { get; set; }
        public string shortDescription { get; set; }
        public Nullable<System.DateTime> dateExpected { get; set; }
        public Nullable<int> hoursNO { get; set; }
        public Nullable<bool> feature { get; set; }
        public string imgsrc { get; set; }
        public string vediosrc { get; set; }
        public Nullable<int> idsubcategory { get; set; }
    
        public virtual Subcategory Subcategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseDetail> CourseDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoCategory> VideoCategories { get; set; }
    }
}
