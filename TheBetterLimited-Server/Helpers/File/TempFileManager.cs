namespace TheBetterLimited_Server.Helpers.File;

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
        else if (head == tail)
        {
            head.next = tail = new TempFileNode();
        }
        else
        {
            tail.next = new TempFileNode();
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
}