using System.Collections.Generic;
using System.Threading.Tasks;
using CESP.Core.Models;
using CESP.Database.Context.Education.Models;
using CESP.Database.Context.Payments.Models;
using CESP.Database.Context.Schedules.Models;
using CESP.Database.Context.StudentGroups.Models;
using CESP.Database.Context.Users.Models;

namespace CESP.Core.Contracts
{
    public interface ICespRepository
    {
        Task<List<TeacherDto>> GetTeachers(int? count);

        Task<List<CourseDto>> GetCourses(int? count);

        Task<List<StudentGroupDto>> GetStudentGroupsByCourseId(int courseId);
        Task<List<PriceDto>> GetPricesByGroupId(int groupId);

        Task<List<FeedbackDto>> GetFeedbacks(int? count);

        Task<List<StudentGroupDto>> GetStudentGroupsByBunchId(int bunchId);
        Task<List<ScheduleDto>> GetSchedulesByGroupId(int groupId);

        Task<List<GroupDurationDto>> GetDurationsByGroupId(int groupId);
    }
}