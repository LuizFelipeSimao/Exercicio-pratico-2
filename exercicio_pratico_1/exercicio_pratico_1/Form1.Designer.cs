namespace exercicio_pratico_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup31 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup32 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup33 = new System.Windows.Forms.ListViewGroup("Drama", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup34 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup35 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup36 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup37 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup38 = new System.Windows.Forms.ListViewGroup("Documetário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup39 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup40 = new System.Windows.Forms.ListViewGroup("Ficção-Científica", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup21 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup22 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup23 = new System.Windows.Forms.ListViewGroup("Drama", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup24 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup25 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup26 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup27 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("Documetário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Ficção-Científica", System.Windows.Forms.HorizontalAlignment.Left);
            this.Cad_filme = new System.Windows.Forms.TabControl();
            this.cadastro_filme = new System.Windows.Forms.TabPage();
            this.remover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.local = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lista_genero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nome_filme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.Consulta_filme = new System.Windows.Forms.TabPage();
            this.limpar_pesquisa = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pesquisa = new System.Windows.Forms.Button();
            this.pesq_local = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data_final = new System.Windows.Forms.DateTimePicker();
            this.data_inicial = new System.Windows.Forms.DateTimePicker();
            this.pesq_categoria = new System.Windows.Forms.ComboBox();
            this.ck_box_local = new System.Windows.Forms.CheckBox();
            this.ck_box_data = new System.Windows.Forms.CheckBox();
            this.ck_box_categoria = new System.Windows.Forms.CheckBox();
            this.ck_box_nome = new System.Windows.Forms.CheckBox();
            this.pesq_nome = new System.Windows.Forms.TextBox();
            this.Cad_filme.SuspendLayout();
            this.cadastro_filme.SuspendLayout();
            this.Consulta_filme.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cad_filme
            // 
            this.Cad_filme.Controls.Add(this.cadastro_filme);
            this.Cad_filme.Controls.Add(this.Consulta_filme);
            this.Cad_filme.Location = new System.Drawing.Point(10, 6);
            this.Cad_filme.Name = "Cad_filme";
            this.Cad_filme.SelectedIndex = 0;
            this.Cad_filme.Size = new System.Drawing.Size(835, 436);
            this.Cad_filme.TabIndex = 0;
            // 
            // cadastro_filme
            // 
            this.cadastro_filme.BackgroundImage = global::exercicio_pratico_1.Properties.Resources.filme_com_pipoca;
            this.cadastro_filme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cadastro_filme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadastro_filme.Controls.Add(this.remover);
            this.cadastro_filme.Controls.Add(this.listView1);
            this.cadastro_filme.Controls.Add(this.local);
            this.cadastro_filme.Controls.Add(this.label4);
            this.cadastro_filme.Controls.Add(this.data);
            this.cadastro_filme.Controls.Add(this.label3);
            this.cadastro_filme.Controls.Add(this.lista_genero);
            this.cadastro_filme.Controls.Add(this.label2);
            this.cadastro_filme.Controls.Add(this.nome_filme);
            this.cadastro_filme.Controls.Add(this.label1);
            this.cadastro_filme.Controls.Add(this.editar);
            this.cadastro_filme.Controls.Add(this.cadastrar);
            this.cadastro_filme.Location = new System.Drawing.Point(4, 22);
            this.cadastro_filme.Name = "cadastro_filme";
            this.cadastro_filme.Padding = new System.Windows.Forms.Padding(3);
            this.cadastro_filme.Size = new System.Drawing.Size(827, 410);
            this.cadastro_filme.TabIndex = 0;
            this.cadastro_filme.Text = "Cadastro de Filmes";
            this.cadastro_filme.UseVisualStyleBackColor = true;
            // 
            // remover
            // 
            this.remover.Location = new System.Drawing.Point(726, 377);
            this.remover.Name = "remover";
            this.remover.Size = new System.Drawing.Size(75, 23);
            this.remover.TabIndex = 6;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            this.remover.Click += new System.EventHandler(this.remover_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            listViewGroup31.Header = "Aventura";
            listViewGroup31.Name = "Aventura";
            listViewGroup32.Header = "Comédia";
            listViewGroup32.Name = "Comédia";
            listViewGroup33.Header = "Drama";
            listViewGroup33.Name = "Drama";
            listViewGroup34.Header = "Ação";
            listViewGroup34.Name = "Ação";
            listViewGroup35.Header = "Terror";
            listViewGroup35.Name = "Terror";
            listViewGroup36.Header = "Suspense";
            listViewGroup36.Name = "Suspense";
            listViewGroup37.Header = "Infantil";
            listViewGroup37.Name = "Infantil";
            listViewGroup38.Header = "Documetário";
            listViewGroup38.Name = "Documetário";
            listViewGroup39.Header = "Romance";
            listViewGroup39.Name = "Romance";
            listViewGroup40.Header = "Ficção-Científica";
            listViewGroup40.Name = "Ficção-Científica";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup31,
            listViewGroup32,
            listViewGroup33,
            listViewGroup34,
            listViewGroup35,
            listViewGroup36,
            listViewGroup37,
            listViewGroup38,
            listViewGroup39,
            listViewGroup40});
            this.listView1.Location = new System.Drawing.Point(15, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 261);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome do Filme";
            this.Nome.Width = 476;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Local";
            this.columnHeader2.Width = 213;
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(415, 70);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(385, 20);
            this.local.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Local";
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(243, 70);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(122, 20);
            this.data.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data em que foi assistido";
            // 
            // lista_genero
            // 
            this.lista_genero.FormattingEnabled = true;
            this.lista_genero.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Comédia",
            "Drama",
            "Romance",
            "Infantil",
            "Terror",
            "Suspense",
            "Documentário",
            "Ficção-Cientifica"});
            this.lista_genero.Location = new System.Drawing.Point(9, 70);
            this.lista_genero.Name = "lista_genero";
            this.lista_genero.Size = new System.Drawing.Size(205, 21);
            this.lista_genero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gênero";
            // 
            // nome_filme
            // 
            this.nome_filme.Location = new System.Drawing.Point(9, 31);
            this.nome_filme.Name = "nome_filme";
            this.nome_filme.Size = new System.Drawing.Size(792, 20);
            this.nome_filme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Filme";
            // 
            // editar
            // 
            this.editar.Enabled = false;
            this.editar.Location = new System.Drawing.Point(645, 377);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 7;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(564, 377);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 4;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // Consulta_filme
            // 
            this.Consulta_filme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Consulta_filme.Controls.Add(this.limpar_pesquisa);
            this.Consulta_filme.Controls.Add(this.listView2);
            this.Consulta_filme.Controls.Add(this.pesquisa);
            this.Consulta_filme.Controls.Add(this.pesq_local);
            this.Consulta_filme.Controls.Add(this.label5);
            this.Consulta_filme.Controls.Add(this.data_final);
            this.Consulta_filme.Controls.Add(this.data_inicial);
            this.Consulta_filme.Controls.Add(this.pesq_categoria);
            this.Consulta_filme.Controls.Add(this.ck_box_local);
            this.Consulta_filme.Controls.Add(this.ck_box_data);
            this.Consulta_filme.Controls.Add(this.ck_box_categoria);
            this.Consulta_filme.Controls.Add(this.ck_box_nome);
            this.Consulta_filme.Controls.Add(this.pesq_nome);
            this.Consulta_filme.Location = new System.Drawing.Point(4, 22);
            this.Consulta_filme.Name = "Consulta_filme";
            this.Consulta_filme.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta_filme.Size = new System.Drawing.Size(827, 410);
            this.Consulta_filme.TabIndex = 1;
            this.Consulta_filme.Text = "Consulta de Filmes";
            this.Consulta_filme.UseVisualStyleBackColor = true;
            // 
            // limpar_pesquisa
            // 
            this.limpar_pesquisa.Enabled = false;
            this.limpar_pesquisa.Location = new System.Drawing.Point(677, 39);
            this.limpar_pesquisa.Name = "limpar_pesquisa";
            this.limpar_pesquisa.Size = new System.Drawing.Size(75, 23);
            this.limpar_pesquisa.TabIndex = 12;
            this.limpar_pesquisa.Text = "Limpar";
            this.limpar_pesquisa.UseVisualStyleBackColor = true;
            this.limpar_pesquisa.Click += new System.EventHandler(this.limpar_pesquisa_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.FullRowSelect = true;
            listViewGroup21.Header = "Aventura";
            listViewGroup21.Name = "Aventura";
            listViewGroup22.Header = "Comédia";
            listViewGroup22.Name = "Comédia";
            listViewGroup23.Header = "Drama";
            listViewGroup23.Name = "Drama";
            listViewGroup24.Header = "Ação";
            listViewGroup24.Name = "Ação";
            listViewGroup25.Header = "Terror";
            listViewGroup25.Name = "Terror";
            listViewGroup26.Header = "Suspense";
            listViewGroup26.Name = "Suspense";
            listViewGroup27.Header = "Infantil";
            listViewGroup27.Name = "Infantil";
            listViewGroup28.Header = "Documetário";
            listViewGroup28.Name = "Documetário";
            listViewGroup29.Header = "Romance";
            listViewGroup29.Name = "Romance";
            listViewGroup30.Header = "Ficção-Científica";
            listViewGroup30.Name = "Ficção-Científica";
            this.listView2.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup21,
            listViewGroup22,
            listViewGroup23,
            listViewGroup24,
            listViewGroup25,
            listViewGroup26,
            listViewGroup27,
            listViewGroup28,
            listViewGroup29,
            listViewGroup30});
            this.listView2.Location = new System.Drawing.Point(32, 139);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(785, 261);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nome do Filme";
            this.columnHeader3.Width = 476;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Local";
            this.columnHeader5.Width = 213;
            // 
            // pesquisa
            // 
            this.pesquisa.Location = new System.Drawing.Point(569, 39);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(75, 23);
            this.pesquisa.TabIndex = 10;
            this.pesquisa.Text = "Pesquisa";
            this.pesquisa.UseVisualStyleBackColor = true;
            this.pesquisa.Click += new System.EventHandler(this.pesquisa_Click);
            // 
            // pesq_local
            // 
            this.pesq_local.Location = new System.Drawing.Point(97, 110);
            this.pesq_local.Name = "pesq_local";
            this.pesq_local.Size = new System.Drawing.Size(320, 20);
            this.pesq_local.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "até";
            // 
            // data_final
            // 
            this.data_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_final.Location = new System.Drawing.Point(237, 85);
            this.data_final.Name = "data_final";
            this.data_final.Size = new System.Drawing.Size(112, 20);
            this.data_final.TabIndex = 7;
            // 
            // data_inicial
            // 
            this.data_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_inicial.Location = new System.Drawing.Point(91, 85);
            this.data_inicial.Name = "data_inicial";
            this.data_inicial.Size = new System.Drawing.Size(112, 20);
            this.data_inicial.TabIndex = 6;
            // 
            // pesq_categoria
            // 
            this.pesq_categoria.FormattingEnabled = true;
            this.pesq_categoria.Location = new System.Drawing.Point(113, 60);
            this.pesq_categoria.Name = "pesq_categoria";
            this.pesq_categoria.Size = new System.Drawing.Size(258, 21);
            this.pesq_categoria.TabIndex = 5;
            // 
            // ck_box_local
            // 
            this.ck_box_local.AutoSize = true;
            this.ck_box_local.Location = new System.Drawing.Point(36, 112);
            this.ck_box_local.Name = "ck_box_local";
            this.ck_box_local.Size = new System.Drawing.Size(52, 17);
            this.ck_box_local.TabIndex = 4;
            this.ck_box_local.Text = "Local";
            this.ck_box_local.UseVisualStyleBackColor = true;
            // 
            // ck_box_data
            // 
            this.ck_box_data.AutoSize = true;
            this.ck_box_data.Location = new System.Drawing.Point(36, 87);
            this.ck_box_data.Name = "ck_box_data";
            this.ck_box_data.Size = new System.Drawing.Size(49, 17);
            this.ck_box_data.TabIndex = 3;
            this.ck_box_data.Text = "Data";
            this.ck_box_data.UseVisualStyleBackColor = true;
            // 
            // ck_box_categoria
            // 
            this.ck_box_categoria.AutoSize = true;
            this.ck_box_categoria.Location = new System.Drawing.Point(36, 62);
            this.ck_box_categoria.Name = "ck_box_categoria";
            this.ck_box_categoria.Size = new System.Drawing.Size(71, 17);
            this.ck_box_categoria.TabIndex = 2;
            this.ck_box_categoria.Text = "Categoria";
            this.ck_box_categoria.UseVisualStyleBackColor = true;
            // 
            // ck_box_nome
            // 
            this.ck_box_nome.AutoSize = true;
            this.ck_box_nome.Location = new System.Drawing.Point(36, 39);
            this.ck_box_nome.Name = "ck_box_nome";
            this.ck_box_nome.Size = new System.Drawing.Size(54, 17);
            this.ck_box_nome.TabIndex = 1;
            this.ck_box_nome.Text = "Nome";
            this.ck_box_nome.UseVisualStyleBackColor = true;
            // 
            // pesq_nome
            // 
            this.pesq_nome.Location = new System.Drawing.Point(96, 36);
            this.pesq_nome.Name = "pesq_nome";
            this.pesq_nome.Size = new System.Drawing.Size(321, 20);
            this.pesq_nome.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(853, 445);
            this.Controls.Add(this.Cad_filme);
            this.Name = "Form1";
            this.Text = "Controle de Filmes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Cad_filme.ResumeLayout(false);
            this.cadastro_filme.ResumeLayout(false);
            this.cadastro_filme.PerformLayout();
            this.Consulta_filme.ResumeLayout(false);
            this.Consulta_filme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Cad_filme;
        private System.Windows.Forms.TabPage cadastro_filme;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TabPage Consulta_filme;
        private System.Windows.Forms.ComboBox lista_genero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nome_filme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox local;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button remover;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox pesq_nome;
        private System.Windows.Forms.CheckBox ck_box_local;
        private System.Windows.Forms.CheckBox ck_box_data;
        private System.Windows.Forms.CheckBox ck_box_categoria;
        private System.Windows.Forms.CheckBox ck_box_nome;
        private System.Windows.Forms.ComboBox pesq_categoria;
        private System.Windows.Forms.DateTimePicker data_final;
        private System.Windows.Forms.DateTimePicker data_inicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pesquisa;
        private System.Windows.Forms.TextBox pesq_local;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button limpar_pesquisa;
    }
}

