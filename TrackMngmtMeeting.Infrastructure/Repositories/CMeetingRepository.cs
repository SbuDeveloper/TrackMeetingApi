using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;

namespace TrackMngmtMeeting.Infrastructure.Repositories
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
            return await _applicationDbContext.Meetings
            .Include(x => x.MeetingType)
            .ToListAsync();
        }

        public async Task<IReadOnlyList<MeetingItem>> GetMeetingItemsAsync(int MeeingTypeId)
        {
            return await _applicationDbContext.MeetingItems
            .Where(x => x.Meeting.MeetingType.Id == MeeingTypeId)
            .Include(x => x.Meeting).ThenInclude(c => c.MeetingType)
            .Include(x => x.Status)
            .Include(x => x.ActionItems)
            .ToListAsync();
        }

    }
}