using TheBetterLimited_Server.Data;

namespace TheBetterLimited_Server.Helpers.Sql
{
    public static class PrimaryKeyGenerator
    {
        public static string Get<T>(DataContext db , string Prefix = "" , string lang = "en" , bool NumberOnly = true)
            where T : class
        {
            var Table = db.Set<T>();
            StringBuilder sb = new StringBuilder();

            var list = Table.ToList();

            string Id;
            if (list.Count() == 0)
            {
                Id = Prefix + "00000";
            }
            else 
            {
                var last = Table.ToList()?.Last();

                Id = last?.GetType()
                    ?.GetProperties()
                    ?.Where(x => x.Name.ToLower() == "id")
                    ?.FirstOrDefault()
                    ?.GetValue(last)
                    ?.ToString();
            }

            string _prefix = Prefix;
            if (Prefix == "" )
            {
                _prefix = Id?.Substring(0 , Id.IndexOfAny("0123456789".ToCharArray()));
            }

            // get the prefix from the last entry's id
            sb.Append(_prefix);

            var sequence = Id?.Substring( Id.IndexOfAny("0123456789".ToCharArray()) , Id.Length - Id.IndexOfAny("0123456789".ToCharArray()));
            int NewIdValue = sequence.ToInt() + 1;
            // append the "0" to the front of the id, so that the length will some as the length of the id
            sb.Append(NewIdValue.ToString().PadLeft(Id.Length - _prefix.Length, '0'));
            ConsoleLogger.Debug(sb.ToString());
            return sb.ToString();
        }
        
    }
}