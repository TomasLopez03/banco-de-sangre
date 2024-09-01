using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class ver_donantes : Form
    {
        private string connectionString = "Server=localhost;Database=banco;User=root;Password=Luci2357;";     
            
            
        public ver_donantes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            cargar_dondante(txtdni.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ver_donantes_Load(object sender, EventArgs e)
        {

        }

        private void cargar_dondante(string filtro = "")
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select nombre,apellido,dni,celular,sexo,celular,calle,numero,tipo from donante a inner join sangre b on a.idsangre = b.id ";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    this.dataGridView1.DataSource = table;

                    if (filtro != "")
                    {
                        query += "where" + " dni like '" +filtro+"%'";
                    }
                    adapter = new MySqlDataAdapter(query, connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    this.dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de Conexion" + ex.Message);
                }
            };
        }

    }
}
