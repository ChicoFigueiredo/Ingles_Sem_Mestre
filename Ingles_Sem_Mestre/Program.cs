using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            Backup();
            // Force a garbage collection to occur for this demo.
            GC.Collect();
        }


        private static async void Backup()
        {
            await Task.Run(() => {
                string SQL_Command = String.Format("BACKUP DATABASE [INGLES_SEM_MESTRE] TO  DISK = N'C:\\Users\\franf\\OneDrive\\BACKUPs\\Ingles_Sem_Mestre_{0}.bak' WITH NOFORMAT, NOINIT,  NAME = N'INGLES_SEM_MESTRE-Completo Banco de Dados Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 10", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
                SqlConnection Conn = new SqlConnection(Properties.Settings.Default.INGLES_SEM_MESTREConnectionString);
                Conn.Open();
                SqlCommand C = new SqlCommand(SQL_Command, Conn);
                C.ExecuteNonQuery();
            });
        }
    }
}
