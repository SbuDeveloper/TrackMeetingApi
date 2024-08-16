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
        public IMeetingRepository _meetingRepository { get; }

        public UnitOfWork(TrackMngmtMeetingDbContext dbContext, IMeetingRepository meetingRepository)
        {
            dbContext = dbContext;
            _meetingRepository = meetingRepository;
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