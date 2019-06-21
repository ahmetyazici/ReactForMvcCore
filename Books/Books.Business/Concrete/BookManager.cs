using Books.Business.Abstract;
using Books.DataAccess.Abstract;
using Books.DataAccess.Concrete.NpgsqlFramework;
using Books.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
            
        }

        public Book GetByBook(int id)
        {
            return _bookDal.Get(p => p.id == id || id == 0);
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        public void Delete(int id)
        {
            _bookDal.Delete(new Book { id = id });
        }

        

    }
}
