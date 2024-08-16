using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Infrastructure.Data.Configuration
{
    public class MeetingItemConfiguration : IEntityTypeConfiguration<MeetingItem>
    {
        public void Configure(EntityTypeBuilder<MeetingItem> builder)
        {
            builder
                .HasMany(c => c.ActionItems)
                .WithOne(e => e.MeetingItem)
                .HasForeignKey(x => x.MeetingItemId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(c => c.MeetingItemHistory)
                .WithOne(e => e.MeetingItem)
                .HasForeignKey(x => x.MeetingItemId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}