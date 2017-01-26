using BlogSystemDemo.Common.Mapping;
using BlogSystemDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSystemDemo.ViewModels
{
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime? CreatedDate { get; set; }

    }
}