using Microsoft.EntityFrameworkCore;

namespace SimFolio.Models
{
	public class ProjectDbContext : DbContext
	{
		public ProjectDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Project> Projects { get; set; }
	}
}
