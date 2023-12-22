using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        private readonly Repository<Comment> _repository = new Repository<Comment>();

        public List<Comment> CommentList()
        {
            return _repository.List();
        }

        public List<Comment> GetCommentsById(int id)
        {
            return _repository.List(x => x.BlogId == id);
        }

        public int CommentAdd(Comment comment)
        {
            return _repository.Insert(comment);
        }
    }
}
