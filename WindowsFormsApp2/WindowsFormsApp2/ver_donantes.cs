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
        //variable con las caracteristicas de la base de datos 
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
        //funcion para mostrar los donantes
        private void cargar_dondante(string filtro = "")
        {
            //se instancia la clase MySqlConnection
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    //el metodo Open() abre la conexion a la base de datos
                    connection.Open();
                    //se define la consulta la cual traera los datos deseados
                    string query = "select nombre,apellido,dni,celular,sexo,celular,calle,numero,tipo from donante a inner join sangre b on a.idsangre = b.id ";
                    
                    if (filtro != "")
                    {
                        //se modifica la consulta constantemente segun lo que ingresa el usuario
                        query += "where" + " dni like '" +filtro+"%'";
                    }
                    //se intancia la clase MySqlDataAdapter para ejecutar la consulta
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    //se crea un objeto tabla
                    DataTable table = new DataTable();
                    //se cargan los registros obtenidos de la base de datos en el objeto tabla
                    adapter.Fill(table);
                    //se muestran los datos en el datagridview
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
