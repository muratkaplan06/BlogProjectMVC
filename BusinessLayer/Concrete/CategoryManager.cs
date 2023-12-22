using System.Collections.Generic;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        private readonly Repository<Category> _repository = new Repository<Category>();

        public List<Category> GetAll()
        {
            return _repository.List();
        }

        public Category Get(int id)
        {
            return _repository.GetById(id);
        }

    }
}
