using System;
namespace BookStoreSample.Model
{
    public interface IUnitOFWork : IDisposable
    {
        IBookRepository Books { get; }

        IcategoryRepository Categories { get; }
        int Complete();
    }
}