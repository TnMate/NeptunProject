using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tanulmanyi2._0.Models

{
    [Table("Courses")]
    public class Course
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [Required]
        [DisplayName("Instructor")]
        public Int32 InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public Instructor Instructor { get; set; }

        public DateTime Time { get; set; }

        public Int32 MaxStudents { get; set; }

        [Required]
        [DisplayName("Training")]
        public Int32 TrainingId { get; set; }

        [ForeignKey("TrainingId")]
        public Training Training { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
