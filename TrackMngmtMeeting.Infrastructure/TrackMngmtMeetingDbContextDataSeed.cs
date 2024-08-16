using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using TrackMngmtMeeting.Domain.Entities;

namespace TrackMngmtMeeting.Infrastructure
{
    public class TrackMngmtMeetingDbContextDataSeed
    {
        public static async Task SeedAsync(TrackMngmtMeetingDbContext dbContext)
		{
			if (!dbContext.MeetingTypes.Any())
			{
				var _meetingTypes = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\MeetingTypes.json");
				var meetingTypes = JsonSerializer.Deserialize<List<MeetingType>>(_meetingTypes);
				dbContext.MeetingTypes.AddRange(meetingTypes);
			}

			if (!dbContext.Statuses.Any())
			{
				var _statuses = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\Statuses.json");
				var statuses = JsonSerializer.Deserialize<List<Status>>(_statuses);
				dbContext.Statuses.AddRange(statuses);
			}

			if (!dbContext.Meetings.Any())
			{
				var _meetings = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\Meetings.json");
				var meetings = JsonSerializer.Deserialize<List<Meeting>>(_meetings);
				dbContext.Meetings.AddRange(meetings);
			}
			if (!dbContext.MeetingItems.Any())
			{
				var _meetingItems = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\MeetingItems.json");
				var meetingItems = JsonSerializer.Deserialize<List<MeetingItem>>(_meetingItems);
				dbContext.MeetingItems.AddRange(meetingItems);
			}

			if (!dbContext.ActionItems.Any())
			{
				var _actionItems = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\ActionItems.json");
				var actionItems = JsonSerializer.Deserialize<List<ActionItem>>(_actionItems);
				dbContext.ActionItems.AddRange(actionItems);
			}

			if (!dbContext.MeetingItemHistories.Any())
			{
				var _meetingItemHistories = File.ReadAllText("..\\TrackMngmtMeeting.Infrastructure\\Data\\SeedData\\MeetingItemHistory.json");
				var meetingItemHistories = JsonSerializer.Deserialize<List<MeetingItemHistory>>(_meetingItemHistories);
				dbContext.MeetingItemHistories.AddRange(meetingItemHistories);
			}

			if (dbContext.ChangeTracker.HasChanges()) await dbContext.SaveChangesAsync();
		}
	}
    
}