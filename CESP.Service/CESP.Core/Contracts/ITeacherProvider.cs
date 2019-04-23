using System.Collections.Generic;
using System.Threading.Tasks;
using CESP.Core.Models;

namespace CESP.Core.Contracts
{
    public interface ITeacherProvider
    {
        Task<List<Teacher>> GetTeachers(int? count);
    }
}