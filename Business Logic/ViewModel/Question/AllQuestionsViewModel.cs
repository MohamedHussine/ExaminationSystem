using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.VeiwModels.Choice;
using Entities.Enum;

namespace BusinessLogic.VeiwModels.Question
{
    public class AllQuestionsViewModel
    {
        public string Text { get; set; }
        public QuestionLevel Level { get; set; }
        public bool IsReusable { get; set; }

        public string CreatedByInstructorId { get; set; }

        public List<AllChoiceViewModel> Choices { get; set; }
    }
}
