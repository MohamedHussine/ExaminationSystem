using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Choice : BaseModel
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public string Text { get; set; }
        public bool IsCorrect { get; set; }
    }
}
