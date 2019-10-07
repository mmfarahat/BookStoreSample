using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public interface IBookRepository
    {
        public IEnumerable<Book> AllBooks { get; }

        public Book GetBook(int id);
    }
}
