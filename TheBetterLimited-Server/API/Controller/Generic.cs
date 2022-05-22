
using Microsoft.AspNetCore.Authorization;
using TheBetterLimited_Server.AppLogic.Controllers;
using TheBetterLimited_Server.Data;

namespace TheBetterLimited_Server.API.Controller
{
    public class Warehouse : APIControllerBase<Data.Entity.Warehouse>
    {
        public Warehouse(Data.DataContext db) : base(db) {}
    }

    public class Location : APIControllerBase<Data.Entity.Location>
    {
        public Location(Data.DataContext db) : base(db) {}
    }

    
}