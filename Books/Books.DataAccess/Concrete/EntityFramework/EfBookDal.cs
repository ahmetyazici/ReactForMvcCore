
using Core.NpgSql;
using Books.DataAccess.Abstract;
using Books.Entities.Concrete;
using Core.EntityFramework;
using Books.DataAccess.Concrete.EntityFramework;

namespace Books.DataAccess.Concrete.NpgsqlFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, EfNorthwindContext>, IBookDal
    {

    }
}
