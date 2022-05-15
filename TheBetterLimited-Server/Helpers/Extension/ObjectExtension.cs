namespace TheBetterLimited_Server.Helpers.Extension;
using Newtonsoft.Json;


public static class ObjectExtension
{
    public static T TryCopy<T>(this object source)
    {
        T newObj = (T)Activator.CreateInstance(typeof(T));

        foreach (var item in source.GetType().GetProperties())
        {
            item.SetValue
            (
                newObj,
                source.GetType().GetProperties().Where(x => x.Name == item.Name).FirstOrDefault().GetValue(source)
            );
        }
        return newObj;
    }
    
    public static T? CopyAs<T>(this object source)
    {
        string tmp = JsonConvert.SerializeObject(source , new JsonSerializerSettings()
        {
            ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        });

        return JsonConvert.DeserializeObject<T>(tmp) ;
    }

    public static void CopyValueTo<T>(this object source, ref T newObj)
    {
        foreach (var item in source.GetType().GetProperties())
        {
            item.SetValue
            (
                newObj,
                source.GetType().GetProperties().Where(x => x.Name == item.Name).FirstOrDefault().GetValue(source)
            );
        }
    }

    public static String Debug(this object o)
    {

        StringBuilder str = new StringBuilder();
#if DEBUG
        foreach (var item in o.GetType().GetProperties())
        {
            
            str.Append($"{item.Name} = {item.GetValue(o)}\n");
        }
#endif
        return str.ToString();

    }

    
}