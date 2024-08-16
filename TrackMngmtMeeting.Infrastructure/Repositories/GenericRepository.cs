

using Microsoft.EntityFrameworkCore;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories;

namespace TrackMngmtMeeting.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TrackMngmtMeetingDbContext _applicationDbContext;
		public GenericRepository(TrackMngmtMeetingDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}
        public async Task Add(T entity)
        {
            await _applicationDbContext.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _applicationDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _applicationDbContext.Set<T>().FindAsync(id);
        }

        public void Update(T entity)
        {
            _applicationDbContext.ChangeTracker.Clear();
			_applicationDbContext.Set<T>().Update(entity);
        }
    }
}