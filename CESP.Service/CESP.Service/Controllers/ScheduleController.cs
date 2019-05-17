using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CESP.Core.Managers.Schedulers;
using CESP.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CESP.Service.Controllers
{
    [Route("schedules")]
    public class ScheduleController : Controller
    {
        private readonly IScheduleManager _scheduleManager;
        private readonly IMapper _mapper;

        public ScheduleController(
            IScheduleManager scheduleManager,
            IMapper mapper)
        {
            _scheduleManager = scheduleManager;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetList(int bunchId)
        {
            var schedules = await _scheduleManager.GetList(bunchId);

            return Ok(schedules.Select(t => _mapper.Map<ScheduleResponse>(t)));
        }

        [HttpGet]
        [Route("bunches")]
        public async Task<IActionResult> GetBunches()
        {
            var banches = await _scheduleManager.GetBunches();

            return Ok(banches.Select(b => _mapper.Map<GroupBunchResponse>(b)));
        }

        [HttpGet]
        [Route("{bunch}")]
        public async Task<IActionResult> GetList([FromRoute] string bunch)
        {
            var schedules = await _scheduleManager.GetList(bunch);

            return Ok(schedules.Select(t => _mapper.Map<ScheduleResponse>(t)));
        }
    }
}