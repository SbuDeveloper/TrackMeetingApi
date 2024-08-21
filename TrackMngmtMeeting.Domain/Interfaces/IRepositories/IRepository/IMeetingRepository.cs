using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository
{
    public interface IMeetingRepository : IGenericRepository<Meeting>
    {
        Task<IReadOnlyList<Meeting>> GetAllMeetingsAsync();
        Task<Meeting> GetMeetingByNameAsync(string name);
        Task<IReadOnlyList<MeetingType>> GetMeetingTypesAsync();
        Task<IReadOnlyList<Status>> GetStatusAsync();
        Task<Meeting> MeetingByMeetingTypeIdAsync(int meetingTypeId);

    }
}