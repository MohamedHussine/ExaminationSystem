using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CourseAssignment : BaseModel
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }

        public DateTime AssignedAt { get; set; }
    }
}
