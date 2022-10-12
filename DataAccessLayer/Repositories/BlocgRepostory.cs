using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlocgRepostory : IBlogDal

    {
        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id  );
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }

        void IGenericDal<Blog>.Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        List<Blog> IGenericDal<Blog>.GetListAll(int İd)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<Blog>.Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<Blog>.Update(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
