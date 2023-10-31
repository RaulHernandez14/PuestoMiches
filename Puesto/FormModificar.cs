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
    public partial class FormModificar : Form
    {
        private SqlConnection connection;
        public FormModificar()
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén la información ingresada por el usuario desde los controles de la interfaz
                string nombreProductoModificar = txtNombreProductoModificar.Text;
                string nuevoNombreProducto = txtNuevoNombreProducto.Text;
                string nuevoTamañoProducto = txtNuevoTamañoProducto.Text;
                decimal nuevoPrecioProducto = decimal.Parse(txtNuevoPrecioProducto.Text);

                // Abre la conexión a la base de datos
                connection.Open();

                // Crea un comando SQL para actualizar los datos del producto en la base de datos
                string updateQuery = "UPDATE Productos SET Nombre = @NuevoNombre, Tamaño = @NuevoTamaño, Precio = @NuevoPrecio WHERE Nombre = @NombreModificar";
                SqlCommand cmd = new SqlCommand(updateQuery, connection);

                // Agrega parámetros para evitar la inyección SQL
                cmd.Parameters.AddWithValue("@NuevoNombre", nuevoNombreProducto);
                cmd.Parameters.AddWithValue("@NuevoTamaño", nuevoTamañoProducto);
                cmd.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecioProducto);
                cmd.Parameters.AddWithValue("@NombreModificar", nombreProductoModificar);

                // Ejecuta el comando de actualización
                int rowsAffected = cmd.ExecuteNonQuery();

                // Cierra la conexión a la base de datos
                connection.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cambios realizados correctamente.");
                    // Después de modificar el producto, actualiza el DataGridView
                    CargarDatosEnDataGridView();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el nombre proporcionado.");
                }

                txtNombreProductoModificar.Clear();
                txtNuevoNombreProducto.Clear();
                txtNuevoTamañoProducto.Clear();
                txtNuevoPrecioProducto.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al modificar producto: {ex.Message}");
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
