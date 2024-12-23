using System;
using System.IO;

public static class Logger
{
    private static string logFile = "error_log.txt";

    public static void LogException(Exception ex)
    {
        try
        {
            File.AppendAllText(logFile, $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n");
        }
        catch (Exception)
        {
            
        }
    }
}
