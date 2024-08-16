using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;

namespace TrackMngmtMeeting.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMeetingRepository _meeting { get; }
        IMeetingItemRepository _meetingItem { get; }
        int Save();
    }
}