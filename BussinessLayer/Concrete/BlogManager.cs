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
        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetBlogList()
        {
            return _blogDal.GetListAll();
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetByBlogID(int blogID)
        {
            return _blogDal.GetByID(blogID);
            
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
        public List<Blog> GetBlogByID(int blogID)
        {
            return _blogDal.FilterList(x => x.BlogID == blogID);
        }

        public List<Blog> GetBlogListByWriter(int writerID)
        {
            return _blogDal.FilterList(x => x.WriterID == writerID);
        }
    }
}
