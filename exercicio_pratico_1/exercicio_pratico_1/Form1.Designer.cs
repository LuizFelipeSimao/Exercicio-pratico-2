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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Aventura", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Comédia", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Drama", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Ação", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Terror", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Suspense", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Infantil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Documetário", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Romance", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Ficção-Científica", System.Windows.Forms.HorizontalAlignment.Left);
            this.Cad_filme = new System.Windows.Forms.TabControl();
            this.cadastro_filme = new System.Windows.Forms.TabPage();
            this.remover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.Cad_filme.SuspendLayout();
            this.cadastro_filme.SuspendLayout();
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
            this.remover.TabIndex = 11;
            this.remover.Text = "Remover";
            this.remover.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listViewGroup1.Header = "Aventura";
            listViewGroup1.Name = "aventura";
            listViewGroup2.Header = "Comédia";
            listViewGroup2.Name = "comedia";
            listViewGroup3.Header = "Drama";
            listViewGroup3.Name = "drama";
            listViewGroup4.Header = "Ação";
            listViewGroup4.Name = "acao";
            listViewGroup5.Header = "Terror";
            listViewGroup5.Name = "terror";
            listViewGroup6.Header = "Suspense";
            listViewGroup6.Name = "suspense";
            listViewGroup7.Header = "Infantil";
            listViewGroup7.Name = "infantil";
            listViewGroup8.Header = "Documetário";
            listViewGroup8.Name = "documetario";
            listViewGroup9.Header = "Romance";
            listViewGroup9.Name = "romance";
            listViewGroup10.Header = "Ficção-Científica";
            listViewGroup10.Name = "ficçao";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.listView1.Location = new System.Drawing.Point(15, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 261);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // local
            // 
            this.local.Location = new System.Drawing.Point(415, 70);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(385, 20);
            this.local.TabIndex = 9;
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
            this.data.TabIndex = 7;
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
            this.lista_genero.TabIndex = 5;
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
            this.nome_filme.TabIndex = 3;
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
            this.editar.Location = new System.Drawing.Point(645, 377);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 1;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(564, 377);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // Consulta_filme
            // 
            this.Consulta_filme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Consulta_filme.Location = new System.Drawing.Point(4, 22);
            this.Consulta_filme.Name = "Consulta_filme";
            this.Consulta_filme.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta_filme.Size = new System.Drawing.Size(827, 410);
            this.Consulta_filme.TabIndex = 1;
            this.Consulta_filme.Text = "Consulta de Filmes";
            this.Consulta_filme.UseVisualStyleBackColor = true;
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
    }
}

