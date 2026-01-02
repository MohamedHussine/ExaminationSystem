
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.DTOs.Choice;
using Entities.Enum;

namespace BusinessLogic.DTOs.Question
{
    public class AddQuestionsDto
    {
        public string Text { get; set; }
        public QuestionLevel Level { get; set; }
        public bool IsReusable { get; set; }

        public string CreatedByInstructorId { get; set; }

        public List<AddChoiceDto> Choices { get; set; }
    }
}
