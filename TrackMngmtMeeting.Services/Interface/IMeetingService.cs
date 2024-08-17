using TrackMngmtMeeting.Services.DTOs.Request;
using TrackMngmtMeeting.Services.DTOs.Response;

namespace TrackMngmtMeeting.Services.Interface
{
    public interface IMeetingService
    {
        Task<MeetingResponse> CaptureNewMeeting(CreateMeetingRequest meetingDetails);
        Task<IReadOnlyList<MeetingListResponse>> GetAllMeetings();
        Task<IReadOnlyList<MeetingTypeResopnse>> GetMeetingTypes();
        Task<IReadOnlyList<MeetingItemsResponse>> GetMeetingItems(int MeeingTypeId);
        Task<bool> UpdateMeetingItemStatus(UpdateMeetingItemStatusRequest request);
    }
}