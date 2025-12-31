using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser :IdentityUser

    {
        public string FullName { get; set; }

        public ICollection<Course> CoursesTaught { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }

        public ICollection<Question> CreatedQuestions { get; set; }

        public ICollection<Exam> CreatedExams { get; set; }
    }
}
