using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFreamwork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        Context c = new Context();
        public List<Blog> GetListAll()
        {
            return c.Blogs.ToList();
        }
    }
}
