using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Models;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class SessionSetttingController
    {
        private readonly Data.Repositories.Repository<SessionSetting> repository;
        private readonly Data.Repositories.Repository<Session> _SessionTable;
        private readonly Data.DataContext db;
        public SessionSetttingController(DataContext db)
        {
            repository = new Data.Repositories.Repository<SessionSetting>(db);
            _SessionTable = new Data.Repositories.Repository<Session>(db);
            this.db = db;
        }

        public List<SessionSetting> GetAll(string Language)
        {
            return repository.GetAll();
        }
        public void UpdateSessionSetting(string id ,  List<UpdateObjectModel> content)
        {
            var entry = repository.GetById(id);
            Helpers.Entity.EntityUpdater.Update(ref entry , content);
            ConsoleLogger.Debug(entry.Debug());
            repository.Update(entry);

  
            var Dsession = new Session 
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<Session>(db),
                _departmentId = "300", // hard coded, this is inventory department
                StartTime = entry.StartTime,
                EndTime = entry.EndTime,
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(32)), // hard coded, this is the next month
                NumOfAppointments = (byte) entry.NumOfAppointments,
            };
            _SessionTable.Add(Dsession);

            var Isession = new Session 
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<Session>(db),
                _departmentId = "700", // hard coded, this is inventory department
                StartTime = entry.StartTime,
                EndTime = entry.EndTime,
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(32)), // hard coded, this is the next month
                NumOfAppointments = (byte) entry.NumOfAppointments,
            };
            _SessionTable.Add(Isession);

        }


    }
}