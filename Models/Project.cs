using System;
using System.Collections.Generic;

namespace SimFolio.Models
{
	public class Project
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime StartDateTime { get; set; }
		public string ImageUrl { get; set; }
		public string ThumbnailUrl { get; set; }
		public ICollection<UrlLocation> UrlLocation { get; set; }
		public ICollection<Tag> Tags { get; set; }
		public ProjectType ProjectType { get; set; }

	}

	public enum ProjectType
	{
		Mobile,
		Web,
		Backend,
		Others
	}

}


