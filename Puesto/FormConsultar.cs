using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puesto
{
    public partial class FormConsultar : Form
    {
        private SqlConnection connection;
        public FormConsultar()
        {
            InitializeComponent();

            string connectionString = @"Server=DESKTOP-MH79PIJ\SQLEXPRESS;Database=Miches;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            // Llama al método para cargar los datos en el DataGridView
            CargarDatosEnDataGridView();
        }

        private void CargarDatosEnDataGridView()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM Productos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewProductos.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar datos en el DataGridView: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

