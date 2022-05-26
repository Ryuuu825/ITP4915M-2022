namespace TheBetterLimited_Server.Helpers.File
{
    public class CSVFactory
    {
        public static string Create<T>(List<T> entries)
        {
            var csv = new StringBuilder();
            var properties = typeof(T).GetProperties();
            for (int i = 0 ; i < properties.Length ; i++)
            {
                csv.Append(properties[i].Name);
                if (i != properties.Length - 1)
                {
                    csv.Append(",");
                }
            }
            csv.AppendLine();
            for (int i = 0 ; i < entries.Count ; i++)
            {
                for (int j = 0 ; j < properties.Length ; j++)
                {
                    csv.Append(properties[j].GetValue(entries[i]));
                    if (j != properties.Length - 1)
                    {
                        csv.Append(",");
                    }
                }
                csv.AppendLine();
            }
            return csv.ToString();
        }
    }
}