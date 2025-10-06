using MercatoManager.Models;
using System.Text.Json;
using System.IO;
using System.Linq;

namespace MercatoManager
{
    public partial class Form1 : Form
    {
        private List<Cliente> clientes = new();
        private List<Producto> productos = new();

        private const string CLIENTES_FILE = "cliente.txt";
        private const string PRODUCTOS_FILE = "producto.txt";

        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        // ===================== CLIENTES =====================
        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            if (!Cliente.ValidarDNI(txtDNI.Text))
            {
                MessageBox.Show("El DNI debe tener exactamente 8 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Cliente.ValidarCelular(txtCelular.Text))
            {
                MessageBox.Show("El celular debe tener exactamente 9 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new Cliente()
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                DNI = txtDNI.Text,
                Celular = txtCelular.Text
            };

            clientes.Add(nuevo);
            GuardarDatos(CLIENTES_FILE, clientes);
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;

            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            txtCelular.Clear();

            ActualizarTotal();
            UpdateCombos();
        }

        // ===================== PRODUCTOS =====================
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new Producto()
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombreProd.Text,
                Categoria = txtCategoria.Text,
                Precio = precio
            };

            productos.Add(nuevo);
            GuardarDatos(PRODUCTOS_FILE, productos);
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;

            txtCodigo.Clear();
            txtNombreProd.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();

            ActualizarTotal();
            UpdateCombos();
        }



        // ===================== GUARDAR / LEER ARCHIVOS =====================
        private void GuardarDatos<T>(string archivo, List<T> lista)
        {
            string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivo, json);
        }

        private void CargarDatos()
        {
            if (File.Exists(CLIENTES_FILE))
            {
                clientes = JsonSerializer.Deserialize<List<Cliente>>(File.ReadAllText(CLIENTES_FILE)) ?? new();
                dgvClientes.DataSource = clientes;
            }

            if (File.Exists(PRODUCTOS_FILE))
            {
                productos = JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText(PRODUCTOS_FILE)) ?? new();
                dgvProductos.DataSource = productos;
            }

            ActualizarTotal();
            UpdateCombos();
        }

        // ========== TOTAL ==========
        private void ActualizarTotal()
        {
            if (cmbClientes?.SelectedItem is Cliente selected)
            {
                lblTotal.Text = $"Total Gastado: S/ {selected.CalcularTotalGastado():F2}";
            }
            else
            {
                lblTotal.Text = "Total Gastado: S/ 0.00";
            }
        }

        private void UpdateCombos()
        {
            cmbClientes.DataSource = null;
            cmbClientes.DataSource = clientes;
            cmbClientes.DisplayMember = "Nombres";
            cmbProductos.DataSource = null;
            cmbProductos.DataSource = productos;
            cmbProductos.DisplayMember = "Nombre";
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem is Cliente cliente && cmbProductos.SelectedItem is Producto producto)
            {
                cliente.ProductosComprados.Add(producto);
                GuardarDatos(CLIENTES_FILE, clientes);
                ActualizarTotal();
                MessageBox.Show("Producto asignado al cliente.", "Éxito");
            }
            else
            {
                MessageBox.Show("Seleccione un cliente y un producto.", "Error");
            }
        }
    }
}
