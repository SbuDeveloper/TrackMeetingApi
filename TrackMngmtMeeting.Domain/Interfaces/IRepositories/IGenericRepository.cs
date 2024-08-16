using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.BaseEntity;

namespace TrackMngmtMeeting.Domain.Interfaces.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
		Task<IReadOnlyList<T>> GetAll();
		Task Add(T entity);
		void Delete(T entity);
		void Update(T entity);
    }
}