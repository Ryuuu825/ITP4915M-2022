using System;
using Microsoft.EntityFrameworkCore;
using TheBetterLimited_Server.AppLogic.Dto;

namespace TheBetterLimited_Server.AppLogic
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Acc> Accs { get; set; }

	}
}

