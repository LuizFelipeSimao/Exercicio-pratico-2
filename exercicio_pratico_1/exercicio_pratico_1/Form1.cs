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
