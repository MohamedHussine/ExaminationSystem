using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enum;

namespace Entities.Models
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public QuestionLevel Level { get; set; }
        public bool IsReusable { get; set; }

        public string CreatedByInstructorId { get; set; }
        public ApplicationUser CreatedByInstructor { get; set; }

        public ICollection<Choice> Choices { get; set; }
        public ICollection<ExamQuestion> ExamQuestions { get; set; }
    }
}
