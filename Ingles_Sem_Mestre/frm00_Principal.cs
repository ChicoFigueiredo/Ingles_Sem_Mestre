using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
