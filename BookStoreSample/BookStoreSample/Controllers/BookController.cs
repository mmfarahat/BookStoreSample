using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreSample.Model;
using BookStoreSample.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreSample.Controllers
{
    public class BookController : Controller
    {
        IBookRepository _bookRepository;
        IcategoryRepository _categoryRepository;
        public BookController(IBookRepository bookRepository, IcategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            BooksListViewModel booksListViewModel = new BooksListViewModel();
            booksListViewModel.Books = _bookRepository.AllBooks;
            booksListViewModel.CategoryTitle = "All books";
            return View(booksListViewModel);
        }
    }
}
