using System;
using TheBetterLimited_Server.AppLogic.Dto;
using TheBetterLimited_Server.AppLogic.Data;

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
	}
}

