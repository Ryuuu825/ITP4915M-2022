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
                    else if (target.PropertyType.IsEnum)
                    {
                        var evalue = Enum.Parse(target.PropertyType, item.Value.ToString());
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
    }
}