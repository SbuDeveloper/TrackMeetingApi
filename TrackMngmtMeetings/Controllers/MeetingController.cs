using Microsoft.AspNetCore.Mvc;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Services.DTOs.Request;
using TrackMngmtMeeting.Services.DTOs.Response;
using TrackMngmtMeeting.Services.Interface;

namespace TrackMngmtMeetings.Controllers
{
    [Route("api/[controller]")]
    public class MeetingController : ControllerBase
    {
        private readonly ILogger<MeetingController> _logger;
        private readonly IMeetingService _meetingService;

        public MeetingController(ILogger<MeetingController> logger, IMeetingService meetingService)
        {
            _logger = logger;
            _meetingService = meetingService;
        }

        [HttpGet]
		[Route("meetings")]
		public async Task<IReadOnlyList<MeetingListResponse>> GetAllMeetings()
        {
            return await _meetingService.GetAllMeetings();
        }

        [HttpPost]
		[Route("captureNewMeeting")]
		public async Task<MeetingResponse> CreateNewMeeting([FromBody]CreateMeetingRequest createMeetingRequest)
        {
            return await _meetingService.CaptureNewMeeting(createMeetingRequest);
        }
        
        [HttpGet]
		[Route("meetingItems")]
		public async Task<IReadOnlyList<MeetingItemsResponse>> GetMeetingItems(int MeetingTypeId)
        {
            return await _meetingService.GetMeetingItems(MeetingTypeId);

        }

        [HttpGet]
		[Route("getMeeting")]
		public async Task<MeetingResponse> GetMeetingByMeetingTypeId(int MeetingTypeId)
        {
            return await _meetingService.MeetingByMeetingType(MeetingTypeId);

        }

        [HttpPost]
		[Route("updateMeetingItemStatus")]
		public async Task<bool> UpdateMeetingItemStatus([FromBody]UpdateMeetingItemStatusRequest updateMeetingItemStatusRequest)
        {
            return await _meetingService.UpdateMeetingItemStatus(updateMeetingItemStatusRequest);
        }

        [HttpGet]
		[Route("getMeetingType")]
		public async Task<IReadOnlyList<MeetingTypeResopnse>> GetMeetingType()
        {
            return await _meetingService.GetMeetingTypes();
        }

        [HttpGet]
		[Route("getStatus")]
		public async Task<IReadOnlyList<StatusResopnse>> GetStatus()
        {
            return await _meetingService.GetStatusAsync();
        }
    }
}