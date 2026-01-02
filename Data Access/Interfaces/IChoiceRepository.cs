
using Entities.Models;
namespace DataAccess.Interfaces
{
    public interface IChoiceRepository : IGeneralRepository<Choice>
    {
        IQueryable<Choice> GetAllByQuestionId(int questionId);

    }
}
