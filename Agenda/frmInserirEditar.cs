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
    public partial class frmInserirEditar : Form

    {
        int indice; 

        public frmInserirEditar()
        {
            InitializeComponent();
          
            ConstroiLista();
        }
        //=============================================================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=============================================================================
        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }
        //=============================================================================
        private void ConstroiLista()

        {
            //adiciona a ista de contatos registrados
            lista_contatos.Items.Clear();

            foreach (Cl_Contatos contacto in Cl_Geral.LISTA_CONTACTOS)
            {
             lista_contatos.Items.Add(contacto.Nome+"("+contacto.Numero+")");
            }


            label_numero_registro.Text = "registros:" + lista_contatos.Items.Count;

            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;
        }
        //=============================================================================
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
                //INSERE UM NOVO ELEMENTO NA LISTA
            // VERIFICA SE TODOS OS CAMPOS ESTAO PREENCHIDOS

            
            if (text_nome.Text == "" || text_numero.Text == "")

              {
                MessageBox.Show("Os Campos não estão todos preenchidos");
                    
                    
                return;

                }

            foreach (Cl_Contatos contatos_list in Cl_Geral.LISTA_CONTACTOS)

               {
                if (contatos_list.Nome == text_nome.Text &&
                   contatos_list.Numero == text_numero.Text)
                {
                    MessageBox.Show( "ERRO!!!esse Registro já existe.");
                    return;
             }

          }

            //gravar
            Cl_Geral.GravarNovoRegistro(text_nome.Text, text_numero.Text);

            //atualiza lista

            ConstroiLista();

            // prepara  o campo para um novo registro!!
            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();

        }
        //=============================================================================
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selecionar o contato

           // MessageBox.Show(lista_contatos.SelectedIndex.ToString(),"Index Selecionado");

            if (lista_contatos.SelectedIndex == -1) return;

            indice = lista_contatos.SelectedIndex;

            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }
        //=============================================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            // apaga o registro selecionado
            Cl_Geral.LISTA_CONTACTOS.RemoveAt(indice);

            // renova o ficheiro
            Cl_Geral.GravarFicheiro();

            //reconstroi a lista

            ConstroiLista();
        }
    }
}
