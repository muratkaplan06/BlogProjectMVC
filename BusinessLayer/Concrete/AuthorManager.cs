using System.Collections.Generic;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    
    public class AuthorManager
    {
        private readonly Repository<Author> _repository = new Repository<Author>();
        public List<Author> GetAll()
        {
            return _repository.List();
        }
    }
}
