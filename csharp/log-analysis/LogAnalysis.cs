using System;

public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string splitString)
    {
        string[] split = str.Split(splitString);
        return split[1];
    }

    public static string SubstringBetween(this string str, string split_start, string split_end)
    {
        string[] split = str.Split(split_start);
        string result = split[1].Split(split_end)[0];
        return result;
    }

    public static string Message(this string str)
    {
        string message = str.SubstringAfter(": ");
        return message;
    }

    public static string LogLevel(this string str)
    {
        string logLevel = str.SubstringBetween("[", "]");
        return logLevel;
    }
}