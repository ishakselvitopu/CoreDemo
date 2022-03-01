using DataAcessLayer.Abstract;
using DataAcessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context context = new Context();
        public void AddBlog(Blog blog)
        {
            context.Add(blog);
            context.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            context.Remove(blog);
            context.SaveChanges();
        }

        public Blog GetByBlogID(int BlogID)
        {
            return context.Blogs.Find(BlogID);    
        }

        public List<Blog> ListAllBlog()
        {
            return context.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            context.Update(context);
            context.SaveChanges();
        }
    }
}
