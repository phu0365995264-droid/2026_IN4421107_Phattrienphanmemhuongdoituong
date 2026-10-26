using EduHub.Ch02.Domain;
namespace EduHub.Ch02.Repositories;

public interface IMemberRepository
{
    void Add(Member member);
    int CountByClub(Guid clubId);
    IReadOnlyList<Member> GetByClub(Guid clubId);
}


public class InMemoryMemberRepository : IMemberRepository
{
    private readonly List<Member> _members = new();

    public void Add(Member member) => _members.Add(member);

    public int CountByClub(Guid clubId) => _members.Count(m => m.ClubId == clubId);

    public IReadOnlyList<Member> GetByClub(Guid clubId) =>
        _members.Where(m => m.ClubId == clubId).ToList();
}