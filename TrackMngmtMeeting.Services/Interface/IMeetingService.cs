using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Services.DTOs.Request;
using TrackMngmtMeeting.Services.DTOs.Response;

namespace TrackMngmtMeeting.Services.Interface
{
    public interface IMeetingService
    {
        Task<MeetingItemsResponse> CaptureNewMeeting(CreateMeetingRequest meetingDetails);
        Task<IReadOnlyList<MeetingListResponse>> GetAllMeetings();
        Task<IReadOnlyList<MeetingItemsResponse>> GetMeetingItems(int MeeingTypeId);
    }
}