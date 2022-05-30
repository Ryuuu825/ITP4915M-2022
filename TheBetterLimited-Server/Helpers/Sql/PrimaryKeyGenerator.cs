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

            var last = Table.ToList().Last();

            var Id = last?.GetType()
                                ?.GetProperties()
                                ?.Where(x => x.Name.ToLower() == "id")
                                ?.FirstOrDefault()
                                ?.GetValue(last)
                                ?.ToString();

            if (Prefix == "" )
            {

            }
            return "";
        }
        
    }
}