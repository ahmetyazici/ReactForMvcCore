using Books.Entities.Concrete;
using System.Collections.Generic;

namespace Books.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book GetByBook(int id);
        void Add(Book book);
        void Update(Book book);

        void Delete(int id);

    }
}