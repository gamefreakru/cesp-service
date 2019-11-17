using AutoMapper;
using CESP.Core.Models;
using CESP.Service.ViewModels.Requests;
using CESP.Service.ViewModels.Responses;

namespace CESP.Service
{
    public class CespViewMappingProfile : Profile
    {
        public CespViewMappingProfile()
        {
            CreateMap<Teacher, TeacherResponse>();
            CreateMap<Course, CourseResponse>();
            CreateMap<Feedback, FeedbackResponse>();
            CreateMap<Event, EventResponse>();
            CreateMap<EventShort, EventShortResponse>();
            CreateMap<SpeakingClubMeeting, SpeakingClubMeetingResponse>();
            CreateMap<SpeakingClubMeetingShort, SpeakingClubMeetingShortResponse>();
            CreateMap<Level, LevelResponse>();
            CreateMap<Language, LanguageResponse>();

            CreateMap<Schedule, ScheduleResponse>();
            CreateMap<Price, PriceResponse>();
            CreateMap<GroupDuration, GroupDurationResponse>();
            CreateMap<LessonTime, LessonTimeResponse>();
            
            CreateMap<AddSpeakingClubRequest, SpeakingClubMeeting>()
                .ForMember(dest => dest.FileInfo,
                    opt => opt.MapFrom(src => src.Name
                    ));
        }
    }
}