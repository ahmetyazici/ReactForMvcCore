using Core.DataAccess;
using Books.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        //Custom Operations
    }
}
