# Sibusiso-Nyambose

# Create New Migrations
 dotnet ef migrations add ApupdateHistryTable --output-dir Data/Migrations --project TrackMngmtMeeting.Infrastructure.csproj --context TrackMngmtMeetingDbContext --startup-project ../TrackMngmtMeetings/TrackMngmtMeetings.csproj -v

dotnet ef database update --project TrackMngmtMeeting.Infrastructure.csproj --startup-project ../TrackMngmtMeetings/TrackMngmtMeetings.csproj -v
 
