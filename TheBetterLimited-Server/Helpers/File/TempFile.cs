namespace TheBetterLimited_Server.Helpers.File;

public class TempFile : IDisposable
{
    protected static readonly string FolderPath = AppDomain.CurrentDomain.BaseDirectory + "/var/tmp";

    protected string FilePath;


    public TempFile()
    {
        FilePath = Path.Combine(FolderPath, Path.GetRandomFileName());
    }

    public bool IsClose { get; private set; }

    public void Dispose()
    {
        Close();
    }

    public void Close()
    {
        if (!IsClose)
        {
            System.IO.File.Delete(FilePath);
            IsClose = true;
        }
    }

    public string ReadAllText()
    {
        return System.IO.File.ReadAllText(FilePath);
    }

    public void WriteAllText(string str)
    {
        System.IO.File.AppendAllText(FilePath, str);
    }

    public string GetFilePath()
    {
        return FilePath;
    }
}