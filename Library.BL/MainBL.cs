using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.BL.Data;
using System.Threading.Tasks;

namespace Library.BL
{
    public interface IMainBL
    {
        void AddBook(Book book);
        List<Book> LoadBd();
    }
    public class MainBL : IMainBL
    {
        LibraryContext libraryContext;
        IQueryable<Book> books;
        public MainBL()
        {
            libraryContext = new LibraryContext();
            books = libraryContext.Books.AsNoTracking();
        }

        public List<Book> LoadBd()
        {
            return books.ToList();
        }

        public void AddBook(Book book)
        {
            libraryContext.Books.Add(book);
            libraryContext.SaveChanges();
        }
    }
}
