
using AutoMapper;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Services.DTOs;
using TrackMngmtMeeting.Services.DTOs.Request;
using TrackMngmtMeeting.Services.DTOs.Response;

namespace TrackMngmtMeeting.Services.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<MeetingItemDto, MeetingItem>();
            CreateMap<StatusDto, Status>();
            CreateMap<ActionItemDto, ActionItem>();
            CreateMap<MeetingTypeDto, MeetingType>();
            CreateMap<MeetingItemHistoryDto, MeetingItemHistory>();

            CreateMap<CreateMeetingRequest, Meeting>()
                 .ForMember(s => s.MeetingItems, d => d.MapFrom(x => x.MeetingItems));

            CreateMap<MeetingItemDto, MeetingItem>()
                .ForMember(s => s.MeetingItemHistory, d => d.MapFrom(x => x.MeetingItemHistory));
           

            CreateMap<Meeting, MeetingListResponse>()
                .ForMember(x => x.MeetingType, d => d.MapFrom(c => c.MeetingType.Name));


            CreateMap<Meeting, MeetingResponse>()
                .ForMember(x => x.MeetingType, d => d.MapFrom(c => c.MeetingType.Name))
                .ForMember(x => x.MeetingItems, d => d.MapFrom(c => c.MeetingItems));

            CreateMap<MeetingItem , MeetingItemDto>();
            CreateMap<MeetingType, MeetingTypeDto>();
            CreateMap<Status, StatusDto>();
            CreateMap<Meeting, MeetingDto>();
            CreateMap<ActionItem, ActionItemDto>();
            CreateMap<MeetingItemHistory, MeetingItemHistoryDto>();

            CreateMap<MeetingItem, MeetingItemsResponse>()
                .ForMember(s => s.Status, d => d.MapFrom(x => x.Status.Name))
                .ForMember(s => s.Meeting, d => d.MapFrom(x => x.Meeting.Name))
                .ForMember(s => s.MeetingType, d => d.MapFrom(x => x.Meeting.MeetingType.Name))
                .ForMember(s => s.ActionItems, d => d.MapFrom(x => x.ActionItems))
                .ForMember(s => s.MeetingItemHistory, d => d.MapFrom(x => x.MeetingItemHistory));

            CreateMap<UpdateMeetingItemStatusRequest, MeetingItemHistory>();

            CreateMap<MeetingType, MeetingTypeResopnse>();

            
        }
    }
}