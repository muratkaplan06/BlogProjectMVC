using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        private readonly Repository<Contact> _repository = new Repository<Contact>();
        public int InsertContact(Contact contact)
        {
            return _repository.Insert(contact);
        }
    }
}
