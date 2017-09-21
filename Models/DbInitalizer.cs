using System;
using System.Collections.Generic;
using System.Linq;

namespace SimFolio.Models
{
	public static class DbInitalizer
	{
		public static void Initalizer(ProjectDbContext context)
		{
			context.Database.EnsureCreated();

			if (context.Projects.Any()) return;

			var projects = new List<Project>
			{
				new Project {Title = "React Material", Description = "Portfolio page in React. Using Mui CSS for material design.", ImageUrl = "http://i.imgur.com/NHOwOda.png", ThumbnailUrl = "http://i.imgur.com/NHOwOdal.png", StartDateTime = DateTime.Now,
					Tags = new List<string>{ "React", "Mui CSS" },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ReactWeb"},
						new UrlLocation{Name = "Webpage", Url = "https://simjes.github.io/ReactWeb/"}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "Angular Webpage", Description = "Portfolio webpage made with Angular and Angular Material.", ImageUrl = "http://i.imgur.com/j2rCiCk.png", ThumbnailUrl = "http://i.imgur.com/j2rCiCkl.png", StartDateTime = DateTime.Now,
					Tags = new List<string>{"Angular", "Angular Material"},
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ngMaterial-website"},
						new UrlLocation{Name = "Webpage", Url = "http://simjes.github.io/ngMaterial-website"}
					},
					 ProjectType = ProjectType.Web
				},
				new Project {Title = "Geek Events App", Description = "Cross-platform application for browsing events. The user can browse events by categories and by local events. Uses Facebook login for adding new events.", ImageUrl = "http://i.imgur.com/6agLPiz.png", ThumbnailUrl = "http://i.imgur.com/6agLPizl.png", StartDateTime = DateTime.Now,
					Tags = new List<string>{"Ionic", "Facebook Graph API"},
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/gevents_app"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "Event Server", Description = "RESTful server for storing events. Saves the data in MongoDB.", ImageUrl = "http://i.imgur.com/Uo3QWry.png", ThumbnailUrl = "http://i.imgur.com/Uo3QWryl.png", StartDateTime = DateTime.Now,
					Tags = new List<string>{"Node", "MongoDB"},
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/gevents_server"}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "", Description = "", ImageUrl = "", ThumbnailUrl = "", StartDateTime = DateTime.Now,
					Tags = new List<string>(),
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "", Url = ""},
						new UrlLocation{Name = "", Url = ""}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "", Description = "", ImageUrl = "", ThumbnailUrl = "", StartDateTime = DateTime.Now,
					Tags = new List<string>(),
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "", Url = ""},
						new UrlLocation{Name = "", Url = ""}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "", Description = "", ImageUrl = "", ThumbnailUrl = "", StartDateTime = DateTime.Now,
					Tags = new List<string>(),
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "", Url = ""},
						new UrlLocation{Name = "", Url = ""}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "", Description = "", ImageUrl = "", ThumbnailUrl = "", StartDateTime = DateTime.Now,
					Tags = new List<string>(),
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "", Url = ""},
						new UrlLocation{Name = "", Url = ""}
					},
					ProjectType = ProjectType.Web
				},
			};

		}

	}
}
