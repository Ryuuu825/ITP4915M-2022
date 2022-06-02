namespace TheBetterLimited_Server.Helpers.File;
using TheBetterLimited_Server.Helpers.LogHelper;

internal class TempFileNode : TempFile
{
    internal TempFileNode next;
    internal TempFileNode prev;
}

public class TempFileManager
{
    // This is a linked list to store all TempFile
    private static TempFileNode head;
    private static TempFileNode tail;

    private TempFileManager()
    {
    }

    public static TempFile Create()
    {
        if (head == null)
        {
            head = tail = new TempFileNode();
        }
        else 
        {
            tail.next = new TempFileNode();
            tail.next.prev = tail;
            tail = tail.next;
        }
        return tail;
    }

    public static void CloseAllTempFile()
    {
        var curr = head;
        while (curr != null)
        {
            curr.prev = null;
            curr.Close();
            curr = curr.next;
        }
    }

    public static void CloseTempFile(string filename)
    {
        if (head == null)
        {
            return;
        }
        
        
        if (head.GetFileName().Equals(filename))
        {
            head.Close();
            head = head.next;
            return;
        
        }
        else if (tail.GetFileName().Equals(filename))
        {
            tail.Close();
            tail = tail.prev;
            tail.next = null;
            return;
        }


        var curr = head;
        while (curr.next != null)
        {
            if (curr.next.GetFileName().Equals(filename))
            {
                curr.next.Close();
                curr.next = curr.next.next;
                return;
            }
            curr = curr.next;
        }
    }

    public static void Print()
    {
        // print all file path in the linked list
        var curr = head;
        while (curr != null)
        {
            ConsoleLogger.Debug(curr.GetFilePath());
            curr = curr.next;
        }
    }

    // check if the content of the file is the same as the given string
    public static string GetFilePath(string str)
    {
        var curr = head;
        while (curr != null)
        {
            if (curr.ReadAllText().Equals(str))
            {
                ConsoleLogger.Debug("Found file : " + curr.GetFilePath());
                return curr.GetFileName();
            }
            curr = curr.next;
        }
        return String.Empty;
    }

    // get the content from specify file name
    public static string GetFileContent(string fileName)
    {
        var curr = head;
        while (curr != null)
        {
            if (curr.GetFileName() == fileName)
            {
                return System.IO.File.ReadAllText(curr.GetFilePath());
            }
            curr = curr.next;
        }
        throw new FileNotFoundException();
    }
}