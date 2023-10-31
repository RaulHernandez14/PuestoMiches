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
    public partial class FormEliminar : Form
    {
        private SqlConnection connection;

        public FormEliminar()
        {
            InitializeComponent();
            string connectionString = @"Server=DESKTOP-MH79PIJ\SQLEXPRESS;Database=Miches;Integrated Security=True";
            connection = new SqlConnection(connectionString);

            CargarDatosEnDataGridView();
        }

        
        private void CargarDatosEnDataGridView()
        {
            if (connection.State != ConnectionState.Open)
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifica si hay una fila seleccionada en el DataGridView
                if (dataGridViewProductos.SelectedRows.Count > 0)
                {
                    // Obtiene el nombre del producto de la fila seleccionada
                    string nombreProducto = dataGridViewProductos.SelectedRows[0].Cells["Nombre"].Value.ToString();

                    // Abre la conexión a la base de datos
                    connection.Open();

                    // Crea un comando SQL para eliminar el producto en la base de datos por nombre
                    string deleteQuery = "DELETE FROM Productos WHERE Nombre = @Nombre";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                    // Agrega el parámetro para el nombre del producto que se va a eliminar
                    cmd.Parameters.AddWithValue("@Nombre", nombreProducto);

                    // Ejecuta el comando de eliminación
                    cmd.ExecuteNonQuery();

                    // Cierra la conexión a la base de datos
                    connection.Close();

                    MessageBox.Show($"Producto '{nombreProducto}' eliminado exitosamente.");

                    // Después de eliminar el producto, actualiza el DataGridView
                    CargarDatosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar un producto.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al eliminar producto: {ex.Message}");
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
