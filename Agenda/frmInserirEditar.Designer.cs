namespace Agenda
{
    partial class frmInserirEditar
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label_lista = new System.Windows.Forms.Label();
            this.label_numero_registro = new System.Windows.Forms.Label();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(398, 381);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(75, 23);
            this.cmd_fechar.TabIndex = 3;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_nome
            // 
            this.label_nome.Location = new System.Drawing.Point(12, 10);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(61, 20);
            this.label_nome.TabIndex = 6;
            this.label_nome.Text = "Nome:";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(79, 7);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(322, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(79, 58);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(147, 20);
            this.text_numero.TabIndex = 1;
            // 
            // label_numero
            // 
            this.label_numero.Location = new System.Drawing.Point(12, 61);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(61, 20);
            this.label_numero.TabIndex = 7;
            this.label_numero.Text = "Numero:";
            this.label_numero.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(79, 84);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(89, 23);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(12, 150);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(448, 225);
            this.lista_contatos.TabIndex = 9;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label_lista
            // 
            this.label_lista.Location = new System.Drawing.Point(12, 130);
            this.label_lista.Name = "label_lista";
            this.label_lista.Size = new System.Drawing.Size(229, 17);
            this.label_lista.TabIndex = 8;
            this.label_lista.Text = "Lista de contatos registrados:";
            // 
            // label_numero_registro
            // 
            this.label_numero_registro.Location = new System.Drawing.Point(22, 386);
            this.label_numero_registro.Name = "label_numero_registro";
            this.label_numero_registro.Size = new System.Drawing.Size(146, 20);
            this.label_numero_registro.TabIndex = 10;
            this.label_numero_registro.Text = "Registro :0";
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(227, 381);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(75, 23);
            this.cmd_editar.TabIndex = 5;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(317, 381);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(75, 23);
            this.cmd_apagar.TabIndex = 4;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 423);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.label_numero_registro);
            this.Controls.Add(this.label_lista);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.Text = "Agenda-Inserir/Editar";
            this.Load += new System.EventHandler(this.frmInserirEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label_numero;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label_lista;
        private System.Windows.Forms.Label label_numero_registro;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_apagar;
    }
}