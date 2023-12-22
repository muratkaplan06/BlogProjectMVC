using System.Collections.Generic;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        private readonly Repository<About> _repository = new Repository<About>();

        public List<About> GetAll()
        {
            return _repository.List();
        }

    }
}
