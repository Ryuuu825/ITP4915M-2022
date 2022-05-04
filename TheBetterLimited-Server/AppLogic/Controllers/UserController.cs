using System;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    using System.ComponentModel;
    using System.Threading.Tasks;
    using TheBetterLimited_Server.AppLogic.Exceptions;
	using TheBetterLimited_Server.Data;

	public class UserController
	{
		private readonly DataContext _db;

		public UserController(DataContext dataContext)
		{
			_db = dataContext;
		}

		public async Task CreateUserAsync( Data.Entity.Account acc)
		{
            //	var entity = _dataContext.Accs.FirstOrDefault(o => o.Id == acc.Id);
            //	if (entity is not null) throw new DuplicateEntryException("Entity exist");
            //	_dataContext.Accs.Add(acc);
            //	_dataContext.SaveChanges();

            //var entity = _db.accounts.FirstOrDefault(o => o.Id == acc.Id);
            //if (entity is null)
            //	return;
            //if (entity is not null) throw new DuplicateEntryException("Entity exist");exist
            Data.Entity.Account newObj = new Data.Entity.Account
            {
                EmailAddress = acc.EmailAddress,
                Password = acc.Password,
                Id = acc.Id,
                UserName = acc.UserName,
                Status = acc.Status,
                Remarks = acc.Remarks,
                LoginFailedCount = acc.LoginFailedCount,
                LoginFailedAt = acc.LoginFailedAt,
                LastLogin = acc.LastLogin,
                unlockDate = acc.unlockDate

            };
            bool res = Helpers.Sql.EntityValidator.Validate<Data.Entity.Account>(newObj);
            Console.WriteLine(res);
            //await _db.AddAsync<Data.Entity.Account>(newObj);
            //await _db.SaveChangesAsync();
        }

	}

}