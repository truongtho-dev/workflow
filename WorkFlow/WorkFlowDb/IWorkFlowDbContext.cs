using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WorkFlow.Models;

namespace WorkFlow.WorkFlowDb
{
	public interface IWorkFlowDbContext
	{
		DbSet<Employee> Employees { get; set; }
		DbSet<Models.Task> Tasks { get; set; }

		Task<int> SaveChanges();
	}
}