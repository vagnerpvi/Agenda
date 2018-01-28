using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Agenda
{
   public static class Cl_Geral
    {

  

        public static string versao = " V 1.0.0";

       
        //lista de contatos
        //====================================================
        public static List<Cl_Contatos> LISTA_CONTACTOS;
        //====================================================
        public static void ConstroiListaContatos()
        {

            //verifica se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string nome_ficheiro = pasta_documentos + @"\arquivo_contatos_agenda.txt";

            LISTA_CONTACTOS = new List<Cl_Contatos>();


            if (File.Exists(nome_ficheiro))
            {
                Cl_Geral.Existe();
                   //tem que criar um ficheiro

         
             StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                

                while (!ficheiro.EndOfStream)
                {

                    // carega nome
                    string nome = ficheiro.ReadLine();
                    // carrega numero
                    string numero = ficheiro.ReadLine();

                    /// adiciona a lista de contatos os contatos carregados
                    Cl_Contatos novo_contato = new Cl_Contatos();
                    
                        novo_contato.Nome = nome;
                        novo_contato.Numero = numero;
                    

                    LISTA_CONTACTOS.Add(novo_contato);
                }
                ficheiro.Dispose();
            }
        
        }
        //====================================================
        public static void GravarNovoRegistro(string _nome,string _numero)
        {
            //gravar um novo registro(na lista de ficheiros)



            // esta é uma possivel forma de se fazer
            Cl_Contatos novo = new Cl_Contatos();
            
                novo.Nome = _nome;
                novo.Numero = _numero;
           
                LISTA_CONTACTOS.Add(novo);

            //ou esta.

           // LISTA_CONTACTOS.Add(new Cl_Contatos() { Nome = _nome, Numero = _numero });

            GravarFicheiro();
        }
        //====================================================
        public static void GravarFicheiro()
        {

            //string pasta_documentos = @"D:\";
            //string nome_ficheiro = pasta_documentos + "arquivo_contatos.txt";
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string nome_ficheiro = pasta_documentos + @"\arquivo_contatos_agenda.txt";


            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false ,Encoding.Default);

            foreach (Cl_Contatos contacto in LISTA_CONTACTOS)

            {

                ficheiro.WriteLine(contacto.Nome);

                ficheiro.WriteLine(contacto.Numero);
            }

            ficheiro.Dispose();
        }
        //====================================================
        public static void Existe()

        {
            MessageBox.Show("Nao existe arquivo!!!");


        }
        //====================================================
    }
}

