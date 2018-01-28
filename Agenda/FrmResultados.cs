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
    public partial class FrmResultados : Form
    {
        string texto;


        public FrmResultados(string texto)
        {
            InitializeComponent();
           // definir o texto da pesquisa
            this.texto = texto.ToUpper();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //========================================================
            // pedir novo texto

            FrmTexto f = new FrmTexto();
            f.ShowDialog();

            // quando o quadro é fechado...

            if (f.Cancelado) return;

            texto = f.Texto.ToUpper();

            ExecutaPesquisa();
        }
        
           
        
        //========================================================
        private void FrmResultados_Load(object sender, EventArgs e)
        {
            ExecutaPesquisa();
        }

                private void ExecutaPesquisa() {


   

        List<Cl_Contatos> listaResultados
                    = new List<Cl_Contatos>();

        foreach (Cl_Contatos contacto in Cl_Geral.LISTA_CONTACTOS)

        {

            if (contacto.Nome.ToUpper().Contains(texto) ||
               contacto.Nome.ToUpper().Contains(texto))
            {
                listaResultados.Add(contacto);

            }
            lista_Pesquisa.Items.Clear();


        }
        foreach (Cl_Contatos contacto in listaResultados)


            lista_Pesquisa.Items.Add(contacto.Nome +
                "(" + contacto.Numero);

        label_numero_registro.Text =
        "Registros :" + lista_Pesquisa.Items.Count;

    }



    private void label_numero_registro_Click(object sender, EventArgs e)
        {

        }

        private void lista_Pesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
}
     }