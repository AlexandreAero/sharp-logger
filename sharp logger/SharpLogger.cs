/****************************************************************************\
 * Pilot Alex, 2022-2023, All rights reserved. Copyright (c) 2023.
 * Made by A.G. under the username of Pilot Alex.
\****************************************************************************/

using System;
using System.IO;

enum LogLevel
{
    INFO,
    WARNING,
    ERROR,
    FATAL
}

class SharpLogger : IDisposable
{
    private StreamWriter writer;

    public SharpLogger(string savePath, bool append)
    {
        this.writer = new StreamWriter(savePath, append);
    }

    public void Log(string message, LogLevel level, params object[] args)
    {
        string formattedMessage = string.Format(message, args);
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{level}] {formattedMessage}";

        writer.WriteLine(logEntry);
        writer.Flush();
    }

    public void Close()
    {
        writer.Close();
    }

    public void Clear()
    {
        writer.Close();
        File.WriteAllText(writer.BaseStream.Position.ToString(), string.Empty);
        writer = new StreamWriter(writer.BaseStream);
    }

    public void Dispose()
    {
        writer.Dispose();
    }
}
