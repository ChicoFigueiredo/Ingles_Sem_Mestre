using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Ingles_Sem_Mestre
{
    public partial class frm00_Principal : Form
    {
        public frm00_Principal()
        {
            InitializeComponent();
        }

        private void btnLicoes_Secoes_ListaTraducao_Click(object sender, EventArgs e)
        {
            frm01_Licoes_Secoes_ListaTraducoes f = new frm01_Licoes_Secoes_ListaTraducoes();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Captura_Linguagem_Fonetica_PHOTRANSEDIT C = new Captura_Linguagem_Fonetica_PHOTRANSEDIT();

            string g = C.Get_Fonetico("I like woman with bread");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_Utilities.Backup();
        }

        private void licoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frm00_Principal_Load(object sender, EventArgs e)
        {
        }
    }
}
