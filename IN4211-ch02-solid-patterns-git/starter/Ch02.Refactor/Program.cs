using EduHub.Ch02.Logging;
using EduHub.Ch02.Notifications;
using EduHub.Ch02.Repositories;
using EduHub.Ch02.Services;

// ═══════════════════════════════════════════════════════════════
//  EduHub Ch02 — Refactoring với SOLID và Design Patterns
//  ClubManager.cs chứa code vi phạm SOLID (đọc các TODO ở đầu file đó).
// ═══════════════════════════════════════════════════════════════

// Demo code cũ (vi phạm SOLID) — chạy được nhưng thiết kế rất xấu:
IAppLogger logger = new FileLogger();
var clubRepo = new InMemoryClubRepository();
var memberRepo = new InMemoryMemberRepository();

var clubService = new ClubService(clubRepo, memberRepo, logger, new EmailNotificationService());
var eventService = new EventService(clubRepo, logger);
var reportService = new ReportService(clubRepo, memberRepo);

var club = clubService.CreateClub("Tech Club", "Câu lạc bộ công nghệ", "president@gmail.com");
clubService.AddMember(club.Id, "Nguyễn Văn A", "a@student.dthu.edu.vn");
eventService.CreateEvent(club.Id, "Workshop SOLID", new DateTime(2026, 11, 20));
reportService.Generate();