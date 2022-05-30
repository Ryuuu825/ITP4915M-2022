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
                if  (    
                        System.Attribute.IsDefined(properties[i] , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        properties[i].PropertyType is ICollection || 
                        properties[i].GetAccessors()[0].IsVirtual
                    )
                    continue;
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
                    if  (    
                        System.Attribute.IsDefined(properties[j] , typeof(AppLogic.Attribute.NotMapToDtoAttribute)) ||
                        properties[j].PropertyType is ICollection || 
                        properties[j].GetAccessors()[0].IsVirtual
                    )
                    continue;

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