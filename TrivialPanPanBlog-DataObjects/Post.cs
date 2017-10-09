using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrivialPanPanBlog_DataObjects
{
	public enum PublicationState
	{
		Draft,
		Published,
		Archived
	}
    public class Post
    {
	    public Post()
	    {
		    this.Tags = new HashSet<Tag>();
	    }

		public int Id { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string Description { get; set; }
		public string Meta { get; set; }
		public string UrlSlug { get; set; }
		public PublicationState State { get; set; }
		public DateTime PublishedOn { get; set; }
		public DateTime? ModifiedOn { get; set; }
		public string Author { get; set; }
		public virtual Category Category { get; set; }
		public virtual ICollection<Tag> Tags { get; set; }
    }
}
