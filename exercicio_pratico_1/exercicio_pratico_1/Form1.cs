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
        //Criando um alista de classe de filme
        List<Filme> lista_filme = new List<Filme>();
        //Criando um vetor dinamico da Classe Filme
        Dictionary<int, List<Filme>> dicionario_filmes = new Dictionary<int, List<Filme>>();
        //instanciando o objeto filme apartir da classe Filmes
        Filme filme = new Filme();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ligando os Grupos do ListVIew aos valores do Combobox
            lista_genero.DataSource = listView1.Groups;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {          
            //armazenando os valor digitados pelo usuario na classe
            filme.Nome = nome_filme.Text;
            filme.Genero = lista_genero.SelectedItem.ToString();
            filme.Data_Assistido = data.Text;
            filme.Local = local.Text;
            //armazenando a classe na lista
            lista_filme.Add(filme);
            //armazenando a lista de filmes de um mesmo genero no dicionario
            dicionario_filmes.Add(lista_genero.SelectedIndex, lista_filme);
            //criando um item para listview
            ListViewItem novo_item = new ListViewItem();
            novo_item.Text = filme.Nome;
            novo_item.Group = listView1.Groups[lista_genero.SelectedIndex];
            novo_item.SubItems.Add(filme.Data_Assistido);
            novo_item.SubItems.Add(filme.Local);
            //adicionando o item no listview de apresentação
            listView1.Items.Add(novo_item);
        }

        private void remover_Click(object sender, EventArgs e)
        {
            //string auxiliar = listView1.SelectedItems.ToString();
            //int genero = listView1;
            //lista_filme.Remove();
            //listView1.SelectedItems[0].Remove();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            foreach ()) ;
           
        }
    }
}
