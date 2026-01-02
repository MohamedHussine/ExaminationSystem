using Entities.Models;
using DataAccess.Interfaces;
using DataAccess.Data;

namespace DataAccess.Repositories
{
    public class ExamRepository : GeneralRepository<Exam>, IExamRepository
    {
        public ExamRepository(Context context) : base(context)
        {
        }
    }
}
