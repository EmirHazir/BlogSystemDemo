using BlogSystemDemo.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSystemDemo.Models;
using BlogSystemDemo.Data;


namespace BlogSystemDemo.Services
{
    public class PostService : BaseService<Post>, IPostService
    {
        public PostService(IBlogSystemDemoData data)
            :base(data)
        {
        }

        //Eklerken tarihide burada verdim
        public override void Add(Post entity)
        {
            entity.CreatedDate = DateTime.Now;
            base.Add(entity);
            base.SaveChanges();
        }

    }
}
