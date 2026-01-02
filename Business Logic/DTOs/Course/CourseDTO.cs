using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.DTOs.Course
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }

        public string InstructorId { get; set; }
    }
}
