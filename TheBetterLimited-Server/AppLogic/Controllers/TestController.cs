using System;
using TheBetterLimited_Server.AppLogic.Dto;
using TheBetterLimited_Server.AppLogic.Data;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
	public class TestController
	{
        private readonly DataContext _dataContext;

        public TestController(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public List<Acc> GetSth()
        {
			return _dataContext.Accs.ToList();
        }

		public void CreateSth(Acc acc)
        {
			var entity = _dataContext.Accs.FirstOrDefault(o => o.Id == acc.Id);
			if (entity is not null) throw new DuplicateEntryException("Entity exist");
			_dataContext.Accs.Add(acc);
			_dataContext.SaveChanges();


			// return await _dataContext.Accs.ToListAsync();
        }


	}


}

