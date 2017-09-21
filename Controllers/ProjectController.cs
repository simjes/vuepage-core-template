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

		// GET: api/Project
		[HttpGet]
		public IActionResult Get()
		{
			var projects = _projectService.GetAllProjects();

			return Ok(projects);
		}

		// GET: api/Project/5
		[HttpGet("{id}", Name = "Get")]
		public IActionResult Get(int id)
		{
			var project = _projectService.GetProject(id);

			return Ok(project);
		}

		// POST: api/Project
		[HttpPost]
		public void Post([FromBody]string value)
		{
		}

		// PUT: api/Project/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
