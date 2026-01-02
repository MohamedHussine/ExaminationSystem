
using DataAccess.Data;
using Entities.Models;

namespace DataAccess.Repositories
{
    internal class StudentAnswerRepository : GeneralRepository<StudentAnswer> 
    {
        public StudentAnswerRepository(Context context) : base(context)
        {
        }
    }
}
