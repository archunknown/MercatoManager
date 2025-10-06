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
            var txtNombres = this.Controls.Find("txtNombres", true).FirstOrDefault() as TextBox;
            var txtApellidos = this.Controls.Find("txtApellidos", true).FirstOrDefault() as TextBox;
            var txtDNI = this.Controls.Find("txtDNI", true).FirstOrDefault() as TextBox;
            var txtCelular = this.Controls.Find("txtCelular", true).FirstOrDefault() as TextBox;
            var dgv = this.Controls.Find("dgvClientes", true).FirstOrDefault() as DataGridView;

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
            dgv.DataSource = null;
            dgv.DataSource = clientes;

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
            var txtCodigo = this.Controls.Find("txtCodigo", true).FirstOrDefault() as TextBox;
            var txtNombreProd = this.Controls.Find("txtNombreProd", true).FirstOrDefault() as TextBox;
            var txtCategoria = this.Controls.Find("txtCategoria", true).FirstOrDefault() as TextBox;
            var txtPrecio = this.Controls.Find("txtPrecio", true).FirstOrDefault() as TextBox;
            var dgv = this.Controls.Find("dgvProductos", true).FirstOrDefault() as DataGridView;

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
            dgv.DataSource = null;
            dgv.DataSource = productos;

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
            var dgvClientes = this.Controls.Find("dgvClientes", true).FirstOrDefault() as DataGridView;
            var dgvProductos = this.Controls.Find("dgvProductos", true).FirstOrDefault() as DataGridView;

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
            var lblTotal = this.Controls.Find("lblTotal", true).FirstOrDefault() as Label;
            var cmb = this.Controls.Find("cmbClientes", true).FirstOrDefault() as ComboBox;
            if (cmb?.SelectedItem is Cliente selected)
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
            var cmbClientes = this.Controls.Find("cmbClientes", true).FirstOrDefault() as ComboBox;
            var cmbProductos = this.Controls.Find("cmbProductos", true).FirstOrDefault() as ComboBox;
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
            var cmbClientes = this.Controls.Find("cmbClientes", true).FirstOrDefault() as ComboBox;
            var cmbProductos = this.Controls.Find("cmbProductos", true).FirstOrDefault() as ComboBox;
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
