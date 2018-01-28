namespace Agenda
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_inserir = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.labelVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda";
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(125, 171);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(207, 66);
            this.cmd_pesquisar.TabIndex = 1;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_inserir
            // 
            this.cmd_inserir.Location = new System.Drawing.Point(125, 75);
            this.cmd_inserir.Name = "cmd_inserir";
            this.cmd_inserir.Size = new System.Drawing.Size(207, 66);
            this.cmd_inserir.TabIndex = 2;
            this.cmd_inserir.Text = "Inserir/Editar";
            this.cmd_inserir.UseVisualStyleBackColor = true;
            this.cmd_inserir.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(125, 267);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(207, 66);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelVersao
            // 
            this.labelVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersao.Location = new System.Drawing.Point(136, 354);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(196, 23);
            this.labelVersao.TabIndex = 4;
            this.labelVersao.Text = "Apresenta a Versão do programa";
            this.labelVersao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(459, 386);
            this.Controls.Add(this.labelVersao);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_inserir);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_inserir;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label labelVersao;
    }
}

