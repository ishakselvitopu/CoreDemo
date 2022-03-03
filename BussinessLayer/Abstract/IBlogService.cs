using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        List<Blog> GetBlogList();
        Blog GetByBlogID(int blogID);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByWriter(int writerID);
    }
}