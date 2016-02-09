namespace Ingles_Sem_Mestre
{
    partial class frm01_Licoes_Secoes_ListaTraducoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label materia_PortuguesLabel;
            System.Windows.Forms.Label titulo_SecaoLabel;
            System.Windows.Forms.Label materia_PortuguesLabel1;
            System.Windows.Forms.Label inglesLabel;
            System.Windows.Forms.Label traducaoLabel;
            System.Windows.Forms.Label foneticoLabel;
            System.Windows.Forms.Label transliteracaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm01_Licoes_Secoes_ListaTraducoes));
            this.iNGLES_SEM_MESTREDataSet = new Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSet();
            this.licoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licoesTableAdapter = new Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSetTableAdapters.LicoesTableAdapter();
            this.tableAdapterManager = new Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSetTableAdapters.TableAdapterManager();
            this.lista_de_TraducoesTableAdapter = new Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSetTableAdapters.Lista_de_TraducoesTableAdapter();
            this.secaoTableAdapter = new Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSetTableAdapters.SecaoTableAdapter();
            this.licoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.licoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.licoesDataGridView = new System.Windows.Forms.DataGridView();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBusca_Licoes = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar_Alteracoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.tabControl_Licao = new System.Windows.Forms.TabControl();
            this.tabSecoes = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.secaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.secaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtBusca_Secoes = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.titulo_SecaoTextBox = new System.Windows.Forms.TextBox();
            this.tabControl_Secao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.lista_de_TraducoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.lista_de_TraducoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.tabControl_Lista_Traducao = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.transliteracaoTextBox = new System.Windows.Forms.TextBox();
            this.foneticoTextBox = new System.Windows.Forms.TextBox();
            this.traducaoTextBox = new System.Windows.Forms.TextBox();
            this.inglesTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materia_PortuguesRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materia_PortuguesRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabMateria_Licao = new System.Windows.Forms.TabPage();
            this.materia_PortuguesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            numeroLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            materia_PortuguesLabel = new System.Windows.Forms.Label();
            titulo_SecaoLabel = new System.Windows.Forms.Label();
            materia_PortuguesLabel1 = new System.Windows.Forms.Label();
            inglesLabel = new System.Windows.Forms.Label();
            traducaoLabel = new System.Windows.Forms.Label();
            foneticoLabel = new System.Windows.Forms.Label();
            transliteracaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iNGLES_SEM_MESTREDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoesBindingNavigator)).BeginInit();
            this.licoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licoesDataGridView)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl_Licao.SuspendLayout();
            this.tabSecoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStripContainer2.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secaoDataGridView)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl_Secao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.toolStripContainer3.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_de_TraducoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_de_TraducoesDataGridView)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.tabControl_Lista_Traducao.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabMateria_Licao.SuspendLayout();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(1, 6);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 0;
            numeroLabel.Text = "Numero:";
            // 
            // tituloLabel
            // 
            tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tituloLabel.AutoSize = true;
            tituloLabel.Location = new System.Drawing.Point(12, 32);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(36, 13);
            tituloLabel.TabIndex = 2;
            tituloLabel.Text = "Titulo:";
            // 
            // materia_PortuguesLabel
            // 
            materia_PortuguesLabel.AutoSize = true;
            materia_PortuguesLabel.Location = new System.Drawing.Point(8, 3);
            materia_PortuguesLabel.Name = "materia_PortuguesLabel";
            materia_PortuguesLabel.Size = new System.Drawing.Size(112, 13);
            materia_PortuguesLabel.TabIndex = 0;
            materia_PortuguesLabel.Text = "Materia em portugues:";
            // 
            // titulo_SecaoLabel
            // 
            titulo_SecaoLabel.AutoSize = true;
            titulo_SecaoLabel.Location = new System.Drawing.Point(7, 6);
            titulo_SecaoLabel.Name = "titulo_SecaoLabel";
            titulo_SecaoLabel.Size = new System.Drawing.Size(85, 13);
            titulo_SecaoLabel.TabIndex = 0;
            titulo_SecaoLabel.Text = "Titulo da Seção:";
            // 
            // materia_PortuguesLabel1
            // 
            materia_PortuguesLabel1.AutoSize = true;
            materia_PortuguesLabel1.Location = new System.Drawing.Point(3, 7);
            materia_PortuguesLabel1.Name = "materia_PortuguesLabel1";
            materia_PortuguesLabel1.Size = new System.Drawing.Size(96, 13);
            materia_PortuguesLabel1.TabIndex = 0;
            materia_PortuguesLabel1.Text = "Materia Portugues:";
            // 
            // inglesLabel
            // 
            inglesLabel.AutoSize = true;
            inglesLabel.Location = new System.Drawing.Point(43, 9);
            inglesLabel.Name = "inglesLabel";
            inglesLabel.Size = new System.Drawing.Size(38, 13);
            inglesLabel.TabIndex = 0;
            inglesLabel.Text = "Ingles:";
            // 
            // traducaoLabel
            // 
            traducaoLabel.AutoSize = true;
            traducaoLabel.Location = new System.Drawing.Point(25, 35);
            traducaoLabel.Name = "traducaoLabel";
            traducaoLabel.Size = new System.Drawing.Size(56, 13);
            traducaoLabel.TabIndex = 2;
            traducaoLabel.Text = "Traducao:";
            // 
            // foneticoLabel
            // 
            foneticoLabel.AutoSize = true;
            foneticoLabel.Location = new System.Drawing.Point(30, 61);
            foneticoLabel.Name = "foneticoLabel";
            foneticoLabel.Size = new System.Drawing.Size(51, 13);
            foneticoLabel.TabIndex = 4;
            foneticoLabel.Text = "Fonetico:";
            // 
            // transliteracaoLabel
            // 
            transliteracaoLabel.AutoSize = true;
            transliteracaoLabel.Location = new System.Drawing.Point(4, 87);
            transliteracaoLabel.Name = "transliteracaoLabel";
            transliteracaoLabel.Size = new System.Drawing.Size(77, 13);
            transliteracaoLabel.TabIndex = 6;
            transliteracaoLabel.Text = "Transliteracao:";
            // 
            // iNGLES_SEM_MESTREDataSet
            // 
            this.iNGLES_SEM_MESTREDataSet.DataSetName = "INGLES_SEM_MESTREDataSet";
            this.iNGLES_SEM_MESTREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licoesBindingSource
            // 
            this.licoesBindingSource.DataMember = "Licoes";
            this.licoesBindingSource.DataSource = this.iNGLES_SEM_MESTREDataSet;
            this.licoesBindingSource.Sort = "Grupo, Numero DESC";
            // 
            // licoesTableAdapter
            // 
            this.licoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LicoesTableAdapter = this.licoesTableAdapter;
            this.tableAdapterManager.Lista_de_TraducoesTableAdapter = this.lista_de_TraducoesTableAdapter;
            this.tableAdapterManager.SecaoTableAdapter = this.secaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ingles_Sem_Mestre.INGLES_SEM_MESTREDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lista_de_TraducoesTableAdapter
            // 
            this.lista_de_TraducoesTableAdapter.ClearBeforeFill = true;
            // 
            // secaoTableAdapter
            // 
            this.secaoTableAdapter.ClearBeforeFill = true;
            // 
            // licoesBindingNavigator
            // 
            this.licoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.licoesBindingNavigator.BindingSource = this.licoesBindingSource;
            this.licoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.licoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.licoesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.licoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.licoesBindingNavigatorSaveItem});
            this.licoesBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.licoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.licoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.licoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.licoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.licoesBindingNavigator.Name = "licoesBindingNavigator";
            this.licoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.licoesBindingNavigator.Size = new System.Drawing.Size(251, 25);
            this.licoesBindingNavigator.TabIndex = 0;
            this.licoesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // licoesBindingNavigatorSaveItem
            // 
            this.licoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.licoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("licoesBindingNavigatorSaveItem.Image")));
            this.licoesBindingNavigatorSaveItem.Name = "licoesBindingNavigatorSaveItem";
            this.licoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.licoesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.licoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.licoesBindingNavigatorSaveItem_Click);
            // 
            // licoesDataGridView
            // 
            this.licoesDataGridView.AutoGenerateColumns = false;
            this.licoesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.licoesDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.licoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.licoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grupo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.licoesDataGridView.DataSource = this.licoesBindingSource;
            this.licoesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.licoesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.licoesDataGridView.Name = "licoesDataGridView";
            this.licoesDataGridView.RowHeadersWidth = 24;
            this.licoesDataGridView.Size = new System.Drawing.Size(254, 593);
            this.licoesDataGridView.TabIndex = 1;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "Grupo";
            this.Grupo.HeaderText = "G";
            this.Grupo.Name = "Grupo";
            this.Grupo.Width = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 39;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 58;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.licoesBindingNavigator);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.licoesDataGridView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(254, 593);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(254, 643);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtBusca_Licoes});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(205, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Busca:";
            // 
            // txtBusca_Licoes
            // 
            this.txtBusca_Licoes.Name = "txtBusca_Licoes";
            this.txtBusca_Licoes.Size = new System.Drawing.Size(150, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar_Alteracoes,
            this.toolStripButton15});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1098, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSalvar_Alteracoes
            // 
            this.btnSalvar_Alteracoes.Image = global::Ingles_Sem_Mestre.Properties.Resources.save;
            this.btnSalvar_Alteracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar_Alteracoes.Name = "btnSalvar_Alteracoes";
            this.btnSalvar_Alteracoes.Size = new System.Drawing.Size(116, 22);
            this.btnSalvar_Alteracoes.Text = "Salvar Alterações";
            this.btnSalvar_Alteracoes.Click += new System.EventHandler(this.btnSalvar_Alteracoes_Click);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton15.Text = "&Sair";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton15_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 643);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(tituloLabel);
            this.splitContainer2.Panel1.Controls.Add(this.tituloTextBox);
            this.splitContainer2.Panel1.Controls.Add(numeroLabel);
            this.splitContainer2.Panel1.Controls.Add(this.numeroTextBox);
            this.splitContainer2.Panel1MinSize = 55;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl_Licao);
            this.splitContainer2.Size = new System.Drawing.Size(840, 643);
            this.splitContainer2.SplitterDistance = 55;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licoesBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(54, 29);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(774, 20);
            this.tituloTextBox.TabIndex = 3;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licoesBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(54, 3);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroTextBox.TabIndex = 1;
            // 
            // tabControl_Licao
            // 
            this.tabControl_Licao.Controls.Add(this.tabSecoes);
            this.tabControl_Licao.Controls.Add(this.tabMateria_Licao);
            this.tabControl_Licao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Licao.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Licao.Name = "tabControl_Licao";
            this.tabControl_Licao.SelectedIndex = 0;
            this.tabControl_Licao.Size = new System.Drawing.Size(840, 583);
            this.tabControl_Licao.TabIndex = 0;
            // 
            // tabSecoes
            // 
            this.tabSecoes.Controls.Add(this.splitContainer3);
            this.tabSecoes.Location = new System.Drawing.Point(4, 22);
            this.tabSecoes.Name = "tabSecoes";
            this.tabSecoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecoes.Size = new System.Drawing.Size(832, 557);
            this.tabSecoes.TabIndex = 1;
            this.tabSecoes.Text = "Seções (F5)";
            this.tabSecoes.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.toolStripContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(826, 551);
            this.splitContainer3.SplitterDistance = 259;
            this.splitContainer3.TabIndex = 0;
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.BottomToolStripPanel
            // 
            this.toolStripContainer2.BottomToolStripPanel.Controls.Add(this.bindingNavigator1);
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.AutoScroll = true;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.secaoDataGridView);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(259, 501);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(259, 551);
            this.toolStripContainer2.TabIndex = 3;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStrip3);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.secaoBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(256, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Adicionar novo";
            // 
            // secaoBindingSource
            // 
            this.secaoBindingSource.AllowNew = true;
            this.secaoBindingSource.DataMember = "FK_Secao_Licoes";
            this.secaoBindingSource.DataSource = this.licoesBindingSource;
            this.secaoBindingSource.Sort = "Numero_Secao DESC";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "de {0}";
            this.toolStripLabel2.ToolTipText = "Número total de itens";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Excluir";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover primeiro";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover próximo";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Salvar Dados";
            // 
            // secaoDataGridView
            // 
            this.secaoDataGridView.AutoGenerateColumns = false;
            this.secaoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.secaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.secaoDataGridView.DataSource = this.secaoBindingSource;
            this.secaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secaoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.secaoDataGridView.Name = "secaoDataGridView";
            this.secaoDataGridView.RowHeadersWidth = 24;
            this.secaoDataGridView.Size = new System.Drawing.Size(259, 501);
            this.secaoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numero_Secao";
            this.dataGridViewTextBoxColumn4.HeaderText = "# S";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 49;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Titulo_Secao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Título";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.txtBusca_Secoes});
            this.toolStrip3.Location = new System.Drawing.Point(3, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(205, 25);
            this.toolStrip3.TabIndex = 0;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel3.Text = "Busca:";
            // 
            // txtBusca_Secoes
            // 
            this.txtBusca_Secoes.Name = "txtBusca_Secoes";
            this.txtBusca_Secoes.Size = new System.Drawing.Size(150, 25);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(titulo_SecaoLabel);
            this.splitContainer4.Panel1.Controls.Add(this.titulo_SecaoTextBox);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl_Secao);
            this.splitContainer4.Size = new System.Drawing.Size(563, 551);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 0;
            // 
            // titulo_SecaoTextBox
            // 
            this.titulo_SecaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo_SecaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secaoBindingSource, "Titulo_Secao", true));
            this.titulo_SecaoTextBox.Location = new System.Drawing.Point(98, 3);
            this.titulo_SecaoTextBox.Name = "titulo_SecaoTextBox";
            this.titulo_SecaoTextBox.Size = new System.Drawing.Size(460, 20);
            this.titulo_SecaoTextBox.TabIndex = 1;
            // 
            // tabControl_Secao
            // 
            this.tabControl_Secao.Controls.Add(this.tabPage1);
            this.tabControl_Secao.Controls.Add(this.tabPage2);
            this.tabControl_Secao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Secao.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Secao.Name = "tabControl_Secao";
            this.tabControl_Secao.SelectedIndex = 0;
            this.tabControl_Secao.Size = new System.Drawing.Size(563, 522);
            this.tabControl_Secao.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Traduções (F7)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.toolStripContainer3);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.tabControl_Lista_Traducao);
            this.splitContainer5.Size = new System.Drawing.Size(549, 490);
            this.splitContainer5.SplitterDistance = 327;
            this.splitContainer5.TabIndex = 0;
            // 
            // toolStripContainer3
            // 
            // 
            // toolStripContainer3.BottomToolStripPanel
            // 
            this.toolStripContainer3.BottomToolStripPanel.Controls.Add(this.bindingNavigator2);
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.AutoScroll = true;
            this.toolStripContainer3.ContentPanel.Controls.Add(this.lista_de_TraducoesDataGridView);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(549, 277);
            this.toolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer3.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.Size = new System.Drawing.Size(549, 327);
            this.toolStripContainer3.TabIndex = 4;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.toolStrip4);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton8;
            this.bindingNavigator2.BindingSource = this.lista_de_TraducoesBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel4;
            this.bindingNavigator2.DeleteItem = this.toolStripButton9;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel4,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(280, 25);
            this.bindingNavigator2.TabIndex = 0;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Adicionar novo";
            // 
            // lista_de_TraducoesBindingSource
            // 
            this.lista_de_TraducoesBindingSource.AllowNew = true;
            this.lista_de_TraducoesBindingSource.DataMember = "FK_Lista_de_Traducoes_Secao";
            this.lista_de_TraducoesBindingSource.DataSource = this.secaoBindingSource;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel4.Text = "de {0}";
            this.toolStripLabel4.ToolTipText = "Número total de itens";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Excluir";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Mover primeiro";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Mover anterior";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Posição";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Mover próximo";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Mover último";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Salvar Dados";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton14_Click);
            // 
            // lista_de_TraducoesDataGridView
            // 
            this.lista_de_TraducoesDataGridView.AutoGenerateColumns = false;
            this.lista_de_TraducoesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lista_de_TraducoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista_de_TraducoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn9});
            this.lista_de_TraducoesDataGridView.DataSource = this.lista_de_TraducoesBindingSource;
            this.lista_de_TraducoesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lista_de_TraducoesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lista_de_TraducoesDataGridView.Name = "lista_de_TraducoesDataGridView";
            this.lista_de_TraducoesDataGridView.RowHeadersWidth = 24;
            this.lista_de_TraducoesDataGridView.Size = new System.Drawing.Size(549, 277);
            this.lista_de_TraducoesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Numero_Lista_de_Traducoes";
            this.dataGridViewTextBoxColumn6.HeaderText = "#";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 39;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ingles";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ingles";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Traducao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Traducao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fonetico";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fonetico";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 73;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Transliteracao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Transliteracao";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 99;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripTextBox3});
            this.toolStrip4.Location = new System.Drawing.Point(3, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(205, 25);
            this.toolStrip4.TabIndex = 0;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel5.Text = "Busca:";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(150, 25);
            // 
            // tabControl_Lista_Traducao
            // 
            this.tabControl_Lista_Traducao.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl_Lista_Traducao.Controls.Add(this.tabPage3);
            this.tabControl_Lista_Traducao.Controls.Add(this.tabPage4);
            this.tabControl_Lista_Traducao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Lista_Traducao.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Lista_Traducao.Name = "tabControl_Lista_Traducao";
            this.tabControl_Lista_Traducao.SelectedIndex = 0;
            this.tabControl_Lista_Traducao.Size = new System.Drawing.Size(549, 159);
            this.tabControl_Lista_Traducao.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(transliteracaoLabel);
            this.tabPage3.Controls.Add(this.transliteracaoTextBox);
            this.tabPage3.Controls.Add(foneticoLabel);
            this.tabPage3.Controls.Add(this.foneticoTextBox);
            this.tabPage3.Controls.Add(traducaoLabel);
            this.tabPage3.Controls.Add(this.traducaoTextBox);
            this.tabPage3.Controls.Add(inglesLabel);
            this.tabPage3.Controls.Add(this.inglesTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(541, 133);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Tradução (F9)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // transliteracaoTextBox
            // 
            this.transliteracaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transliteracaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lista_de_TraducoesBindingSource, "Transliteracao", true));
            this.transliteracaoTextBox.Location = new System.Drawing.Point(87, 84);
            this.transliteracaoTextBox.Name = "transliteracaoTextBox";
            this.transliteracaoTextBox.Size = new System.Drawing.Size(418, 20);
            this.transliteracaoTextBox.TabIndex = 7;
            // 
            // foneticoTextBox
            // 
            this.foneticoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foneticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lista_de_TraducoesBindingSource, "Fonetico", true));
            this.foneticoTextBox.Location = new System.Drawing.Point(87, 58);
            this.foneticoTextBox.Name = "foneticoTextBox";
            this.foneticoTextBox.Size = new System.Drawing.Size(418, 20);
            this.foneticoTextBox.TabIndex = 5;
            // 
            // traducaoTextBox
            // 
            this.traducaoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traducaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lista_de_TraducoesBindingSource, "Traducao", true));
            this.traducaoTextBox.Location = new System.Drawing.Point(87, 32);
            this.traducaoTextBox.Name = "traducaoTextBox";
            this.traducaoTextBox.Size = new System.Drawing.Size(418, 20);
            this.traducaoTextBox.TabIndex = 3;
            // 
            // inglesTextBox
            // 
            this.inglesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inglesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lista_de_TraducoesBindingSource, "Ingles", true));
            this.inglesTextBox.Location = new System.Drawing.Point(87, 6);
            this.inglesTextBox.Name = "inglesTextBox";
            this.inglesTextBox.Size = new System.Drawing.Size(418, 20);
            this.inglesTextBox.TabIndex = 1;
            this.inglesTextBox.TextChanged += new System.EventHandler(this.inglesTextBox_TextChanged);
            this.inglesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inglesTextBox_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.materia_PortuguesRichTextBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(541, 133);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Matéria da Tradução (F10)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materia_PortuguesRichTextBox2
            // 
            this.materia_PortuguesRichTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lista_de_TraducoesBindingSource, "Materia_Portugues", true));
            this.materia_PortuguesRichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materia_PortuguesRichTextBox2.Location = new System.Drawing.Point(3, 3);
            this.materia_PortuguesRichTextBox2.Name = "materia_PortuguesRichTextBox2";
            this.materia_PortuguesRichTextBox2.Size = new System.Drawing.Size(535, 127);
            this.materia_PortuguesRichTextBox2.TabIndex = 1;
            this.materia_PortuguesRichTextBox2.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(materia_PortuguesLabel1);
            this.tabPage2.Controls.Add(this.materia_PortuguesRichTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(555, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Matéria da Seção (F8)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materia_PortuguesRichTextBox1
            // 
            this.materia_PortuguesRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materia_PortuguesRichTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.secaoBindingSource, "Materia_Portugues", true));
            this.materia_PortuguesRichTextBox1.Location = new System.Drawing.Point(6, 23);
            this.materia_PortuguesRichTextBox1.Name = "materia_PortuguesRichTextBox1";
            this.materia_PortuguesRichTextBox1.Size = new System.Drawing.Size(543, 467);
            this.materia_PortuguesRichTextBox1.TabIndex = 1;
            this.materia_PortuguesRichTextBox1.Text = "";
            // 
            // tabMateria_Licao
            // 
            this.tabMateria_Licao.Controls.Add(materia_PortuguesLabel);
            this.tabMateria_Licao.Controls.Add(this.materia_PortuguesRichTextBox);
            this.tabMateria_Licao.Location = new System.Drawing.Point(4, 22);
            this.tabMateria_Licao.Name = "tabMateria_Licao";
            this.tabMateria_Licao.Padding = new System.Windows.Forms.Padding(3);
            this.tabMateria_Licao.Size = new System.Drawing.Size(832, 557);
            this.tabMateria_Licao.TabIndex = 0;
            this.tabMateria_Licao.Text = "Matéria da Lição (F6)";
            this.tabMateria_Licao.UseVisualStyleBackColor = true;
            // 
            // materia_PortuguesRichTextBox
            // 
            this.materia_PortuguesRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materia_PortuguesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.licoesBindingSource, "Materia_Portugues", true));
            this.materia_PortuguesRichTextBox.Location = new System.Drawing.Point(11, 19);
            this.materia_PortuguesRichTextBox.Name = "materia_PortuguesRichTextBox";
            this.materia_PortuguesRichTextBox.Size = new System.Drawing.Size(839, 532);
            this.materia_PortuguesRichTextBox.TabIndex = 1;
            this.materia_PortuguesRichTextBox.Text = "";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(592, 301);
            // 
            // frm01_Licoes_Secoes_ListaTraducoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.KeyPreview = true;
            this.Name = "frm01_Licoes_Secoes_ListaTraducoes";
            this.Text = "Inglês sem Mestre - Lições -> Seções -> Lista de Traduções";
            this.Load += new System.EventHandler(this.frm01_Licoes_Secoes_ListaTraducoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm01_Licoes_Secoes_ListaTraducoes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.iNGLES_SEM_MESTREDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoesBindingNavigator)).EndInit();
            this.licoesBindingNavigator.ResumeLayout(false);
            this.licoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licoesDataGridView)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl_Licao.ResumeLayout(false);
            this.tabSecoes.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStripContainer2.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secaoDataGridView)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl_Secao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.toolStripContainer3.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista_de_TraducoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lista_de_TraducoesDataGridView)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.tabControl_Lista_Traducao.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabMateria_Licao.ResumeLayout(false);
            this.tabMateria_Licao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INGLES_SEM_MESTREDataSet iNGLES_SEM_MESTREDataSet;
        private System.Windows.Forms.BindingSource licoesBindingSource;
        private INGLES_SEM_MESTREDataSetTableAdapters.LicoesTableAdapter licoesTableAdapter;
        private INGLES_SEM_MESTREDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator licoesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton licoesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView licoesDataGridView;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBusca_Licoes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TabControl tabControl_Licao;
        private System.Windows.Forms.TabPage tabMateria_Licao;
        private System.Windows.Forms.RichTextBox materia_PortuguesRichTextBox;
        private System.Windows.Forms.TabPage tabSecoes;
        private System.Windows.Forms.ToolStripButton btnSalvar_Alteracoes;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtBusca_Secoes;
        private INGLES_SEM_MESTREDataSetTableAdapters.SecaoTableAdapter secaoTableAdapter;
        private System.Windows.Forms.BindingSource secaoBindingSource;
        private System.Windows.Forms.DataGridView secaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TextBox titulo_SecaoTextBox;
        private System.Windows.Forms.TabControl tabControl_Secao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox materia_PortuguesRichTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.BindingSource lista_de_TraducoesBindingSource;
        private INGLES_SEM_MESTREDataSetTableAdapters.Lista_de_TraducoesTableAdapter lista_de_TraducoesTableAdapter;
        private System.Windows.Forms.DataGridView lista_de_TraducoesDataGridView;
        private System.Windows.Forms.TabControl tabControl_Lista_Traducao;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox transliteracaoTextBox;
        private System.Windows.Forms.TextBox foneticoTextBox;
        private System.Windows.Forms.TextBox traducaoTextBox;
        private System.Windows.Forms.TextBox inglesTextBox;
        private System.Windows.Forms.RichTextBox materia_PortuguesRichTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}