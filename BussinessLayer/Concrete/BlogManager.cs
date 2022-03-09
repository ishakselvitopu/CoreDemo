using BussinessLayer.Abstract;
using DataAcessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog blog)
        {
            _blogDal.Insert(blog);
        }
        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }
        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }
        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }
        public Blog GetByClassID(int blogID)
        {
            return _blogDal.GetByID(blogID);
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogListByWriter(int writerID)
        {
            return _blogDal.FilterList(x => x.WriterID == writerID);
        }
        public List<Blog> GetBlogByID(int blogID)
        {
            return _blogDal.FilterList(x => x.BlogID == blogID);
        }
        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
    }
}
