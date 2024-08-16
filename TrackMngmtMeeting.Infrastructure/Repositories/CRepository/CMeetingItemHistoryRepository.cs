using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Entities;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;

namespace TrackMngmtMeeting.Infrastructure.Repositories.CRepository
{
    public class CMeetingItemHistoryRepository : GenericRepository<MeetingItemHistory>, IMeetingItemHistoryRepository
    {
        public CMeetingItemHistoryRepository(TrackMngmtMeetingDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}