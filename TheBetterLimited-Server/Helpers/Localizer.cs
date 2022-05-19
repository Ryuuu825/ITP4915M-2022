using CsvHelper;

namespace TheBetterLimited_Server.Helpers
{
    public class Localizer
    {
        private static readonly string FilePath = "./resources/localization/{0}.{1}.csv";

        public static T TryLocalize<T>(string language , T target)
        {
            try
            {
                var entity = target.CopyAs<T>();

                using (var reader = new StreamReader(string.Format(FilePath , typeof(T).Name , language)))
                using (var csv = new CsvReader(reader , System.Globalization.CultureInfo.CurrentCulture))
                {
                    var records = csv.GetRecords<Foo>();
                    
                    foreach (var item in entity.GetType().GetProperties())
                    {
                        // check if the property value startwith @$
                        if (item.GetValue(entity).ToString().StartsWith("@$"))
                        {
                            var key = item.GetValue(entity).ToString().Substring(2);
                            var value = records.FirstOrDefault(x => x.Key == key);
                            if (value is null)
                            {
                                throw new BadArgException("The key is not exist in localization file.");
                            }
                            item.SetValue(entity, value.Content);
                        }
                    }
                }

                return entity;
            }catch(System.IO.FileNotFoundException e)
            {
                ConsoleLogger.Debug(e.Message);
                throw new BadArgException("The language type not support.");
            }
            
        }
    }

    internal class Foo
    {
        public string Key { get; set; }
        public string Content { get; set; }
    }
}