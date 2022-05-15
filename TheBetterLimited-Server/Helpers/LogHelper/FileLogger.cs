using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Helpers.LogHelper;

public class FileLogger
{
    private static readonly string _LogPath = AppDomain.CurrentDomain.BaseDirectory + "/var/log/";

    private static StreamWriter _logWriter = new StreamWriter(new FileStream(_LogPath + DateTime.Today.ToString("d").Replace("/","") + ".log", FileMode.Append, FileAccess.Write));
    private static StreamWriter _accessWriter = new StreamWriter(new FileStream(_LogPath + "Access.log", FileMode.Append, FileAccess.Write));
    private static StreamWriter _invalidAccessWriter = new StreamWriter(new FileStream(_LogPath + "InvalidAccess.log", FileMode.Append, FileAccess.Write));

    public static void Log(LogLevel level , string message)
    {
        string str = $"[{DateTime.Now.ToShortTimeString()}][{level.ToString()}]: {message}";
        _logWriter.Write(str);
        _logWriter.Flush();
    }

    public static void AcceccLog( in Account user)
    {
        string msg = $"[{DateTime.Now.ToString()}]:\t{user.UserName} ({user._StaffId})\r\n";
         _accessWriter.Write(msg);
         _accessWriter.Flush();
    }

    public static void InvalidAcceccLog(string socket, string url, string user  )
    {
        string msg = $"Time:\t\t[{DateTime.Now.ToString()}]\r\nFrom:\t\t[{socket}]\r\nEndPoint:\t[{url}]\r\nUser:\t\t[{user}]\r\n-----\r\n\r\n";
        _invalidAccessWriter.WriteLine(msg);
        _invalidAccessWriter.Flush();
    }
}