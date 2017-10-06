using System;
using System.Collections.Generic;
using System.Linq;

namespace SimFolio.Models
{
	public static class DbInitializer
	{
		public static void Initialize(ProjectDbContext context)
		{
			context.Database.EnsureCreated();

			if (context.Projects.Any()) return;

			var projects = new List<Project>
			{
				new Project {Title = "Arcade Machine", Description = "Fun summer project.", ImageUrl = "https://i.imgur.com/KMrrJ6r.jpg", ThumbnailUrl = "https://i.imgur.com/KMrrJ6rl.jpg", StartDateTime = new DateTime(2015, 6, 11),
					Tags = new List<Tag>{ new Tag{Name = "Woodwork"}, new Tag { Name = "Arcade" }, new Tag { Name = "RetroPie" }},
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Guide", Url = "http://www.instructables.com/id/2-Player-Bartop-Arcade-Machine-Powered-by-Pi/"}
					},
					ProjectType = ProjectType.Others
				},
				new Project {Title = "React Material", Description = "Portfolio page in React. Using Mui CSS for material design.", ImageUrl = "https://i.imgur.com/NHOwOda.png", ThumbnailUrl = "https://i.imgur.com/NHOwOdal.png", StartDateTime = new DateTime(2016, 1, 10),
					Tags = new List<Tag>{ new Tag{Name = "React"}, new Tag { Name = "Mui CSS" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ReactWeb"},
						new UrlLocation{Name = "Webpage", Url = "https://simjes.github.io/ReactWeb/"}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "Angular Webpage", Description = "Portfolio webpage made with Angular and Angular Material.", ImageUrl = "https://i.imgur.com/j2rCiCk.png", ThumbnailUrl = "https://i.imgur.com/j2rCiCkl.png", StartDateTime = new DateTime(2015, 8, 27),
					Tags = new List<Tag>{ new Tag{Name = "Angular" }, new Tag { Name = "Angular Material" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ngMaterial-website"},
						new UrlLocation{Name = "Webpage", Url = "http://simjes.github.io/ngMaterial-website"}
					},
					 ProjectType = ProjectType.Web
				},
				new Project {Title = "Geek Events App", Description = "Cross-platform application for browsing events. The user can browse events by categories and by local events. Uses Facebook login for adding new events.", ImageUrl = "http://i.imgur.com/6agLPiz.png", ThumbnailUrl = "http://i.imgur.com/6agLPizl.png", StartDateTime = new DateTime(2016, 8, 27),
					Tags = new List<Tag>{ new Tag{Name = "Ionic" }, new Tag { Name = "Facebook Graph API" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/gevents_app"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "Event Server", Description = "RESTful server for storing events. Saves the data in MongoDB.", ImageUrl = "https://i.imgur.com/Uo3QWry.png", ThumbnailUrl = "https://i.imgur.com/Uo3QWryl.png", StartDateTime = new DateTime(2016, 4, 21),
					Tags = new List<Tag>{ new Tag{Name = "Node" }, new Tag { Name = "MongoDB" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/gevents_server"}
					},
					ProjectType = ProjectType.Backend
				},
				new Project {Title = "Snagpaper", Description = "Uses Imgur API to find images with the wallpaper tag. Save and favorite images.", ImageUrl = "https://i.imgur.com/vfQgIO9.png", ThumbnailUrl = "https://i.imgur.com/vfQgIO9l.png", StartDateTime = new DateTime(2016, 10, 29),
					Tags = new List<Tag>{ new Tag{Name = "Android" }, new Tag { Name = "Realm" }, new Tag { Name = "Imgur API" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/Snagpaper"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "WatchPaper", Description = "Swift app for changing wallpaper based on hour of the day. Runs with launchd. Includes KLWP for Android.", ImageUrl = "https://i.imgur.com/H73I7Bs.png", ThumbnailUrl = "https://i.imgur.com/H73I7Bsl.png", StartDateTime = new DateTime(2016, 9, 26),
					Tags = new List<Tag>{ new Tag{Name = "Swift" }, new Tag { Name = "SQLite" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/WatchPaper"},
					},
					ProjectType = ProjectType.Others
				},
				new Project {Title = "ShopListSwift", Description = "iOS application for writing down notes and groceries. Stores the data in a Realm database.", ImageUrl = "https://i.imgur.com/RWhLAih.png", ThumbnailUrl = "https://i.imgur.com/RWhLAihl.png", StartDateTime = new DateTime(2016, 8, 13),
					Tags = new List<Tag>{ new Tag{Name = "Swift" }, new Tag { Name = "iOS" },new Tag { Name = "Realm" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ShopListSwift"},
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "Firestorm", Description = "A remote control for a gas fireplace. The Raspberry Pi runs a Python or a Golang HTTP server to listen for commands from a Android application. Based on the request it receives, the Raspberry Pi turns the heat up or down.", ImageUrl = "http://i.imgur.com/zepUUwe.png", ThumbnailUrl = "http://i.imgur.com/zepUUwel.png", StartDateTime = new DateTime(2014, 3, 15),
					Tags = new List<Tag>{ new Tag{Name = "Android" }, new Tag { Name = "Raspberry PI" },new Tag { Name = "Go" },new Tag { Name = "Python" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/Firestorm"},
						new UrlLocation{Name = "Youtube", Url = "https://www.youtube.com/watch?v=aHwYtt6lNsw"}
					},
					ProjectType = ProjectType.Others
				},
				new Project {Title = "DHIS2 tools", Description = "Updating the dhis2-tools Ubuntu package. dhis2-tools is a collection of tools and utilities for installing and managing DHIS2 applications on an Ubuntu server.", ImageUrl = "https://i.imgur.com/tMO7JQW.png", ThumbnailUrl = "https://i.imgur.com/tMO7JQWl.png", StartDateTime = new DateTime(2016, 9, 29),
					Tags = new List<Tag>{ new Tag{Name = "Ubuntu Package" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/dhis2-tools"},
						new UrlLocation{Name = "Launchpad", Url = "https://launchpad.net/~simjes91/+archive/ubuntu/dhis2-tools"}
					},
					ProjectType = ProjectType.Others
				},
				new Project {Title = "WeatherFuse", Description = "Cross-platform app to check the weather based on your GPS location, uses data from OpenWeatherMap.org. Testing out Fuse for building native cross-platform apps. New update broke the build, so stopped working on it until it is more stable.", ImageUrl = "https://i.imgur.com/eje0u52.png", ThumbnailUrl = "https://i.imgur.com/eje0u52l.png", StartDateTime = new DateTime(2016, 8, 22),
					Tags = new List<Tag>{ new Tag{Name = "Fuse" },new Tag{Name = "OpenWeatherMap API" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/WeatherFuse"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "Org Unit Manager", Description = "WebApp for DHIS2. Can be used to browse, edit and add organisational units in DHIS2.", ImageUrl = "https://i.imgur.com/4kUsQAS.jpg", ThumbnailUrl = "https://i.imgur.com/4kUsQASl.jpg", StartDateTime = new DateTime(2015, 12, 8),
					Tags = new List<Tag>{ new Tag{Name = "DHIS2 WebApp" },new Tag{Name = "AngularJS" }, new Tag{Name = "DHIS2 API" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/dhis2-orgunit"}
					},
					ProjectType = ProjectType.Web
				},
				new Project {Title = "SimCV", Description = "Uses OpenCV library on Android for face tracking, circle detection, color tracking and more. This was made as part of my bachelor thesis.", ImageUrl = "https://i.imgur.com/YWWMolv.png", ThumbnailUrl = "https://i.imgur.com/YWWMolvl.png", StartDateTime = new DateTime(2015, 5, 8),
					Tags = new List<Tag>{ new Tag{Name = "Android" },new Tag{Name = "OpenCV" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/OpenCV-Bachelor"},
						new UrlLocation{Name = "Youtube", Url = "https://www.youtube.com/watch?v=oCViAhgrZn0"},
						new UrlLocation{Name = "Android", Url = "https://play.google.com/store/apps/details?id=com.simjessimsol.simcv&hl=en"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "SimCV Game", Description = "A game made with LibGDX and OpenCV. It uses the Android camera to track a specified color, when the user moves the color the ingame character moves.", ImageUrl = "https://i.imgur.com/fUkm808.png", ThumbnailUrl = "https://i.imgur.com/fUkm808l.png", StartDateTime = new DateTime(2015, 5, 8),
					Tags = new List<Tag>{ new Tag{Name = "Android" },new Tag{Name = "OpenCV" }, new Tag{Name = "LibGDX" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/OpenCV-Bachelor"},
						new UrlLocation{Name = "Youtube", Url = "https://www.youtube.com/watch?v=OY1HrQPOHJY"},
						new UrlLocation{Name = "Android", Url = "https://play.google.com/store/apps/details?id=com.simjessimsol.simcvgame.android&hl=en"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "Streemer", Description = "Cross-platform application for watching streams from different streaming website. Twitch API has changed, so it is currently broken.", ImageUrl = "https://i.imgur.com/NS3eG7U.png", ThumbnailUrl = "https://i.imgur.com/NS3eG7Ul.png", StartDateTime = new DateTime(2015, 10, 24),
					Tags = new List<Tag>{ new Tag{Name = "Ionic" },new Tag{Name = "Twitch API" }, new Tag{Name = "Hitbox API" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/Streemer"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "ShopList", Description = "Shopping list application for Android.", ImageUrl = "https://i.imgur.com/NSlX1ci.png", ThumbnailUrl = "https://i.imgur.com/NSlX1cil.png", StartDateTime = new DateTime(2016, 3, 6),
					Tags = new List<Tag>{ new Tag{Name = "Android" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/ShopList"},
						new UrlLocation{Name = "Android", Url = "https://play.google.com/store/apps/details?id=com.simjes.shoplist"}
					},
					ProjectType = ProjectType.Mobile
				},
				new Project {Title = "pictureSort", Description = "Makes a copy of all the unique pictures in the Windows picture folder and sorts them in the a new folder. In the new folder the pictures are put in folders sorted by date of when the pictures was taken.", ImageUrl = "https://i.imgur.com/zk2JhI5.png", ThumbnailUrl = "https://i.imgur.com/zk2JhI5l.png", StartDateTime = new DateTime(2014, 5, 7),
					Tags = new List<Tag>{ new Tag{Name = "C#" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/simjes/pictureSort"}
					},
					ProjectType = ProjectType.Others
				},
				new Project {Title = "Photo Viewer", Description = "A desktop application that can be used to view and upload pictures to a server, as well as edit metadata of the pictures. The pictures can be filtered by metadata and by the folders they are located in. The server uses a SQLite database to keep track of all the information.", ImageUrl = "https://i.imgur.com/nWftgII.png", ThumbnailUrl = "https://i.imgur.com/nWftgIIl.png", StartDateTime = new DateTime(2014, 1, 12),
					Tags = new List<Tag>{ new Tag{Name = "Java" },new Tag{Name = "Hibernate" }, new Tag{Name = "SQLite" } },
					UrlLocation = new List<UrlLocation>
					{
						new UrlLocation{Name = "Github", Url = "https://github.com/snorheim/DAT210G"}
					},
					ProjectType = ProjectType.Others
				},
			};
			context.Projects.AddRange(projects);
			context.SaveChanges();

		}

	}
}
