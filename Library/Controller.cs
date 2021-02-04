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
        readonly IMessageService messageService;
        private IAddBookForm addBookForm;

        public Controller(IMainBL mainBL, IMainForm mainForm, IMessageService messageService)
        {
            this.mainBL = mainBL;
            this.mainForm = mainForm;
            this.messageService = messageService;

            mainForm.LoadBD += MainForm_LoadBD;
            mainForm.Add += MainForm_Add;
        }

        private void MainForm_Add(object sender, EventArgs e)
        {
            addBookForm = new AddBookForm();
            addBookForm.SaveData += AddBookForm_SaveData;
            addBookForm.Show();
        }

        private void AddBookForm_SaveData(object sender, EventArgs e)
        {
            Book book = new Book();
            if(book.Title == null)
            {
                messageService.ShowExclamation("Title should not be equal to null");
                return;
            }
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
