
using DataAccess.Data;
using DataAccess.Repositories;
using Entities.Models;
namespace DataAccess.Repositories
{
    public class StudentExamRepository : GeneralRepository<StudentExam>
    {
        public StudentExamRepository(Context context) : base(context)
        {
        }
    }
}
