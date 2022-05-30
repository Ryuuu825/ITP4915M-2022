namespace TheBetterLimited_Server.Helpers.Extension
{
    public static class IntExtension
    {
        public static int ToInt(this string target)
        {
            return int.Parse(target);
        }
    }
}