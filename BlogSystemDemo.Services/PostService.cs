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
        public PostService(IBlogSystemDemoData data):base(data)
        {
        }

        public override IQueryable<Post> GetAll()
        {
            //Postları eklenme tarihine göre cek
            return base.GetAll().OrderByDescending(x=>x.CreatedDate);
        }

        public override Post Find(object id)
        {
            return base.Find(id);
        }

        public override void Add(Post entity)
        {
            //Postların tarihini eklenen tarihte kaydet
            entity.CreatedDate = DateTime.Now;
            base.Add(entity);
            base.SaveChanges();
        }

    }
}
