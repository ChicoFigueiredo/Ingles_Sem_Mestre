using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingles_Sem_Mestre
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm00_Principal());
        }

        private static System.Threading.Timer Vigia = new System.Threading.Timer(VigiaTimerCallback, 5, 0, 1800000);

        private static void VigiaTimerCallback(Object o)
        {
            SQL_Utilities.Backup();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }
    }
}
