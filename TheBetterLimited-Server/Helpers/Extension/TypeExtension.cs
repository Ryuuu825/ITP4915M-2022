namespace TheBetterLimited_Server.Helpers.Extension
{
    public static class TypeExtension
    {
        public static List<String> GetPropertiesToString(this Type o)
        {
            List<string> list = new List<string>();

            var newObj =  Activator.CreateInstance(o);

            foreach (var item in newObj.GetType().GetProperties())
            {
                list.Add(item.Name);
            }

            return list;

        }
    }
}