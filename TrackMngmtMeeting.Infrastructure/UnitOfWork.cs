using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Interfaces;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;

namespace TrackMngmtMeeting.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TrackMngmtMeetingDbContext _dbContext;
        public IMeetingRepository _meeting { get; }

        public IMeetingItemRepository _meetingItem { get; }

        public UnitOfWork(TrackMngmtMeetingDbContext dbContext, IMeetingRepository meetingRepository, IMeetingItemRepository meetingItemRepository)
        {
            _dbContext = dbContext;
            _meeting = meetingRepository;
            _meetingItem = meetingItemRepository;

        }
        public void Dispose()
        {
            Dispose(true);
			GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
			{
				_dbContext.Dispose();
			}
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}