using System;
using TheBetterLimited_Server.AppLogic.Dto;

namespace TheBetterLimited_Server.AppLogic.Controller
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

