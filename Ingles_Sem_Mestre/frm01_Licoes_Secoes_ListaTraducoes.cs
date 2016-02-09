using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

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
            this.secaoBindingSource.EndEdit();
            this.lista_de_TraducoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iNGLES_SEM_MESTREDataSet);

        }

        private void frm01_Licoes_Secoes_ListaTraducoes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Licoes'. Você pode movê-la ou removê-la conforme necessário.
            this.licoesTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Licoes);
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Secao'. Você pode movê-la ou removê-la conforme necessário.
            this.secaoTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Secao);
            // TODO: esta linha de código carrega dados na tabela 'iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes'. Você pode movê-la ou removê-la conforme necessário.
            this.lista_de_TraducoesTableAdapter.Fill(this.iNGLES_SEM_MESTREDataSet.Lista_de_Traducoes);

        }

        private void btnSalvar_Alteracoes_Click(object sender, EventArgs e)
        {
            licoesBindingNavigatorSaveItem_Click(sender, e);
        }

        private void frm01_Licoes_Secoes_ListaTraducoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                licoesDataGridView.Focus();
            }
            else if (e.KeyCode == Keys.F5)
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
            else if (e.KeyCode == Keys.F12 || (e.KeyCode == Keys.S && e.Control == true))
            {
                licoesBindingNavigatorSaveItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F11 || ((e.KeyCode == Keys.Add || e.KeyCode == Keys.Insert) && e.Control == true))
            {
                lista_de_TraducoesBindingSource.AddNew();
                inglesTextBox.Focus();
            }
            else if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.Up) && e.Control == true)
            {
                lista_de_TraducoesBindingSource.MovePrevious();
                inglesTextBox.Focus();
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.Down) && e.Control == true)
            {
                lista_de_TraducoesBindingSource.MoveNext();
                inglesTextBox.Focus();
            }
            else if (e.KeyCode == Keys.PageUp && e.Control == true)
            {
                lista_de_TraducoesBindingSource.MoveFirst();
                inglesTextBox.Focus();
            }
            else if (e.KeyCode == Keys.PageDown && e.Control == true)
            {
                lista_de_TraducoesBindingSource.MoveLast();
                inglesTextBox.Focus();
            }
            else if (e.KeyCode == Keys.End && e.Control == true)
            {
                licoesBindingSource.MoveLast();
                licoesBindingSource.MovePrevious();
                secaoBindingSource.MoveLast();
                secaoBindingSource.MovePrevious();
                lista_de_TraducoesBindingSource.MoveLast();
                lista_de_TraducoesBindingSource.MovePrevious();
                inglesTextBox.Focus();
            }
            else if (e.KeyCode == Keys.F3 || (e.KeyCode == Keys.Divide && e.Control == true) )
            {
                SpeechSynthesizer reader = new SpeechSynthesizer();
                reader.Rate = -2;
                reader.Volume = 100;
                reader.SpeakAsync(inglesTextBox.Text);
            }


        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            licoesBindingNavigatorSaveItem_Click(sender, e);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            licoesBindingNavigatorSaveItem_Click(sender, e);
            Application.Exit();
        }

        private void inglesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control == true)
            {
                Captura_Linguagem_Fonetica C = new Captura_Linguagem_Fonetica();
                try
                {

                    SpeechSynthesizer reader = new SpeechSynthesizer();
                    reader.Rate = -2;
                    reader.Volume = 100;
                    reader.SpeakAsync(inglesTextBox.Text);

                    // Select a speech recognizer that supports English.
                    RecognizerInfo info = null;
                    foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers())
                    {
                        if (ri.Culture.TwoLetterISOLanguageName.Equals("en"))
                        {
                            info = ri;
                            break;
                        }
                    }
                    if (info == null) return;

                    SpeechRecognitionEngine eng = new SpeechRecognitionEngine(info); //new System.Globalization.CultureInfo("en-US")
                    eng.RecognizeAsync(RecognizeMode.Single);

                    Choices sentences = new Choices(inglesTextBox.Text);
                    GrammarBuilder gBuilder = new GrammarBuilder();
                    gBuilder.Append(sentences);
                    Grammar g = new Grammar(gBuilder);

                    eng.LoadGrammar(g);
                    eng.SpeechRecognized +=
                        new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);




                    //foneticoTextBox.Text = C.Get_Fonetico(inglesTextBox.Text);
                }
                catch (Exception Err)
                {
                    try
                    {
                        foneticoTextBox.Text = C.Get_Fonetico(inglesTextBox.Text);
                    }
                    catch (Exception Err2)
                    {
                        foneticoTextBox.Text = "<<" + Err.Message + " at " + Err.Source + " / " + Err2.Message + " at " + Err2.Source + ">>";
                    }
                }
                
            }
        }
        // Create a simple handler for the SpeechRecognized event.
        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show("Speech recognized: " + e.Result.Text);
        }
        private void inglesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
