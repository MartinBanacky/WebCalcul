using System;
using Microsoft.EntityFrameworkCore;

namespace WebCalcul.Data
{
	public class WebCalculDbContext : DbContext
	{

		public WebCalculDbContext(DbContextOptions<WebCalculDbContext> options) : base(options)
		{

		}

		public DbSet<CalculState> CalculStates { get; set; }

		
	}
}
