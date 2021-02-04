using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.BL;

namespace Library
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            MainBL mainBL = new MainBL();
            MessageService messageService = new MessageService();

            Controller controller = new Controller(mainBL, mainForm, messageService);

            Application.Run(mainForm);
        }
    }
}
