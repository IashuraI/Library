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
    public interface IMainForm
    {
        void LoadBd<T>(List<T> data);
        event EventHandler LoadBD;
        event EventHandler Add;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            addToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            Load += MainForm_Load;
        }

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoadBD != null) LoadBD(this, EventArgs.Empty);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Add != null) Add(this, EventArgs.Empty);
        }
        #endregion

        #region Methods
        public void LoadBd<T>(List<T> data)
        {
            dataGridView.DataSource = data;
        }
        #endregion

        public event EventHandler Add;
        public event EventHandler LoadBD;
    }
}
