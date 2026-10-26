namespace EduHub.Ch02.Logging;
public interface IAppLogger { void Log(string message); }

// Logging/FileLogger.cs
public class FileLogger : IAppLogger
{
    public void Log(string message) =>
        File.AppendAllText("club-log.txt", $"[{DateTime.Now}] {message}\n");
}