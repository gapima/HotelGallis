﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoGallis.Apresentacao;

namespace ProjetoGallis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //EsqueceuSenha esqueceuSenha = new EsqueceuSenha();
            //esqueceuSenha.Show();
        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            EsqueceuSenha esqueciSenha = new EsqueceuSenha();
            esqueciSenha.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
