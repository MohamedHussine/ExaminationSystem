using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.VeiwModels.Course
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }

        public string InstructorId { get; set; }
    }
}
