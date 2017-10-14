using Microsoft.AspNetCore.Mvc;
using SimFolio.Services;

namespace SimFolio.Controllers
{
	[Produces("application/json")]
	[Route("api/Project")]
	public class ProjectController : Controller
	{
		private readonly IProjectService _projectService;

		public ProjectController(IProjectService projectService)
		{
			_projectService = projectService;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var projects = _projectService.GetAllProjects();

			return Ok(projects);
		}

		[HttpGet("{id}", Name = "Get")]
		public IActionResult Get(int id)
		{
			var project = _projectService.GetProject(id);

			return Ok(project);
		}
	}
}
