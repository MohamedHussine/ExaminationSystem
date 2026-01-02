
using DataAccess.Data;
using Entities.Models;
namespace DataAccess.Repositories
{
    internal class CourseAssignmentRepository : GeneralRepository<CourseAssignment>
    {
        public CourseAssignmentRepository(Context context) : base(context)
        {
        }
    
    }
}
