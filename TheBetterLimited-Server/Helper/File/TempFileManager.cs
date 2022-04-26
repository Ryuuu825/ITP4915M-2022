using System.Runtime.CompilerServices;

namespace TheBetterLimited_Server.Helper.File
{
    public class TempFileManager
    {

        // This is a linked list to store all TempFile
        private static TempFileNode head;
        private static TempFileNode tail;
        private TempFileManager()
        { }

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

            return (TempFile)tail;
        }

        public static void CloseAllTempFile()
        {
            TempFileNode curr = head;
            while (curr != null)
            {
                curr.prev = null;
                curr.Close();
                curr = curr.next;
            }
            
        }
    }
}
