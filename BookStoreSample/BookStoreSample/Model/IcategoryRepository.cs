using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Model
{
    public interface IcategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
        public Category GetCategory(int id);

    }
}
