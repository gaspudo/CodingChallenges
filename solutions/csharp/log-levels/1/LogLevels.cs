static class LogLine
{
    public static string Message(string logLine)
    {
        int index = logLine.IndexOf(":");
        return logLine.Substring(index + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int comeco = logLine.IndexOf("[");
        int final = logLine.IndexOf("]");
        return logLine.Substring(comeco+1, final - 1).ToLower().Trim();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string logLevel = LogLevel(logLine);
        return $"{message} ({logLevel})";
    }
}
