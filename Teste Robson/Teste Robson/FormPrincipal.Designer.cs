namespace Teste_Robson
{
    partial class FormPrincipal
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
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.buttonDialogo = new System.Windows.Forms.Button();
            this.listViewResultado = new System.Windows.Forms.ListView();
            this.textBoxDiretorio = new System.Windows.Forms.TextBox();
            this.labelDiretorio = new System.Windows.Forms.Label();
            this.textBoxExtensao = new System.Windows.Forms.TextBox();
            this.labelExtensao = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Controls.Add(this.progressBar);
            this.groupBoxPrincipal.Controls.Add(this.buttonStart);
            this.groupBoxPrincipal.Controls.Add(this.labelExtensao);
            this.groupBoxPrincipal.Controls.Add(this.textBoxExtensao);
            this.groupBoxPrincipal.Controls.Add(this.labelDiretorio);
            this.groupBoxPrincipal.Controls.Add(this.textBoxDiretorio);
            this.groupBoxPrincipal.Controls.Add(this.listViewResultado);
            this.groupBoxPrincipal.Controls.Add(this.buttonDialogo);
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(464, 310);
            this.groupBoxPrincipal.TabIndex = 0;
            this.groupBoxPrincipal.TabStop = false;
            // 
            // buttonDialogo
            // 
            this.buttonDialogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDialogo.Location = new System.Drawing.Point(422, 31);
            this.buttonDialogo.Name = "buttonDialogo";
            this.buttonDialogo.Size = new System.Drawing.Size(33, 23);
            this.buttonDialogo.TabIndex = 2;
            this.buttonDialogo.Text = "...";
            this.buttonDialogo.UseVisualStyleBackColor = true;
            this.buttonDialogo.Click += new System.EventHandler(this.buttonDialogo_Click);
            // 
            // listViewResultado
            // 
            this.listViewResultado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderTamanho});
            this.listViewResultado.FullRowSelect = true;
            this.listViewResultado.GridLines = true;
            this.listViewResultado.Location = new System.Drawing.Point(6, 127);
            this.listViewResultado.Name = "listViewResultado";
            this.listViewResultado.Size = new System.Drawing.Size(449, 177);
            this.listViewResultado.TabIndex = 7;
            this.listViewResultado.UseCompatibleStateImageBehavior = false;
            this.listViewResultado.View = System.Windows.Forms.View.Details;
            // 
            // textBoxDiretorio
            // 
            this.textBoxDiretorio.Location = new System.Drawing.Point(6, 33);
            this.textBoxDiretorio.Name = "textBoxDiretorio";
            this.textBoxDiretorio.Size = new System.Drawing.Size(410, 20);
            this.textBoxDiretorio.TabIndex = 1;
            // 
            // labelDiretorio
            // 
            this.labelDiretorio.AutoSize = true;
            this.labelDiretorio.Location = new System.Drawing.Point(3, 17);
            this.labelDiretorio.Name = "labelDiretorio";
            this.labelDiretorio.Size = new System.Drawing.Size(159, 13);
            this.labelDiretorio.TabIndex = 0;
            this.labelDiretorio.Text = "Informe a pasta para verificação";
            // 
            // textBoxExtensao
            // 
            this.textBoxExtensao.Location = new System.Drawing.Point(6, 72);
            this.textBoxExtensao.Name = "textBoxExtensao";
            this.textBoxExtensao.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtensao.TabIndex = 4;
            // 
            // labelExtensao
            // 
            this.labelExtensao.AutoSize = true;
            this.labelExtensao.Location = new System.Drawing.Point(3, 56);
            this.labelExtensao.Name = "labelExtensao";
            this.labelExtensao.Size = new System.Drawing.Size(222, 13);
            this.labelExtensao.TabIndex = 3;
            this.labelExtensao.Text = "Informa a extensão do arquivo (Exemplo(.jpg))";
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Location = new System.Drawing.Point(6, 98);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(87, 98);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(368, 23);
            this.progressBar.TabIndex = 6;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            // 
            // columnHeaderTamanho
            // 
            this.columnHeaderTamanho.Text = "Tamanho";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 334);
            this.Controls.Add(this.groupBoxPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.groupBoxPrincipal.ResumeLayout(false);
            this.groupBoxPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelExtensao;
        private System.Windows.Forms.TextBox textBoxExtensao;
        private System.Windows.Forms.Label labelDiretorio;
        private System.Windows.Forms.TextBox textBoxDiretorio;
        private System.Windows.Forms.ListView listViewResultado;
        private System.Windows.Forms.Button buttonDialogo;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderTamanho;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

