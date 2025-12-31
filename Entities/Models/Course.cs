using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public ICollection<Exam> Exam { get; set; }


        public string InstructorId { get; set; }
        public ApplicationUser Instructor { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
