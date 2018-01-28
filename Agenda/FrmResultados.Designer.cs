namespace Agenda
{
    partial class FrmResultados
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_nova_pesquisa = new System.Windows.Forms.Button();
            this.lista_Pesquisa = new System.Windows.Forms.ListBox();
            this.label_numero_registro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(301, 203);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_nova_pesquisa
            // 
            this.btn_nova_pesquisa.Location = new System.Drawing.Point(170, 203);
            this.btn_nova_pesquisa.Name = "btn_nova_pesquisa";
            this.btn_nova_pesquisa.Size = new System.Drawing.Size(125, 23);
            this.btn_nova_pesquisa.TabIndex = 1;
            this.btn_nova_pesquisa.Text = "Nova Pesquisa ...";
            this.btn_nova_pesquisa.UseVisualStyleBackColor = true;
            this.btn_nova_pesquisa.Click += new System.EventHandler(this.btn_nova_pesquisa_Click);
            // 
            // lista_Pesquisa
            // 
            this.lista_Pesquisa.FormattingEnabled = true;
            this.lista_Pesquisa.Location = new System.Drawing.Point(12, 24);
            this.lista_Pesquisa.Name = "lista_Pesquisa";
            this.lista_Pesquisa.Size = new System.Drawing.Size(364, 173);
            this.lista_Pesquisa.TabIndex = 2;
            this.lista_Pesquisa.SelectedIndexChanged += new System.EventHandler(this.lista_Pesquisa_SelectedIndexChanged);
            // 
            // label_numero_registro
            // 
            this.label_numero_registro.Location = new System.Drawing.Point(12, 206);
            this.label_numero_registro.Name = "label_numero_registro";
            this.label_numero_registro.Size = new System.Drawing.Size(146, 20);
            this.label_numero_registro.TabIndex = 11;
            this.label_numero_registro.Text = "Registro :0";
            this.label_numero_registro.Click += new System.EventHandler(this.label_numero_registro_Click);
            // 
            // FrmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 242);
            this.ControlBox = false;
            this.Controls.Add(this.label_numero_registro);
            this.Controls.Add(this.lista_Pesquisa);
            this.Controls.Add(this.btn_nova_pesquisa);
            this.Controls.Add(this.btn_fechar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.FrmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_nova_pesquisa;
        private System.Windows.Forms.ListBox lista_Pesquisa;
        private System.Windows.Forms.Label label_numero_registro;
    }
}