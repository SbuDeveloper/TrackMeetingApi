
using System.IO.Compression;
using AutoMapper;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Domain.Interfaces;
using TrackMngmtMeeting.Services.DTOs;
using TrackMngmtMeeting.Services.DTOs.Request;
using TrackMngmtMeeting.Services.DTOs.Response;
using TrackMngmtMeeting.Services.Interface;

namespace TrackMngmtMeeting.Services
{
    public class MeetingService : IMeetingService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MeetingService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<MeetingItemsResponse?> CaptureNewMeeting(CreateMeetingRequest meetingDetails)
        {
            if (meetingDetails != null)
			{
                var meeting = _mapper.Map<CreateMeetingRequest, Meeting>(meetingDetails);
				await _unitOfWork._meetingRepository.Add(meeting);
				var result = _unitOfWork.Save();

				if (result > 0)
					return new MeetingItemsResponse();
				else
					return new MeetingItemsResponse();
			}
			return null;
        }

        public async Task<IReadOnlyList<MeetingListResponse>> GetAllMeetings()
        {
            var meetings = await _unitOfWork._meetingRepository.GetAllMeetingsAsync();
            return _mapper.Map<IReadOnlyList<Meeting>, IReadOnlyList<MeetingListResponse>>(meetings);
        }

        public async Task<IReadOnlyList<MeetingItemsResponse>> GetMeetingItems(int MeetingTypeId)
        {
            var meetingItems = await _unitOfWork._meetingRepository.GetMeetingItemsAsync(MeetingTypeId);
            return _mapper.Map<IReadOnlyList<MeetingItem>, IReadOnlyList<MeetingItemsResponse>>(meetingItems);
        }
    }
}