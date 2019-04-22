using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tanulmanyi2._0.Models
{
    [Table("Trainings")]
    public class Training
    {
        [Key]
        public Int32 Id { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
