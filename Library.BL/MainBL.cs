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
        IQueryable<Book> Books;
        public MainBL()
        {
            libraryContext = new LibraryContext();
            Books = libraryContext.Books.AsNoTracking();
        }

        public List<Book> LoadBd()
        {
            return Books.ToList();
        }

        public void AddBook(Book book)
        {
            libraryContext.Books.Add(book);
            libraryContext.SaveChanges();
        }
    }
}
