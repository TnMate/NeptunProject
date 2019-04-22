using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tanulmanyi2._0.Models
{
    [Table("StudentCourses")]
    public class StCourse
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [DisplayName("Course")]
        public Int32 CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [Required]
        [DisplayName("Student")]
        public Int32 StudentId { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        public Int32 Jegy { get; set; }

        public Boolean Completed { get; set; }

    }
}
