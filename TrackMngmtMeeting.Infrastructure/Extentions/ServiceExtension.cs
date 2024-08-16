using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrackMngmtMeeting.Domain.Interfaces;
using TrackMngmtMeeting.Domain.Interfaces.IRepositories.IRepository;
using TrackMngmtMeeting.Infrastructure.Repositories.CRepository;
using TrackMngmtMeeting.Services;
using TrackMngmtMeeting.Services.Interface;

namespace TrackMngmtMeeting.Infrastructure.Extentions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TrackMngmtMeetingDbContext>(options =>
			{
				//options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
				options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
			});
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<IMeetingRepository, CMeetingRepository>();
			services.AddScoped<IMeetingItemRepository, CMeetingItemRepository>();
			services.AddScoped<IMeetingService, MeetingService>();
			services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

			return services;

        }
    }
}