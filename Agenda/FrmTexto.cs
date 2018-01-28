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
    public partial class FrmTexto : Form
    {

        public bool Cancelado { get; set; }
        public string Texto { get; set; }
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cançela o quadro

            Cancelado = true;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTexto_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (text_pesquisa.Text == "") return;
           Texto = text_pesquisa.Text;
            Cancelado = false;
            this.Close();
           
           
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
