using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BL;
using Library.BL.Data;

namespace Library
{
    class Controller
    {
        readonly IMainBL mainBL;
        readonly IMainForm mainForm;
        readonly IAddBookForm addBookForm;

        public Controller(IMainBL mainBL, IMainForm mainForm)
        {
            addBookForm = new AddBookForm();
            addBookForm.closing += AddBookForm_closing;

            this.mainBL = mainBL;
            this.mainForm = mainForm;

            mainForm.LoadBD += MainForm_LoadBD;
            mainForm.Add += MainForm_Add;
        }

        private void MainForm_Add(object sender, EventArgs e)
        {
            addBookForm.Show();
        }

        private void AddBookForm_closing(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = addBookForm.Title;
            book.Author = addBookForm.Author;
            book.ISBN = addBookForm.ISBN;
            book.Price = addBookForm.Price;
            book.Amount = addBookForm.Amount;
            mainBL.AddBook(book);
            mainForm.LoadBd(mainBL.LoadBd());
        }

        private void MainForm_LoadBD(object sender, EventArgs e)
        {
            mainForm.LoadBd(mainBL.LoadBd());
        }
    }
}
