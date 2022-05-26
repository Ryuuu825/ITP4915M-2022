using TheBetterLimited_Server.AppLogic.Models;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Helpers.Entity
{
    public static class EntityUpdater
    {
        public static void Update<T>(ref T o , List<UpdateObjectModel> updateContent , string lang = "en") where T : class
        {
            if (updateContent is null)
            {
                throw new BadArgException("Invalid update content.");
            }
            foreach (var item in updateContent)
            {
                try
                {
                    var target = o.GetType().GetProperties().Single(x => x.Name == item.Attribute);
                    // if the target is a translatable attribute
                    if (System.Attribute.IsDefined(target, typeof(AppLogic.Attribute.TranslatableAttribute)))
                    {
                        Helpers.Localizer.UpdateWord<T>(
                            lang , 
                            target.GetValue(o).ToString() ,
                            item.Value.ToString()
                        );
                    }
                    // target is a enum type
                    else if (target.PropertyType.IsEnum)
                    {
                        var evalue = Enum.Parse(target.PropertyType, item.Value.ToString());
                        target.SetValue(o, evalue);
                    }
                    // the target is nullable type
                    else if (target.PropertyType.IsGenericType && target.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        var evalue = Convert.ChangeType(item.Value, target.PropertyType.GetGenericArguments()[0]);
                        target.SetValue(o, evalue);
                    }   
                    else
                    {   
                        // cast the value to the type of that property
                        var value = Convert.ChangeType(item.Value, target.PropertyType);
                        target.SetValue(o, value);
                    }
                }
                catch(Exception e)
                {
                    ConsoleLogger.Debug(e.Message);
                    throw new BadArgException($"Attribute is invalid.");
                }
            }
        }

        public static T Update<T>(T o, List<UpdateObjectModel> updateContent , string lang = "en") where T : class
        {
            if (updateContent is null)
            {
                throw new BadArgException("Invalid update content.");
            }
            var newObj = o.CopyAs<T>();
            foreach (var item in updateContent)
            {
                try
                {
                    var target = o.GetType().GetProperties().Single(x => x.Name == item.Attribute);
                    // if the target is a translatable attribute
                    if (System.Attribute.IsDefined(target, typeof(AppLogic.Attribute.TranslatableAttribute)))
                    {
                        Helpers.Localizer.UpdateWord<T>(
                            lang , 
                            target.GetValue(newObj).ToString() ,
                            item.Value.ToString()
                        );
                    }
                    // target is a enum type
                    else if (target.PropertyType.IsEnum)
                    {
                        var evalue = Enum.Parse(target.PropertyType, item.Value.ToString());
                        target.SetValue(newObj, evalue);
                    }
                    // the target is nullable type
                    else if (target.PropertyType.IsGenericType && target.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        var evalue = Convert.ChangeType(item.Value, target.PropertyType.GetGenericArguments()[0]);
                        target.SetValue(o, evalue);
                    }   
                    else
                    {   
                        // cast the value to the type of that property
                        var value = Convert.ChangeType(item.Value, target.PropertyType);
                        target.SetValue(newObj, value);
                    }
                }
                catch(Exception e)
                {
                    ConsoleLogger.Debug(e.Message);
                    throw new BadArgException($"Attribute is invalid.");
                }

            }
            return newObj;

        }

        public unsafe static void Update<T>(T * o, List<UpdateObjectModel> updateContent , string lang = "en") where T : unmanaged
        {
            if (updateContent is null)
            {
                throw new BadArgException("Invalid update content.");
            }
            
            // update the item in list
            foreach (var item in updateContent)
            {
                try
                {
                    var target = o->GetType().GetProperties().Single(x => x.Name == item.Attribute);
                    // if the target is a translatable attribute
                    if (System.Attribute.IsDefined(target, typeof(AppLogic.Attribute.TranslatableAttribute)))
                    {
                        Helpers.Localizer.UpdateWord<T>(
                            lang , 
                            target.GetValue(*o).ToString() ,
                            item.Value.ToString()
                        );
                    }
                    // target is a enum type
                    else if (target.PropertyType.IsEnum)
                    {
                        var evalue = Enum.Parse(target.PropertyType, item.Value.ToString());
                        target.SetValue(*o, evalue);
                    }
                    // the target is nullable type
                    else if (target.PropertyType.IsGenericType && target.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    {
                        var evalue = Convert.ChangeType(item.Value, target.PropertyType.GetGenericArguments()[0]);
                        target.SetValue(*o, evalue);
                    }   
                    else
                    {   
                        // cast the value to the type of that property
                        var value = Convert.ChangeType(item.Value, target.PropertyType);
                        target.SetValue(*o, value);
                    }
                }
                catch(Exception e)
                {
                    ConsoleLogger.Debug(e.Message);
                    throw new BadArgException($"Attribute is invalid.");
                }
            }


        }
    }
}