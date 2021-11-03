using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorkFlow.Models
{
	public class Task
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public Status Status { get; set; }

		public DateTime StartedTime { get; set; }
		public DateTime ExpiredTime { get; set; }
		public Employee AssignedTo { get; set; }


	}
	public enum Status
	{
		Open,
		Close,
		Pending,
		Review,
		InProgress,
	}
}
