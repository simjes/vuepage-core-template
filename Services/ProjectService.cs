using Microsoft.EntityFrameworkCore;
using SimFolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimFolio.Services
{
	public interface IProjectService
	{
		ICollection<Project> GetAllProjects();
		Project GetProject(int id);
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

		public Project GetProject(int id)
		{
			return _context.Projects.Include(p => p.Tags).Include(p => p.UrlLocation).SingleOrDefault(p => p.Id == id);
		}
	}
}
