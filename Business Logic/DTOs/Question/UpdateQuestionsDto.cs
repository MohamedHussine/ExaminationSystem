
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enum;

namespace BusinessLogic.DTOs.Question
{
    public class UpdateQuestionsDto
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public QuestionLevel Level { get; set; }
        public bool IsReusable { get; set; }

        public string CreatedByInstructorId { get; set; }
    }
}
