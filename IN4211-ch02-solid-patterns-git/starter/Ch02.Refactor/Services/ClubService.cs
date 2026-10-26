using EduHub.Ch02.Domain;
using EduHub.Ch02.Logging;
using EduHub.Ch02.Notifications;
using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;
// Services/ClubService.cs
public class ClubService
{
    private readonly IClubRepository _clubs;
    private readonly IMemberRepository _members;
    private readonly IAppLogger _logger;
    private readonly INotificationService _notifier;

    public ClubService(IClubRepository clubs, IMemberRepository members,
                       IAppLogger logger, INotificationService notifier)
    { _clubs = clubs; _members = members; _logger = logger; _notifier = notifier; }

    public Club CreateClub(string name, string description, string presidentEmail)
    {
        var club = Club.Create(name, description);   // validate nằm ở Domain
        _clubs.Add(club);
        _logger.Log($"Club created: {name}");
        _notifier.Send(presidentEmail, $"Club {name} created");
        return club;
    }

    public void AddMember(Guid clubId, string name, string email)
    {
        var club = _clubs.GetById(clubId)
            ?? throw new InvalidOperationException("Club not found");
        if (!club.HasRoom(_members.CountByClub(clubId)))
            throw new InvalidOperationException("Club is full");
        _members.Add(new Member { Id = Guid.NewGuid(), Name = name, Email = email, ClubId = clubId });
        _logger.Log($"Member {name} joined {club.Name}");
        _notifier.Send(email, $"Welcome to {club.Name}");
    }
}