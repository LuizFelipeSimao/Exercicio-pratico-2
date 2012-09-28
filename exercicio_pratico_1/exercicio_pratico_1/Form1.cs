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
        //CRIAÇÃO DE ESTRUTURAS DE DADOS UTILIZADOS NESSE PROJETO
        //O DICIONARIO ARMAZENARÁ LISTA DE FILMES, CADA POSIÇÃO CORRESPONDE À UM GENERO DE FILME
        Dictionary<int, List<Filme>> dicionario_filmes = new Dictionary<int, List<Filme>>();
        //A LISTA ARMAZENARÁ OS FILME DE DETERMINADO GENERO
        List<Filme> lista_pesquisa = new List<Filme>();
       
        public Form1()
        {
            InitializeComponent();
        }

        //ESSE METODO SERÁ UTILIZADO PARA LIMPAR TODOS OS COMBOBOX, CHECKBOX, TEXTBOX E LISTVIEW DO TABCONTROL 2
        public void botao_limpar()
        {
            ck_box_categoria.Checked = false;
            ck_box_data.Checked = false;
            ck_box_local.Checked = false;
            ck_box_nome.Checked = false;
            listView2.Items.Clear();
            pesq_nome.Clear();
            pesq_local.Clear();
            data_final.Text = null;
            data_inicial.Text = null;
            pesq_categoria.SelectedItem = null;
            lista_pesquisa.Clear();
            pesquisa.Enabled = true;
            limpar_pesquisa.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Ligando os Grupos do ListVIew aos valores do Combobox
            lista_genero.DataSource = listView1.Groups;
            pesq_categoria.DataSource = listView2.Groups;
        }






        //-------------Tab control para cadastro de filmes----------------------------//

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            //armazenando os valor digitados pelo usuario no objeto da classe Filme
            filme.Nome = nome_filme.Text;
            filme.Genero = lista_genero.SelectedItem.ToString();
            filme.Data_Assistido = data.Value;
            filme.Local = local.Text;
            
            /*essa condição verifica se a lista do genero do filme existe, se sim o filme só será adicionado a lista,
            se não será criada uma nova lista no dicionario e o filme adicionado nela*/
            if (dicionario_filmes.ContainsKey(lista_genero.SelectedIndex))
            {
                List<Filme> l = dicionario_filmes[lista_genero.SelectedIndex];
                l.Add(filme);
            }
            else
            {
                List<Filme> lista_filme = new List<Filme>();
                lista_filme.Add(filme);
                dicionario_filmes.Add(lista_genero.SelectedIndex, lista_filme);
            }

            //agora os valore são adicionado ao listview, utilizando como base os valores do objeto Filme
            ListViewItem novo_item = new ListViewItem();
            novo_item.Text = filme.Nome;
            novo_item.Group = listView1.Groups[lista_genero.SelectedIndex];
            novo_item.SubItems.Add(filme.Data_Assistido.ToShortDateString());
            novo_item.SubItems.Add(filme.Local);
            listView1.Items.Add(novo_item);
        }

        //evento para remover filmes da lista
        private void remover_Click(object sender, EventArgs e)
        {
            //atribui a variavel auxiliar o valor do indice do grupo selecionado no listview
            int auxiliar = listView1.Groups.IndexOf(listView1.SelectedItems[0].Group);
            
            //atribui a variavel comparacao o valor(text) do item selecionado no listview
            string comparacao = listView1.SelectedItems[0].Text;
            
            //Criando uma referencia à uma lista no dicionario
            List<Filme> lista = dicionario_filmes[auxiliar];
            
            //o FOR é utilizado para percorrer a lista, caso o filme desejado seja encontrado, o mesmo será removido do listview e da lista
            for(int i = 0; i< lista.Count; ++i)
            {
                //cria uma referencia ao objeto Filme na lista
                Filme l = lista[i];
                
                //verifica se o nome do objeto na lista é igual ao nome do item do listview
                if (l.Nome == comparacao)
                {   
                    //remove o item da lista e do listview
                    lista.Remove(l);
                    listView1.SelectedItems[0].Remove();
                }
            }

        }

        //evento para editar um filme na lista
        private void editar_Click(object sender, EventArgs e)
        {
            //atribui a variavel auxiliar o valor do indice do grupo selecionado no listview
            int auxiliar = listView1.Groups.IndexOf(listView1.SelectedItems[0].Group);
            
            //atribui a variavel comparacao o valor do item selecionado no listview
            string comparacao = listView1.SelectedItems[0].Text;
            
            //Criando uma referencia à uma lista no dicionario
            List<Filme> lista = dicionario_filmes[auxiliar];

            /*o FOR é utilizado para percorrer a lista, caso o filme desejado seja encontrado, o mesmo poderá ser editado e depois salvo na lista
            ou adicionado a uma nova lista(caso o genero seja alterado) e removido da lista original*/
            for (int i = 0; i < lista.Count; ++i)
            {
                //cria uma referencia ao objeto Filme na lista
                Filme l = lista[i];
                
                //verifica se o nome do objeto na lista é igual ao nome do item do listview
                if (l.Nome == comparacao)
                {
                    //grava no objeto os valores dos textbox
                    l.Nome = nome_filme.Text;
                    l.Genero = lista_genero.Text;
                    l.Data_Assistido = data.Value;
                    l.Local = local.Text;
                    
                    /*verifica se a lista onde o filme alterado vai ser inserido ja existe
                    se sim é criado uma nova referencia para aquele objeto e a referencia antiga é desfeita
                    senão é criada uma nova lista onde o filme será salvo*/
                    if (dicionario_filmes.ContainsKey(lista_genero.SelectedIndex))
                    {
                        List<Filme> listaexistente = dicionario_filmes[lista_genero.SelectedIndex];
                        listaexistente.Add(l);
                    }
                    else
                    {
                        List<Filme> lista_filme = new List<Filme>();
                        lista_filme.Add(l);
                        dicionario_filmes.Add(lista_genero.SelectedIndex, lista_filme);
                    }
                    lista.Remove(l);
                    
                    //atualiza o list view com os novos valores
                    ListViewItem lv_editando = listView1.SelectedItems[0];
                    lv_editando.Group = listView1.Groups[lista_genero.SelectedIndex];
                    lv_editando.SubItems[0].Text = l.Nome;
                    lv_editando.SubItems[1].Text = l.Data_Assistido.ToShortDateString();
                    lv_editando.SubItems[2].Text = l.Local;
                }
            }

            /* ao dar dois cliques em um item do listview os botões de cadastro, listview e de remoção são travados,
            agora esses botões são liberados para que o usuario possa continuar trabalhando, 
            o botão de edição é travado novamente para que nada possa ser alterado por engano*/
            cadastrar.Enabled = true;
            remover.Enabled = true;
            editar.Enabled = false;
            listView1.Enabled = true;
        }


        /*evento de dois cliques no listview é utilizado para travar a seleção do listview, travar a utilização dos botões de
        cadastro e remoção, impedindo que o usuario cometa algum erro durante a edição*/
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            cadastrar.Enabled = false;
            remover.Enabled = false;
            editar.Enabled = true;
            listView1.Enabled = false;
        }




        //------------------------tabcontrol para pesquisa-------------------------//
     
        /*quando o botão de pesquisa é disparado, a lista de pesquisa é atribuida com os valores dos filmes armazenados no dicionario
        para agilizar a pesquisa, caso o checkbox de genero esteja marcado, a lista de pesquisa será atribuida com os valores
         da lista contida na posição do dicionario equivalente ao genero selecionado*/
        private void pesquisa_Click(object sender, EventArgs e)
        {
            //verifica se o checkbox do genero está marcado
            if (ck_box_categoria.Checked == true)
            {
                //verifica se a lista desejada contem no dicionario
                if (dicionario_filmes.ContainsKey(pesq_categoria.SelectedIndex))
                {
                    //atribui os valores do dicionario na lista de pesquisa
                    int auxiliar = pesq_categoria.SelectedIndex;
                    List<Filme> lista = dicionario_filmes[auxiliar];
                    lista_pesquisa.AddRange(lista);
                }
                else
                {   
                    //essa mensagem será apresentada caso não tenha um filme cadastrado pra tal genero
                    MessageBox.Show("Não existe filme para tal genero", "Atenção", MessageBoxButtons.OK);
                }
            }
            else
            {
                //atribuição da lista de pesquisa com os valores do dicionario completo
                foreach (List<Filme> l in dicionario_filmes.Values)
                    lista_pesquisa.AddRange(l);
            }
            
            //verifica se a lista de pesquisa não está vazia
            if (lista_pesquisa.Count == 0)
            {
                MessageBox.Show("Não foi cadastrado nenhum filme", "Atenção", MessageBoxButtons.OK);
            }
            else
            {

            //o FOR é utilizado para percorrer toda a lista de pesquisa
            for (int i = 0; i < lista_pesquisa.Count; ++i)
                {     
                        Filme obj_pesquisa = lista_pesquisa[i];
                        
                        /*nessa condição é verificado se o checkbox de nome esta ativo e se o nome no textbox é diferente aos objetos da lista
                        caso algum objeto coresponda a essas condições ele será removido da lista de pesquisa
                         obs: não importa se o usuario entrou com letras maiusculas ou minusculas*/
                        if ((ck_box_nome.Checked == true) && (obj_pesquisa.Nome.ToUpper() != pesq_nome.Text.ToUpper()))
                        {
                            lista_pesquisa.Remove(obj_pesquisa);
                            i--;
                        }
                        
                        /*nessa condição é verificado se o checkbox de data esta ativo e se a data em que o filme foi assistido está
                        fora do intervalo fornecido pelo usuario,
                        caso algum objeto coresponda a essas condições ele será removido da lista de pesquisa*/
                        if ((ck_box_data.Checked == true) && ((obj_pesquisa.Data_Assistido.Date > data_inicial.Value) && (obj_pesquisa.Data_Assistido.Date > data_final.Value)))
                        {
                            lista_pesquisa.Remove(obj_pesquisa);
                            i--;
                        }

                        /*nessa condição é verificado se o checkbox de local esta ativo e se o local no textbox é diferente aos objetos da lista
                        caso algum objeto coresponda a essas condições ele será removido da lista de pesquisa
                         obs: não importa se o usuario entrou com letras maiusculas ou minusculas*/
                        if ((ck_box_local.Checked == true) && (obj_pesquisa.Local.ToUpper() != pesq_local.Text.ToUpper()))
                        {
                            lista_pesquisa.Remove(obj_pesquisa);
                            i--;
                        }
                    }
                }
            
            //a lista de pesquisa é apresentada no listview
            foreach(Filme obj_apresentacao in lista_pesquisa)
            {  
                ListViewItem listview_pesquisa = new ListViewItem();
                listview_pesquisa.Group = listView2.Groups[obj_apresentacao.Genero];
                listview_pesquisa.Text = obj_apresentacao.Nome;
                listview_pesquisa.SubItems.Add(obj_apresentacao.Data_Assistido.ToShortDateString());
                listview_pesquisa.SubItems.Add(obj_apresentacao.Local);
                listView2.Items.Add(listview_pesquisa);
            }

            /*o botão de pesuisa é travado para forçar o usuario a limpar os parametros de pesquisa e o botão limpar é liberado*/
            pesquisa.Enabled = false;
            limpar_pesquisa.Enabled = true;
         }


        //esse evento limpa dos os item
        private void limpar_pesquisa_Click(object sender, EventArgs e)
        {
            botao_limpar();
        }
     }
}