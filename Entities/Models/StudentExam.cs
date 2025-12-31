using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentExam : BaseModel
    {
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        public string StudentId { get; set; }
        public ApplicationUser Student { get; set; }

        public DateTime AssignedAt { get; set; }
        public bool IsCompleted { get; set; }
        public double? Score { get; set; }
        public DateTime? AttemptedAt { get; set; }

        public ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}
