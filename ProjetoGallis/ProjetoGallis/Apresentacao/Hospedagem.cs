using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoGallis.Apresentacao
{



    public partial class Hospedagem : Form
    {
        DataTable dt = new DataTable();
        //private object dataGridView;

        public Hospedagem()
        {
            InitializeComponent();
            CarregarDados();
        }


        private void CarregarDados()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Agendamento", typeof(string));
            dt.Columns.Add("Data entrada", typeof(string));
            dt.Columns.Add("Data saída", typeof(string));
            dt.Columns.Add("CPF", typeof(int));
            dt.Columns.Add("N°", typeof(int));

            dt.Rows.Add(new object[] { "" });
            dataGridView1.DataSource = dt;

        }





        private void btnHospedagem_Click(object sender, EventArgs e)
        {

        }

        private void btnAcomodacoes_Click(object sender, EventArgs e)
        {

        }

        private void Hospedagem_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //dt = btnBuscar.GetDados(txtProcurar.Text);
            //dataGridView1.DataSource = dt;
            

        }
        //public static DataTable GetData(string procurar = "")
        //{
        //    //var dt = new DataTable();
        //    //var sql = "SELECT ID, Dataentrada, Datasaida, FROM checkin";
        //    //if(procurar != "")
        //    //{
        //    //    sql += "Where titulo LIKE '%" + procurar + "%' OR";
        //    //}
        //}
        
      
   
    }
}
    
