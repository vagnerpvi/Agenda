using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            Cl_Geral.ConstroiListaContatos();



            labelVersao.Text = Cl_Geral.versao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair da Aplicação?", "Sair",

                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //abrir quadro de pesquisa
            FrmTexto f = new FrmTexto();
            f.ShowDialog();


            //quando fecha o quadro verifica se foi cancelado
            if (f.Cancelado) return;

         

            //abrir quadro de resultado da pesquisa
            FrmResultados ff = new FrmResultados(f.Texto);
                ff.ShowDialog();
        }
    }
}
