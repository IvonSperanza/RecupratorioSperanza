using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecupratorioSperanza
{
    public partial class Form1 : Form
    {
        private RepositorioFactura repositorioFactura;
        private RepositorioProducto repositorioProducto;
        private RepositorioCliente repositorioCliente;
        private int numeroFactura = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RepositorioFactura facturaActual = GetCurrentOrder();
            if (facturaActual != null)
            {
                dgvFactura.Rows.Clear();
                foreach (var kvp in facturaActual.Factura)
                {
                    cbxProductoFactura.Add(kvp.Key.Nombre, kvp.Value, kvp.Key.Precio, kvp.Key.Precio * kvp.Value);

                }

                lblTotal.Text = facturaActual.Total.ToString();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFactura.AutoGenerateColumns = false;
            dgvFactura.DataSource = repositorioFactura;
        }


        private RepositorioFactura GetCurrentOrder()
        {
            if (dgvFactura.SelectedRows.Count > 0)
            {
                return (RepositorioFactura)dgvFactura.SelectedRows[0].DataBoundItem;

            }
            return null;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                Nombre = cbxNombreProducto.Text,
                Precio = decimal.Parse(cbxPrecioProducto.Text),
                Codigo = int.Parse(cbxCodigoProducto.Text),
                Cantidad = int.Parse(cbxCantidadProducto.Text)


            int Cantidad = (int)numCantidad.Value;

            if (Cantidad > 0)
            {
                var productoactual = GetCurrentOrder();
                if (productoactual.productos.ContainsKey(producto))
                {
                    productoactual.productos.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Codigo);
                    dgvFactura.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Codigo);
                    lblTotal.Text = productoactual.Total.ToString();

                }
                else
                {
                    lblCantidadProducto.Text = MessageBox.Show("La cantidad debe ser mayor que 0.");

                }
            };
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nombre = cbxNombreCliente.Text,
                Apellido = cbxApellidoCliente.Text,
                Dni = int.Parse(cbxDniCliente.Text),
                Telefono = int.Parse(cbxTelefonoCliente.Text)

            };


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (dgvFactura.RowCount > 0)
            {
                var FacturaSeleccionada = (Factura)dgvFactura.CurrentRow.DataBoundItem;
                if (FacturaSeleccionada != null)
                {
                    Factura = repositorioFactura.Eliminar(FacturaSeleccionada);
                    RefrescarGrilla();
                }
                else
                {
                    mensaje = "No hay elemntos";
                }
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No hay categorias para eliminar");
            }
        }
        private void RefrescarGrilla()
        {
            dgvFactura.DataSource = null;
            dgvFactura.DataSource = repositorioFactura.ListarFactura();

         
            cbxClienteFactura.DataSource = null;
            cbxClienteFactura.DisplayMember = "Nombre", "Apellido", Telefono, Dni;
            cbxClienteFactura.DataSource = RepositorioCliente.ListarCliente();

            cbxProductoFactura.DataSource = null;
            cbxProductoFactura.DisplayMember = "Nombre", Codigo , Precio , Cantidad;
            cbxProductoFactura.DataSource = RepositorioProducto.ListarProducto();


        }
    } }
