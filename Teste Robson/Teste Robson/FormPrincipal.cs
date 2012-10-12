#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
#endregion

namespace Teste_Robson
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Botões

        /// <summary>
        /// Abri uma janela de dialogo do windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDialogo_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBoxDiretorio.Text = folderBrowserDialog.SelectedPath;

            textBoxExtensao.Focus();
        }

        /// <summary>
        /// Inicia todo o processo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Executa as validações de interface
            if (Valida())
            {
                LimpaObjetos();
                Busca();
            }
        }

        #endregion      
 
        #region Busca

        private void Busca()
        {
            ListViewItem item;

            // Obtém as informações do diretório informado
            DirectoryInfo directoryInfo = new DirectoryInfo(@textBoxDiretorio.Text);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*" + textBoxExtensao.Text);


            progressBar.Maximum = fileInfo.Count();

            // Obtém as informações dos arquivos
            for (int i = 0; i < fileInfo.Count(); i++)
            {
                item = new ListViewItem();

                item.Text = fileInfo[i].Name;
                item.SubItems.Add(fileInfo[i].Length.ToString());

                listViewResultado.Items.Add(item);

                listViewResultado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                progressBar.Value++;
            }
        }

        #endregion

        #region Interface

        /// <summary>
        /// Validações da interface
        /// </summary>
        /// <returns> Boleano </returns>
        private bool Valida()
        {
            // Verifica se o diretório existe
            if (Directory.Exists(@textBoxDiretorio.Text))
            {
                if (textBoxExtensao.Text == "")
                {
                    MessageBox.Show("Informe uma extensão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Diretório inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Limpa objetos
        /// </summary>
        private void LimpaObjetos()
        {
            progressBar.Value = 0;
            listViewResultado.Items.Clear();
        }

        #endregion
    }
}
