namespace TheBetterLimited_Server.Helpers.Extension
{
    public static class DbContextExtension
    {
        
        /**
        * <summary>Load all foreign key data from database</summary>
        * <remarks>ICollection type is not able to load</remarks>
        */    
        public void LoadRelatedEntity(this DbContext db , object entity)
        {
            if (entity is null)
                return;
            // load all foreign key data from database
            foreach (var item in entity.GetType().GetProperties())
            {

                // if (item.PropertyType == typeof(List<>))
                // {
                //     db.Entry(entity).Collection(item.Name).Load();
                // }
                if (item.PropertyType.IsClass && item.PropertyType != typeof(string))
                {
                    ConsoleLogger.Debug($"{item.Name} is a class");
                    db.Entry(entity).Reference(item.Name).Load();
                    LoadRelatedEntity(db , item.GetValue(entity));
                }
            }     
            
        }

    }
}