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
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private Color colorOriginalConectar;
        public Form1()
        {
            
            InitializeComponent();
            connection = new SqlConnection(Urls.connectionString);

            // Guarda el color original de btnConectar cuando se carga el formulario
            colorOriginalConectar = btnConectar.BackColor;

            btnAgregar.Enabled = false;
            btnConsultar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnPedido.Enabled = false;

            btnDesconectarme.Enabled = false;
            btnDesconectarme.BackColor = Color.Red;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = false;
            btnDesconectarme.Enabled = true;
            connection.Open();
            MessageBox.Show("Conexion ala BD:" + connection.Database + "  ha sido exitoso");
            btnConectar.BackColor = Color.Green;

            // Habilita los botones relacionados con la base de datos
            btnAgregar.Enabled = true;
            btnConsultar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnPedido.Enabled = true;

            btnDesconectarme.BackColor = colorOriginalConectar;

            
        }

        private void btnDesconectarme_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;
            btnDesconectarme.Enabled = false;
            connection.Close();
            MessageBox.Show("Se ha desconectado correctamente");
            btnDesconectarme.BackColor = Color.Red;

            // Deshabilita los botones excepto el de conectar
            btnAgregar.Enabled = false;
            btnConsultar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnPedido.Enabled = false;

            // Restaura el color original de btnConectar
            btnConectar.BackColor = colorOriginalConectar;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            FormAgregar agregarForm = new FormAgregar();
            agregarForm.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            FormConsultar consultarForm = new FormConsultar();
            consultarForm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            FormEliminar eliminarForm = new FormEliminar();
            eliminarForm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            FormModificar modificarForm = new FormModificar();
            modificarForm.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            
            FormPedido pedidoForm = new FormPedido();
            pedidoForm.Show();
        }
    }
}
