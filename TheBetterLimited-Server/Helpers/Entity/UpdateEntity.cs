using TheBetterLimited_Server.AppLogic.Models;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Helpers.Entity
{
    public static class EntityUpdater
    {
         public static void Update<T>(ref T o , List<UpdateObjectModel> updateContent)
        {
            foreach (var item in updateContent)
            {
                try
                {
                    o.GetType().GetProperties().Single(x => x.Name == item.Attribute).SetValue(o, item.Value);
                    
                }catch(System.InvalidOperationException e)
                {
                    throw new BadArgException($"Attribute {item.Attribute} is invalid.");
                }
            }
        }
    }
}