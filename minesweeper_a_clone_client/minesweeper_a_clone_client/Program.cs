using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace minesweeper_a_clone_client
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread()]
        static void Main(string[] args)
        {
            
            using (msgame game = new msgame())
            {
                game.Run();
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new mainFrm());
        }
    }
#endif
}

