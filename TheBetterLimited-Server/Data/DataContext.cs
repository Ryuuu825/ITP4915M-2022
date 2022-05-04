using System;
using Microsoft.EntityFrameworkCore;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Account> accounts { get;  }
    }
}

