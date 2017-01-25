using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemDemo.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public ApplicationUser Author { get; set; }

        public int AuthorId { get; set; }


    }
}
