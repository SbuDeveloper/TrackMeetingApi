using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Infrastructure
{
    public class TrackMngmtMeetingDbContext : DbContext
    {
        public TrackMngmtMeetingDbContext(DbContextOptions<TrackMngmtMeetingDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingItem> MeetingItems { get; set; }
        public DbSet<MeetingItemHistory> MeetingItemHistories { get; set; }
        public DbSet<ActionItem> ActionItems { get; set; }
        public DbSet<MeetingType> MeetingTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}