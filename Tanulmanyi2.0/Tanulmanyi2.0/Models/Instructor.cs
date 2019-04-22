using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tanulmanyi2._0.Models
{
    [Table("Instructors")]
    public class Instructor
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        public ICollection<Course> Courses { get; set; }

        public String UserName { get; set; }

        public byte[] Password { get; set; }
    }
}
