using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaTestyGenerowanie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Model model = new Model();
            ViewCreatorWindow view = new ViewCreatorWindow();
            Presenter p = new Presenter(model, view);
            Application.Run(view);
        }
    }
}
