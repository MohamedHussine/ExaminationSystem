
using DataAccess.Data;
using DataAccess.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Repositories
{
    public class ChoiceRepository : GeneralRepository<Choice> , IChoiceRepository
    {
        Context _context;
        public ChoiceRepository(Context context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Choice> GetAllByQuestionId(int questionId)
        {
            var res = _context.Choices.Where(x => !x.IsDeleted && x.QuestionId == questionId);
            return res;
        }
    }
}
