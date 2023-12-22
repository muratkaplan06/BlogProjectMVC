using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{ 
    public class SubsribeMailManager
    {
        private readonly Repository<SubscribeMail> _repository = new Repository<SubscribeMail>();

        public int Add(SubscribeMail subscribeMail)
        {

            return _repository.Insert(subscribeMail);
        }
    }
}
