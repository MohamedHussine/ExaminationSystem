
using DataAccess.Data;
using Entities.Models;

namespace DataAccess.Repositories
{
    internal class ExamQuestionRepository : GeneralRepository<ExamQuestion>
    {
        public ExamQuestionRepository(Context context) : base(context)
        {
        }
    }
}
