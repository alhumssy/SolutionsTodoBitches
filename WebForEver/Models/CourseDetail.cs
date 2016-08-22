namespace WebForEver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CourseDetail
    {
        [Key]
        public int idCoursedetails { get; set; }

        public int? idcourses { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public virtual Course Course { get; set; }
    }
}
