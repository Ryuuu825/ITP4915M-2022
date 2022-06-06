namespace TheBetterLimited_Server.Helpers.Extension;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Reflection;


public static class ObjectExtension
{
    public static T TryCopy<T>(this object source)
    {
        T newObj = (T)Activator.CreateInstance(typeof(T));

        foreach (var item in newObj.GetType().GetProperties())
        {
            try 
            {
                item.SetValue(newObj, source.GetType().GetProperty(item.Name).GetValue(source));
            }
            catch (Exception)
            {
                continue;
            }
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


    /**
     * <summary>
     * A method map the object to DTO (implemented as a hash table).
     * Check if the property is virtual. If so, do not map it, else app to map
     * </summary>
     */
    public static Hashtable MapToDto(this object source)
    {
        Hashtable map = new Hashtable();

        foreach (var item in source.GetType().GetProperties())
        {
            if (item.GetMethod.IsVirtual || item.PropertyType.IsInterface)
            {
                continue;
            }
            map.Add(item.Name, item.GetValue(source));
        }
        return map;
    }

    /**
     * <summary>
     * Same as 
     * <see cref="MapToDto(object)"/>
     * </summary>
     * 
     */
    public static List<Hashtable> MapToDto<T>(this List<T> source)
    {
        List<Hashtable> map = new List<Hashtable>();
        foreach(var item in source)
        {
            map.Add(item.MapToDto());
        }
        return map;
    }

    /**
     * <summary>
     * A method create a dto type at runtime from the source object.
     */

     // test if it works first
    public static Type ToDto(this Type source)
    {
        Type ivType = null;
        AssemblyName aName = new AssemblyName("Dto");
        AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly( aName, AssemblyBuilderAccess.Run);
        ModuleBuilder mb = ab.DefineDynamicModule("DynamicAssemblyExample");

        TypeBuilder tb = mb.DefineType("Dto"  
                              , TypeAttributes.Public |  
                                TypeAttributes.Class |  
                                TypeAttributes.AutoClass |  
                                TypeAttributes.AnsiClass |  
                                TypeAttributes.BeforeFieldInit |  
                                TypeAttributes.AutoLayout  
                              , null); 

        // access all instance properties
        dynamic instance = Activator.CreateInstance(source);
        foreach (var item in instance.GetType().GetProperties())
        {
            if (item.GetMethod.IsVirtual || item.PropertyType.IsInterface || System.Attribute.IsDefined(item , typeof(AppLogic.Attribute.NotMapToDtoAttribute)))
            {
                continue;
            }
            PropertyBuilder pb = tb.DefineProperty(
                item.Name,
                PropertyAttributes.None,
                item.PropertyType,
                null
            );
            FieldBuilder fb = tb.DefineField(
                "_" + item.Name, 
                item.PropertyType, 
                FieldAttributes.Public
            );

            MethodBuilder mbGet = tb.DefineMethod(
                "get_" + item.Name , 
                MethodAttributes.Public | MethodAttributes.HideBySig, 
                item.PropertyType , 
                Type.EmptyTypes
            );
            ILGenerator genGet = mbGet.GetILGenerator();
            genGet.Emit(OpCodes.Ldarg_0);
            genGet.Emit(OpCodes.Ldfld, fb);
            genGet.Emit(OpCodes.Ret);

            MethodBuilder mbSet = tb.DefineMethod(
                "set_Id", 
                MethodAttributes.Public | MethodAttributes.HideBySig, 
                null, 
                new Type[] { item.PropertyType }
            );
            ILGenerator genSet = mbSet.GetILGenerator();
            genSet.Emit(OpCodes.Ldarg_0);
            genSet.Emit(OpCodes.Ldarg_1);
            genSet.Emit(OpCodes.Stfld, fb);
            genSet.Emit(OpCodes.Ret);

            pb.SetGetMethod(mbGet);
            pb.SetSetMethod(mbSet);
        }
       
        Type objType = typeof(object);
        ivType = tb.CreateType();

        return ivType;
    }

    public static object CopyAsDto(this object source)
    {
        Type t = source.GetType().ToDto();
        object newObj = Activator.CreateInstance(t);
        foreach (var item in newObj.GetType().GetProperties())
        {
            if (item.GetMethod.IsVirtual || item.PropertyType.IsInterface)
            {
                continue;
            }
            t.GetProperty(item.Name).SetValue(newObj, source.GetType().GetProperty(item.Name).GetValue(source));
        }
        return newObj;
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