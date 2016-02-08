﻿using System;
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
    public partial class frm01_Licoes_Secoes_ListaTraducoes : Form
    {
        public frm01_Licoes_Secoes_ListaTraducoes()
        {
            InitializeComponent();
        }

        private void licoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.licoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNGLES_SEM_MESTREDataSet);

        }

        private void frm01_Licoes_Secoes_ListaTraducoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes'. Você pode movê-la ou removê-la conforme necessário.
            this.lista_de_TraducoesTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes);
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes'. Você pode movê-la ou removê-la conforme necessário.
            this.lista_de_TraducoesTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes);
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Secao'. Você pode movê-la ou removê-la conforme necessário.
            this.secaoTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Secao);
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Licoes'. Você pode movê-la ou removê-la conforme necessário.
            this.licoesTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Licoes);

        }

        private void btnSalvar_Alteracoes_Click(object sender, EventArgs e)
        {
            licoesBindingNavigatorSaveItem_Click(sender, e);
        }

        private void frm01_Licoes_Secoes_ListaTraducoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                tabControl_Licao.SelectedIndex = 0;
                secaoDataGridView.Focus();
            }
            else if (e.KeyCode == Keys.F6)
            {
                tabControl_Licao.SelectedIndex = 1;
                materia_PortuguesRichTextBox.Focus();
            }
            else if (e.KeyCode == Keys.F7)
            {
                tabControl_Licao.SelectedIndex = 0;
                tabControl_Secao.SelectedIndex = 0;
                lista_de_TraducoesDataGridView.Focus();
            }
            else if (e.KeyCode == Keys.F8)
            {
                tabControl_Licao.SelectedIndex = 0;
                tabControl_Secao.SelectedIndex = 1;
                materia_PortuguesRichTextBox1.Focus();
            }
            else if (e.KeyCode == Keys.F9)
            {
                tabControl_Licao.SelectedIndex = 0;
                tabControl_Secao.SelectedIndex = 0;
                tabControl_Lista_Traducao.SelectedIndex = 0;
                inglesTextBox.Focus();
            }
            else if (e.KeyCode == Keys.F10)
            {
                tabControl_Licao.SelectedIndex = 0;
                tabControl_Secao.SelectedIndex = 0;
                tabControl_Lista_Traducao.SelectedIndex = 1;
                materia_PortuguesRichTextBox2.Focus();
            }
        }

        private void frm01_Licoes_Secoes_ListaTraducoes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
    }
}
