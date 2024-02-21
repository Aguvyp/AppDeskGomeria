using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GomeriaPedrito
{
    public partial class frmClientes : Form
    {
        CE_Cliente ce = new CE_Cliente();
        CN_Cliente cn = new CN_Cliente();

        CE_Cliente ceElegido = new CE_Cliente();
        int clienteID;
        
        public frmClientes()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            dgvListCliente.DataSource = cn.ObtenerDatos().Tables["table"];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ce.Filtro = txtBuscarCli.Text;
            DataSet datosfiltrados = cn.FiltrarCliente(ce);
            dgvListCliente.DataSource = datosfiltrados.Tables["table"];

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCleanSearch_Click(object sender, EventArgs e)
        {
            CargarDatos();
            txtBuscarCli.Clear();
        }

        private void btnNewCli_Click(object sender, EventArgs e)
        {
            gbxClienteNew.Visible = true;
            gbxClienteNew.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ce.Nombre = txtName.Text;
            ce.Localidad = txtLocalidad.Text;
            ce.Telefono = txtTel.Text;
            ce.Vehiculo = txtCar.Text;
            ce.TrabajoRealizado = txtJob.Text;

            cn.CrearCliente(ce);

            gbxClienteNew.Visible = false;
            gbxClienteNew.Enabled = false;
            CargarDatos();

        }

        private void dgvListCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvListCliente.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Obtener el valor de la celda en la columna ID (suponiendo que la primera columna contiene el ID del cliente)
                clienteID = Convert.ToInt32(dgvListCliente.Rows[e.RowIndex].Cells["IdCliente"].Value);

                // Asignar el ID del cliente seleccionado a una variable global o a un campo del formulario
                ceElegido.IdCliente = clienteID;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ceElegido.IdCliente != 0)
            {
                // Confirmar con el usuario si realmente desea eliminar el cliente
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.OK)
                {
                    // Llamar al método para eliminar el cliente utilizando el ID almacenado
                    cn.EliminarCliente(ceElegido);

                    // Limpiar la selección
                    ceElegido.IdCliente = 0;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CargarDatos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit_Click(sender, e, cn);
        }

        private void btnEdit_Click(object sender, EventArgs e, CN_Cliente cn)
        {
            gbxDatosEdit.Visible = true;
            gbxDatosEdit.Enabled = true;

            if (clienteID != 0)
            {
                
                // Crear un objeto CE_Cliente con el ID proporcionado
                CE_Cliente clienteBuscar = new CE_Cliente();
                clienteBuscar.IdCliente = clienteID;

                // Llamar al método BuscarId para obtener el cliente
                CE_Cliente clienteEncontrado = cn.BuscarId(clienteBuscar);

                // Verificar si se encontró el cliente
                if (clienteEncontrado != null)
                {
                    // Mostrar los datos del cliente en los TextBox
                    txtNameEdit.Text = clienteEncontrado.Nombre;
                    txtLocalidadEdit.Text = clienteEncontrado.Localidad;
                    txtTelefonoEdit.Text = clienteEncontrado.Telefono;
                    txtVehiculoEdit.Text = clienteEncontrado.Vehiculo;
                    txtTrabajoEdit.Text = clienteEncontrado.TrabajoRealizado;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista clickeando su ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {

            
            gbxDatosEdit.Visible = false;
            gbxDatosEdit.Enabled = false;

            ce.Nombre = txtNameEdit.Text;
            ce.Localidad = txtLocalidadEdit.Text;
            ce.Telefono = txtTelefonoEdit.Text;
            ce.Vehiculo = txtVehiculoEdit.Text;
            ce.TrabajoRealizado = txtTrabajoEdit.Text;

            cn.EditarCliente(ce);
            CargarDatos();

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            gbxDatosEdit.Visible = false;
        }

        private void btnCancelNew_Click(object sender, EventArgs e)
        {
            gbxClienteNew.Visible = false;
        }
    }
}

