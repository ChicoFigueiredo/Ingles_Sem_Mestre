using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ingles_Sem_Mestre
{
    class SQL_Utilities
    {
        public static async void Backup()
        {
            await Task.Run(() => {
                string SQL_Command = String.Format("BACKUP DATABASE [INGLES_SEM_MESTRE] TO  DISK = N'" + Properties.Settings.Default.Padrao_Backup + "' WITH NOFORMAT, NOINIT,  NAME = N'INGLES_SEM_MESTRE-Completo Banco de Dados Backup', SKIP, NOREWIND, NOUNLOAD, COMPRESSION,  STATS = 10", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
                SqlConnection Conn = new SqlConnection(Properties.Settings.Default.INGLES_SEM_MESTREConnectionString);
                Conn.Open();
                SqlCommand C = new SqlCommand(SQL_Command, Conn);
                C.ExecuteNonQuery();
            });
        }
    }

}
