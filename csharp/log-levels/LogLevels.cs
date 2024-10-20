using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] messageSplit = logLine.Split(':');
        string message = messageSplit[1].Trim();
        return message;
    }

    public static string LogLevel(string logLine)
    {
        string[] codeSplit = logLine.Split(':');
        string code = codeSplit[0].Trim();
        code = code.Replace("[", "").Replace("]", "");
        return code.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string code = LogLevel(logLine);
        return $"{message} ({code})";
    }
}