namespace Ingles_Sem_Mestre
{
    partial class frm00_Principal
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLicoes_Secoes_ListaTraducao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLicoes_Secoes_ListaTraducao);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(898, 587);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnLicoes_Secoes_ListaTraducao
            // 
            this.btnLicoes_Secoes_ListaTraducao.Image = global::Ingles_Sem_Mestre.Properties.Resources.Licoes;
            this.btnLicoes_Secoes_ListaTraducao.Location = new System.Drawing.Point(3, 3);
            this.btnLicoes_Secoes_ListaTraducao.Name = "btnLicoes_Secoes_ListaTraducao";
            this.btnLicoes_Secoes_ListaTraducao.Size = new System.Drawing.Size(211, 110);
            this.btnLicoes_Secoes_ListaTraducao.TabIndex = 0;
            this.btnLicoes_Secoes_ListaTraducao.Text = "Lições -> Seções -> Lista de Tradução";
            this.btnLicoes_Secoes_ListaTraducao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLicoes_Secoes_ListaTraducao.UseVisualStyleBackColor = true;
            this.btnLicoes_Secoes_ListaTraducao.Click += new System.EventHandler(this.btnLicoes_Secoes_ListaTraducao_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "Testes e outros...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm00_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 587);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frm00_Principal";
            this.Text = "Inglês Sem Mestre - Principal";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLicoes_Secoes_ListaTraducao;
        private System.Windows.Forms.Button button1;
    }
}