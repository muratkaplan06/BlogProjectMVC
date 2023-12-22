using System.Collections.Generic;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        private readonly Repository<Blog> _repository = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return _repository.List();
        }

        public List<Blog> GetBlogsByAuthor(int id)
        {
            return _repository.List(x => x.AuthorId == id);
        }

        public List<Blog> GetBlogsByCategory(int id)
        {
            return _repository.List(x => x.CategoryId == id);
        }

        public int AddBlog(Blog blog)
        {
            return _repository.Insert(blog);
        }
    }
}
