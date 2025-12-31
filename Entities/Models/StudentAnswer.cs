using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class StudentAnswer : BaseModel
    {
        public int StudentExamId { get; set; }
        public StudentExam StudentExam { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int? ChoiceId { get; set; }
        public Choice? Choice { get; set; }

        public bool IsCorrect { get; set; }
    }
}
