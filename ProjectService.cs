using Microsoft.EntityFrameworkCore;
using SimFolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimFolio
{
	public interface IProjectService
	{
		ICollection<Project> GetAllProjects();
	}

	public class ProjectService : IProjectService
	{
		private readonly ProjectDbContext _context;
		public ProjectService(ProjectDbContext context)
		{
			_context = context;
		}

		public ICollection<Project> GetAllProjects()
		{
			return _context.Projects.Include(p => p.Tags).Include(p => p.UrlLocation).ToList();
		}
	}
}
