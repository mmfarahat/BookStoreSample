using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public class BookRepository : IBookRepository
    {
        AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Book> AllBooks
        {

            get
            {
                return _appDbContext.Books.Include(b => b.Category);
            }
        }

        public Book GetBook(int id)
        {
            return AllBooks.FirstOrDefault(b => b.Id == id);
        }
    }
}
