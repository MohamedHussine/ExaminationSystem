using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.DTOs.Choice
{
    public class AllChoiceDto
    {
        public int QuestionId { get; set; }

        public string Text { get; set; }

        public bool IsCorrect { get; set; }

    }
}
