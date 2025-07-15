public class LogManager : ILogger
{
    public ILogger _Logger;
    public LogManager(ILogger logger)
    {
        _Logger = logger;

    }
    public void WriteLog()
    {
        _Logger.WriteLog();
    }
}