using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public class UnitOfWork : IUnitOFWork
    {


        private readonly AppDbContext _appDbContext;
        public IBookRepository Books { get; }
        public IcategoryRepository Categories { get; }


        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            Books = new BookRepository(_appDbContext);
            Categories = new CategoryRepository(_appDbContext);
        }
     

        public int Complete()
        {
           return _appDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
