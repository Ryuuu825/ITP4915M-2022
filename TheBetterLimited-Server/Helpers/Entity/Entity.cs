using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using TheBetterLimited_Server.Helpers.Sql;

namespace TheBetterLimited_Server.Helpers.Entity;

public static class ObjectExtension
{
    public static T Copy<T>(this object source)
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


    public static bool TryCopy<T>(this object source , out T target)
    {
        target = default;

        target = Copy<T>(source);

        return target is null;
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