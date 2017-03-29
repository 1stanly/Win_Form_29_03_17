using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form_28_03_17
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Library lib = new Library();
            lib.CreateLibraryBooks();
            lib.CreateLibraryJournals();
            lib.CreateLibraryNewspaper();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestButtonsForm());
            
        }
    }
}
