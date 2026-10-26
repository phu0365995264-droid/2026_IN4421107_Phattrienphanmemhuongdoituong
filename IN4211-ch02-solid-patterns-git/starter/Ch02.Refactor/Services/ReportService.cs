using EduHub.Ch02.Repositories;

namespace EduHub.Ch02.Services;

public class ReportService
{
    private readonly IClubRepository _clubs;
    private readonly IMemberRepository _members;

    public ReportService(IClubRepository clubs, IMemberRepository members)
    {
        _clubs = clubs;
        _members = members;
    }

    public void Generate()
    {
        foreach (var club in _clubs.GetAll())
        {
            var count = _members.CountByClub(club.Id);
            Console.WriteLine($"Club: {club.Name} | Members: {count}");
        }
    }
}