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
            this.Cad_filme = new System.Windows.Forms.TabControl();
            this.cadastro_filme = new System.Windows.Forms.TabPage();
            this.Consulta_filme = new System.Windows.Forms.TabPage();
            this.cadastrar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
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
            this.cadastro_filme.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadastro_filme.Controls.Add(this.limpar);
            this.cadastro_filme.Controls.Add(this.cadastrar);
            this.cadastro_filme.Location = new System.Drawing.Point(4, 22);
            this.cadastro_filme.Name = "cadastro_filme";
            this.cadastro_filme.Padding = new System.Windows.Forms.Padding(3);
            this.cadastro_filme.Size = new System.Drawing.Size(827, 410);
            this.cadastro_filme.TabIndex = 0;
            this.cadastro_filme.Text = "Cadastro de Filmes";
            this.cadastro_filme.UseVisualStyleBackColor = true;
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
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(530, 377);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(635, 377);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 1;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Cad_filme;
        private System.Windows.Forms.TabPage cadastro_filme;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TabPage Consulta_filme;
    }
}

