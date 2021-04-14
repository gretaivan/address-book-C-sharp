using System;
using System.Windows.Forms;
using System.Threading;
namespace CWK2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //test connection with thread
            ThreadStart myThreadStart = new ThreadStart(DB.connect);
            Thread connectionThread = new Thread(myThreadStart);
            connectionThread.Start(); 

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());



        }
    }
}
