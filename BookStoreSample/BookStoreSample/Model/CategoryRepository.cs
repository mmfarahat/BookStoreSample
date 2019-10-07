using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public class CategoryRepository : IcategoryRepository
    {
        AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appDbContext.Categories;

            }
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
