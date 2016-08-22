namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subcategory")]
    public partial class Subcategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subcategory()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        public int Idsubcategory { get; set; }

        [StringLength(50)]
        public string subcategoryname { get; set; }

        public int? idcategorytype { get; set; }

        [StringLength(50)]
        public string subdescription { get; set; }

        public virtual CategoryType CategoryType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
