using System;
using System.Data.Entity;
using System.Linq;

namespace Library.BL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LibraryContext")
        {
        }
    }
}