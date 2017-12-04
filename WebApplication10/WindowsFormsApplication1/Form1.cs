using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lugaresDataSet.lugares' Puede moverla o quitarla según sea necesario.
            this.lugaresTableAdapter.Fill(this.lugaresDataSet.lugares);

        }
        private DataTable CargarProductosDT()//muestra de datos
        {
            try
            {
                WebApplication10.lugare obc = new WebApplication10.lugare();
                string donde = dataGridView1.ToString();
                string muestra = obc.Nombreestado.ToString();
                DataTable dt = new DataTable();
                using (SqlConnection cnn = new SqlConnection("Data Source=(local); Initial Catalog=Escuela-Poo;Integrated Security=True"))
                {
                    cnn.Open();
                    string ConsultaProductos = "SELECT id, no_control, nombre, apellido_paterno, apellido_materno,edad,semestre FROM alumnos";
                    SqlCommand cmd = new SqlCommand(ConsultaProductos, cnn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebApplication10.lugare obj = new WebApplication10.lugare();
            string variable1 = obj.Nombreestado;
            string textbox1 = txtnombrelugar.Text;
            textbox1 = variable1;
            dataGridView1.Rows.Add(textbox1);

           DataTable dt = new DataTable();
            DataRow Row1;
            //DataRow Row2;
            dt.Columns.Add(new DataColumn("Nombreestado", System.Type.GetType("System.String")));

            Row1 = dt.NewRow();
            Row1["Nombreestado"] = this.txtnombrelugar.Text;

            dt.Rows.Add(Row1);
            dataGridView1.DataSource = dt;
        }
    }
}
