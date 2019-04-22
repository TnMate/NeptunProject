using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tanulmanyi2._0.Models
{
    public class HomeViewModel
    {
        public SelectList trainings;
        public List<Course> courses;
        public List<Instructor> instructors;

        public string ChoosenTraining { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
    }
}
