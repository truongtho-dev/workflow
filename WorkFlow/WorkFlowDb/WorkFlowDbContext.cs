using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkFlow.Models;


namespace WorkFlow.WorkFlowDb
{
	public class WorkFlowDbContext : DbContext, IWorkFlowDbContext
	{
		public WorkFlowDbContext(DbContextOptions<WorkFlowDbContext> options) : base(options)
		{

		}
		public DbSet<Models.Task> Tasks { get; set; }
		public DbSet<Employee> Employees { get; set; }
#pragma warning disable CS0114 // Member hides inherited member; missing override keyword
		public async Task<int> SaveChanges()
#pragma warning restore CS0114 // Member hides inherited member; missing override keyword
		{
			return await base.SaveChangesAsync();
		}
	}
}
