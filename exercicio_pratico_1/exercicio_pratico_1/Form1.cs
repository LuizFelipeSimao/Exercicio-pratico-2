using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercicio_pratico_1
{
    //criação de classe que servirá de base para os filmes
    public class Filme
    {
        string Nome;
        string Genero;
        string Data_Assistido;
        string Local;
        //construtor da classe Filmes - inicia todas os atributos vazios
        public Filme()
        {
            Nome = "";
            Genero = "";
            Data_Assistido = "";
            Local = "";
        }
    }

    public partial class Form1 : Form
    {
        //inicializa o Form principal
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciando o objeto filme apartir da classe Filmes
            Filme filmes = new Filme();
            //Criando um vetor dinamico da Classe Filme
            List<Filme> lista_filmes = new List<Filme>();
        }
    }
}
