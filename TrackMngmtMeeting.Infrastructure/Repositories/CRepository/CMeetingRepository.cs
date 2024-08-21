using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;

namespace TrackMngmtMeeting.Infrastructure.Repositories.CRepository
{
    public class CMeetingRepository : GenericRepository<Meeting>, IMeetingRepository
    {
        private readonly TrackMngmtMeetingDbContext _applicationDbContext;
        public CMeetingRepository(TrackMngmtMeetingDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IReadOnlyList<Meeting>> GetAllMeetingsAsync()
        {
            return await _applicationDbContext.Meetings.Include(x => x.MeetingType).ToListAsync();
        }
        
        public async Task<Meeting> MeetingByMeetingTypeIdAsync(int meetingTypeId)
        {
            return await _applicationDbContext.Meetings
            .Include(x => x.MeetingItems).ThenInclude(x => x.Status)
            .Include(x => x.MeetingItems).ThenInclude(p => p.ActionItems)
            .Include(x => x.MeetingType)
            .OrderBy(x => x.Id)
            .LastOrDefaultAsync(x => x.MeetingTypeId == meetingTypeId);
        }

        public async Task<Meeting> GetMeetingByNameAsync(string name)
        {
            return await _applicationDbContext.Meetings.Include(x => x.MeetingType).FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IReadOnlyList<MeetingType>> GetMeetingTypesAsync()
        {
            return await _applicationDbContext.MeetingTypes.ToListAsync();
        }

        public async Task<IReadOnlyList<Status>> GetStatusAsync()
        {
            return await _applicationDbContext.Statuses.ToListAsync();
        }
    }
}