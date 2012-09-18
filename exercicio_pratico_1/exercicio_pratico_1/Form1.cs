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

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            //instanciando o objeto filme apartir da classe Filmes
            Filme filme = new Filme();
            //Criando um vetor dinamico da Classe Filme
            Dictionary<string, Filme> dicionario_filmes = new Dictionary<string, Filme>();
            //armazenando os valor digitados pelo usuario na classe
            filme.Nome = nome_filme.Text;
            filme.Genero = lista_genero.SelectedItem.ToString();
            filme.Data_Assistido = data.Text;
            filme.Local = local.Text;
            //armazenando a classe no dicionario
            dicionario_filmes.Add(nome_filme.Text, filme);
            //colocando os valore no list view
            
        }

    }
}
