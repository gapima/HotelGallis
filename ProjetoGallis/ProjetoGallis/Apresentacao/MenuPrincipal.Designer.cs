﻿
namespace ProjetoGallis.Apresentacao
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAcomodacoes = new System.Windows.Forms.Button();
            this.btnHospedagem = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 85);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(781, 103);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(252, 36);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // btnAcomodacoes
            // 
            this.btnAcomodacoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcomodacoes.Location = new System.Drawing.Point(-2, 103);
            this.btnAcomodacoes.Name = "btnAcomodacoes";
            this.btnAcomodacoes.Size = new System.Drawing.Size(252, 36);
            this.btnAcomodacoes.TabIndex = 6;
            this.btnAcomodacoes.Text = "Acomodações";
            this.btnAcomodacoes.UseVisualStyleBackColor = false;
            this.btnAcomodacoes.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnHospedagem
            // 
            this.btnHospedagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedagem.Location = new System.Drawing.Point(256, 103);
            this.btnHospedagem.Name = "btnHospedagem";
            this.btnHospedagem.Size = new System.Drawing.Size(252, 36);
            this.btnHospedagem.TabIndex = 7;
            this.btnHospedagem.Text = "Hospedagem";
            this.btnHospedagem.UseVisualStyleBackColor = false;
            this.btnHospedagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(523, 103);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(252, 36);
            this.btnCadastro.TabIndex = 8;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1034, 536);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnHospedagem);
            this.Controls.Add(this.btnAcomodacoes);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAcomodacoes;
        private System.Windows.Forms.Button btnHospedagem;
        private System.Windows.Forms.Button btnCadastro;
    }
}