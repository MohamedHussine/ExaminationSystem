
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enum;

namespace BusinessLogic.DTOs.Exam
{
    public class ExamsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CourseId { get; set; }

        public ExamType Type { get; set; }

        public int NumberOfQuestions { get; set; }

        public string InctractorId { get; set; }


    }
}
