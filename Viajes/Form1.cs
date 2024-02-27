using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viajes
{
    public partial class Form1 : Form
    {
        //string conectiongstring = "Data Source=(DESKTOP-882DQJD);Initial Catalog=DB_ZEMOG;Integrated Security=true";
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-882DQJD;Initial Catalog=DB_ZEMOG;Integrated Security=True;");
        public SqlCommand cmd;
        public string query = "SELECT * FROM Hoja1$";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_ZEMOGDataSet._Hoja1_' table. You can move, or remove it, as needed.
            this.hoja1_TableAdapter.Fill(this.dB_ZEMOGDataSet._Hoja1_);
            //con.Open();
            //cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();

            //SqlDataReader reader = cmd.ExecuteReader();
            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);
            //DG.DataSource = dataTable;

            //con.Close();
            //con.Dispose();

            MessageBox.Show("Data Source Connect");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DG.DataSource;
            bs.Filter = "Proveedor like '%"+textBox1.Text+"%'";
            DG.DataSource = bs.DataSource;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DG.DataSource;
            bs.Filter = "[Contacto comercial] like '%" + textBox2.Text + "%'";
            DG.DataSource = bs.DataSource;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            // Obtener la fecha seleccionada del DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value.Date;

            // Formatear la fecha en el formato adecuado para filtrar en la base de datos
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            // Aplicar el filtro de fecha al BindingSource
            ((BindingSource)DG.DataSource).Filter = "[Fecha de última compra] = #" + formattedDate + "#";
            //// Obtener la fecha seleccionada del DateTimePicker
            //DateTime selectedDate = dateTimePicker1.Value.Date;

            //// Formatear la fecha en el formato adecuado para filtrar en la base de datos
            //string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            //// Crear un filtro para la columna de fecha
            //string filter = string.Format("[Fecha de última compra] = #{0}#", formattedDate);

            //// Aplicar el filtro al BindingSource existente
            //((BindingSource)DG.DataSource).Filter = filter;
        }
    }
}
