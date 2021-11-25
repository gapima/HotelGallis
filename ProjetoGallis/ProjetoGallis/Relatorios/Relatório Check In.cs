using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGallis.Relatórios
{
    public partial class Relatório_Check_In : Form
    {
        public Relatório_Check_In()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Relatório_Check_In
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Relatório_Check_In";
            this.Load += new System.EventHandler(this.Relatório_Check_In_Load);
            this.ResumeLayout(false);

        }

        private void Relatório_Check_In_Load(object sender, EventArgs e)
        {

        }
    }
}
