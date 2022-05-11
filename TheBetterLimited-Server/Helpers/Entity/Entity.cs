using System.Reflection;
using Newtonsoft.Json;

namespace TheBetterLimited_Server.Helpers.Entity;

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
    
    public static T CopyAs<T>(this object source)
    {
        string tmp = JsonConvert.SerializeObject(source , new JsonSerializerSettings()
        {
            ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
        });

        var newObj = JsonConvert.DeserializeObject<T>(tmp);

        return newObj;
    }


    public static bool TryCopy<T>(this object source , out T target)
    {
        target = default;

        target = CopyAs<T>(source);

        return target.Equals(source);
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