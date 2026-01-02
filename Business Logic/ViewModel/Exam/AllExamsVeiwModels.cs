
using Entities.Enum;

namespace BusinessLogic.VeiwModels.Exam
{
    public class AllExamsVeiwModels
    {
        public string Name { get; set; }

        public string CourseName { get; set; }

        public ExamType Type { get; set; }

        public int NumberOfQuestions { get; set; }

        public string CreatedByInstructorName { get; set; }
    }
}
