
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enum;

namespace BusinessLogic.DTOs.Exam
{
    public class AllExamsDTO
    {
        public string Name { get; set; }

        public string CourseName { get; set; }

        public ExamType Type { get; set; }

        public int NumberOfQuestions { get; set; }

        public string CreatedByInstructorName { get; set; }
    }
}
