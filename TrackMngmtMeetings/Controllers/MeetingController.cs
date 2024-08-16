using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
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
    }
}