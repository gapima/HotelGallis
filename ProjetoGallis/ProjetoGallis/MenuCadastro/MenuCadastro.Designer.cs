
namespace ProjetoGallis.MenuCadastro
{
    partial class MenuCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCadastro));
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnHospedagem = new System.Windows.Forms.Button();
            this.btnAcomodacoes = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCadQuartos = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnExcluirFu = new System.Windows.Forms.Button();
            this.btnExcluirQuartos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(410, 95);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(189, 29);
            this.btnCadastro.TabIndex = 13;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // btnHospedagem
            // 
            this.btnHospedagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedagem.Location = new System.Drawing.Point(194, 95);
            this.btnHospedagem.Margin = new System.Windows.Forms.Padding(2);
            this.btnHospedagem.Name = "btnHospedagem";
            this.btnHospedagem.Size = new System.Drawing.Size(189, 29);
            this.btnHospedagem.TabIndex = 12;
            this.btnHospedagem.Text = "Hospedagem";
            this.btnHospedagem.UseVisualStyleBackColor = false;
            // 
            // btnAcomodacoes
            // 
            this.btnAcomodacoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcomodacoes.Location = new System.Drawing.Point(1, 95);
            this.btnAcomodacoes.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcomodacoes.Name = "btnAcomodacoes";
            this.btnAcomodacoes.Size = new System.Drawing.Size(189, 29);
            this.btnAcomodacoes.TabIndex = 11;
            this.btnAcomodacoes.Text = "Acomodações";
            this.btnAcomodacoes.UseVisualStyleBackColor = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(603, 95);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(189, 29);
            this.btnRelatorio.TabIndex = 10;
            this.btnRelatorio.Text = "Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 69);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(95, 181);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(133, 23);
            this.btnCadastrarCliente.TabIndex = 14;
            this.btnCadastrarCliente.Text = "Cadastrar cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Location = new System.Drawing.Point(95, 234);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(133, 23);
            this.btnCadFuncionario.TabIndex = 15;
            this.btnCadFuncionario.Text = "Cadastrar funcionario";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadQuartos
            // 
            this.btnCadQuartos.Location = new System.Drawing.Point(95, 293);
            this.btnCadQuartos.Name = "btnCadQuartos";
            this.btnCadQuartos.Size = new System.Drawing.Size(133, 23);
            this.btnCadQuartos.TabIndex = 16;
            this.btnCadQuartos.Text = "Cadastrar quartos";
            this.btnCadQuartos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Red;
            this.btnExcluirCliente.Location = new System.Drawing.Point(503, 181);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(133, 23);
            this.btnExcluirCliente.TabIndex = 17;
            this.btnExcluirCliente.Text = "Excluir cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            // 
            // btnExcluirFu
            // 
            this.btnExcluirFu.BackColor = System.Drawing.Color.Red;
            this.btnExcluirFu.Location = new System.Drawing.Point(503, 234);
            this.btnExcluirFu.Name = "btnExcluirFu";
            this.btnExcluirFu.Size = new System.Drawing.Size(133, 23);
            this.btnExcluirFu.TabIndex = 18;
            this.btnExcluirFu.Text = "Excluir funcionario";
            this.btnExcluirFu.UseVisualStyleBackColor = false;
            this.btnExcluirFu.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExcluirQuartos
            // 
            this.btnExcluirQuartos.BackColor = System.Drawing.Color.Red;
            this.btnExcluirQuartos.Location = new System.Drawing.Point(503, 293);
            this.btnExcluirQuartos.Name = "btnExcluirQuartos";
            this.btnExcluirQuartos.Size = new System.Drawing.Size(133, 23);
            this.btnExcluirQuartos.TabIndex = 19;
            this.btnExcluirQuartos.Text = "Excluir quartos";
            this.btnExcluirQuartos.UseVisualStyleBackColor = false;
            // 
            // MenuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 406);
            this.Controls.Add(this.btnExcluirQuartos);
            this.Controls.Add(this.btnExcluirFu);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.btnCadQuartos);
            this.Controls.Add(this.btnCadFuncionario);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnHospedagem);
            this.Controls.Add(this.btnAcomodacoes);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuCadastro";
            this.Text = "MenuCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnHospedagem;
        private System.Windows.Forms.Button btnAcomodacoes;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCadFuncionario;
        private System.Windows.Forms.Button btnCadQuartos;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnExcluirFu;
        private System.Windows.Forms.Button btnExcluirQuartos;
    }
}