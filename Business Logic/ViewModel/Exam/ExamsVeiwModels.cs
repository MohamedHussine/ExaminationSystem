using DataAccess.Models.Enums;

namespace BuisnessModel.VeiwModels.Exam
{
    public class ExamsVeiwModels
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CourseId { get; set; }

        public ExamType Type { get; set; }

        public int NumberOfQuestions { get; set; }
        public string InctractorId { get; set; }


    }
}
