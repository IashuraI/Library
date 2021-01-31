using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public interface IAddBookForm
    {
        void Show();
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }

        event EventHandler closing;
    }
    public partial class AddBookForm : Form, IAddBookForm
    {
        public AddBookForm()
        {
            InitializeComponent();
            FormClosing += AddBookForm_FormClosing;
        }

        private void AddBookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closing != null) closing(this, EventArgs.Empty);
        }

        public string Title { get { return TitleTextBox.Text; } set { Title = value; } }
        public string Author { get { return AuthorTextBox.Text; } set { Author = value; } }
        public string ISBN { get { return ISBNTextBox.Text; } set { ISBN = value; } }
        public decimal Price { get { return PriceUpDown.Value; } set { Price = value; } }
        public int Amount { get { return Convert.ToInt32(AmountUpDown.Value); } set { Amount = value; } }
 

        public event EventHandler closing;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
