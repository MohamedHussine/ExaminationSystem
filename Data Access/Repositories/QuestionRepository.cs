
using DataAccess.Data;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
namespace DataAccess.Repositories
{
    public class QuestionRepository : GeneralRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(Context context) : base(context)
        {
        }

    }
}
