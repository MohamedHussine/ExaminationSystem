
using DataAccess.Data;
using DataAccess.Interfaces;
using Entities.Models;
namespace DataAccess.Repositories
{
    public class CourseRepository : GeneralRepository<Course>, ICourseRepository
    {
        public CourseRepository(Context context) : base(context)
        {
          
        }
    }
}
