using EduHub.Ch02.Domain;
using EduHub.Ch02.Logging;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;

public class EventService
{
    private readonly IClubRepository _clubs;
    private readonly IAppLogger _logger;
    private readonly List<Event> _events = new();

    public EventService(IClubRepository clubs, IAppLogger logger)
    {
        _clubs = clubs;
        _logger = logger;
    }

    public Event CreateEvent(Guid clubId, string title, DateTime date)
    {
        var club = _clubs.GetById(clubId)
            ?? throw new InvalidOperationException("Club not found");

        var ev = new Event { Id = Guid.NewGuid(), ClubId = clubId, Title = title, Date = date };
        _events.Add(ev);
        _logger.Log($"Event created: {title} at {club.Name}");
        return ev;
    }
}