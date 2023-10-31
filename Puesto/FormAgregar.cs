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
    public partial class FormAgregar : Form
    {
        private SqlConnection connection;
        public FormAgregar()
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


        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtén la información ingresada por el usuario desde los controles de la interfaz
                string nombreProducto = txtNombreProducto.Text;
                string tamañoProducto = txtTamañoProducto.Text;
                decimal precioProducto = decimal.Parse(txtPrecioProducto.Text);

                // Abre la conexión a la base de datos
                connection.Open();

                // Crea un comando SQL para insertar el producto en la base de datos
                string insertQuery = "INSERT INTO Productos (Nombre, Tamaño, Precio) VALUES (@Nombre, @Tamaño, @Precio)";
                SqlCommand cmd = new SqlCommand(insertQuery, connection);

                // Agrega parámetros para evitar la inyección SQL
                cmd.Parameters.AddWithValue("@Nombre", nombreProducto);
                cmd.Parameters.AddWithValue("@Tamaño", tamañoProducto);
                cmd.Parameters.AddWithValue("@Precio", precioProducto);

                // Ejecuta el comando de inserción
                cmd.ExecuteNonQuery();

                // Cierra la conexión a la base de datos
                connection.Close();

                MessageBox.Show("Producto agregado exitosamente.");

                // Después de agregar el producto, actualiza el DataGridView
                CargarDatosEnDataGridView();

                txtNombreProducto.Clear();
                txtTamañoProducto.Clear();
                txtPrecioProducto.Clear();


            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}");
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
