using System;

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logging to file: " + message);
    }
}

class TimestampLogger : ILogger
{
    private ILogger logger;

    public TimestampLogger(ILogger logger)
    {
        this.logger = logger;
    }

    public void Log(string message)
    {
        string timestampedMessage = DateTime.Now + " - " + message;
        logger.Log(timestampedMessage);
    }
}

class program
{
    public static void Main(string[] args)
    {
        ILogger fileLogger = new FileLogger();
        fileLogger.Log("This is a simple log message.");

        Console.WriteLine("Hiii");

        ILogger timestampLogger = new TimestampLogger(fileLogger);
        timestampLogger.Log("This is a log message with a timestamp.");
    }
}
