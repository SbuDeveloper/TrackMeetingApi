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

        public async Task<MeetingResponse> CaptureNewMeeting(CreateMeetingRequest meetingDetails)
        {
            if (meetingDetails != null)
			{
                foreach (var item in meetingDetails.MeetingItems)
                {
                   item.MeetingItemHistory.Add(new MeetingItemHistoryDto()
                   {
                     StatusId = item.StatusId
                   });
                }
                
                var meeting = _mapper.Map<CreateMeetingRequest, Meeting>(meetingDetails);
				await _unitOfWork._meeting.Add(meeting);
				var result = _unitOfWork.Save();

				if (result > 0)
                {
                    meeting = await _unitOfWork._meeting.GetMeetingByNameAsync(meetingDetails.Name);
                    return _mapper.Map<Meeting, MeetingResponse>(meeting);
                } 
			}
			return null;
        }

        public async Task<IReadOnlyList<MeetingListResponse>> GetAllMeetings()
        {
            var meetings = await _unitOfWork._meeting.GetAllMeetingsAsync();
            return _mapper.Map<IReadOnlyList<Meeting>, IReadOnlyList<MeetingListResponse>>(meetings);
        }

        public async Task<IReadOnlyList<MeetingItemsResponse>> GetMeetingItems(int MeetingTypeId)
        {
            var meetingItems = await _unitOfWork._meetingItem.GetMeetingItemsAsync(MeetingTypeId);
            return _mapper.Map<IReadOnlyList<MeetingItem>, IReadOnlyList<MeetingItemsResponse>>(meetingItems);
        }

        public async Task<IReadOnlyList<MeetingTypeResopnse>> GetMeetingTypes()
        {
            var meetingTypes = await _unitOfWork._meeting.GetMeetingTypesAsync();
            return _mapper.Map<IReadOnlyList<MeetingType>, IReadOnlyList<MeetingTypeResopnse>>(meetingTypes);
        }

        public async Task<bool> UpdateMeetingItemStatus(UpdateMeetingItemStatusRequest request)
        {
            var meetingItem = await _unitOfWork._meetingItem.GetById(request.MeetingItemId);
            if(meetingItem != null)
            {
                meetingItem.StatusId = request.StatusId;
                meetingItem.UpdatedOn = DateTime.Now;
                 _unitOfWork._meetingItem.Update(meetingItem);

                var history = _mapper.Map<UpdateMeetingItemStatusRequest, MeetingItemHistory>(request);
                await _unitOfWork._meetingItemHistory.Add(history);
                var result =_unitOfWork.Save();
                if(result > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}