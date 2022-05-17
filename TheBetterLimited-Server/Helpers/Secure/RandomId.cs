namespace TheBetterLimited_Server.Helpers.Secure
{
    public static class RandomId
    {

        public static readonly string NUMBER = "0123456789";
        public static readonly string LETTER = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string GetID(int length)
        {
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(NUMBER , length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
            );
            return result;
        }

        public static string GetStr(int length)
        {
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(LETTER + NUMBER , length)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
            );
            return result;
        }
    }
}