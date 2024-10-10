using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataAccessLibrary;
using buisnesLayerDml;
namespace MainForm
{
    public partial class MainForm : Form
    {

        private ProductoService productoService;
        private CategoriaService categoriaService;

        public MainForm()
        {
            InitializeComponent();
            productoService = new ProductoService();
            categoriaService = new CategoriaService();

            CargarCategorias();
            MostrarProductos();



        }

        private void CargarCategorias()
        {
            var categorias = categoriaService.ObtenerTodasLasCategorias();
            comboBoxCategorias.DataSource = categorias;
            comboBoxCategorias.DisplayMember = "Nombre";
            comboBoxCategorias.ValueMember = "CategoriaID";
        }

        private void MostrarProductos()
        {
            var productos = productoService.ObtenerTodosLosProductos();
            dataGridViewProductos.DataSource = productos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var nuevoProducto = new Producto()
                {
                    Nombre = txtNombre.Text,
                    Descripción = txtDescripción.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    CantidadEnStock = int.Parse(txtCantidad.Text),
                    CategoriaID = (int)comboBoxCategorias.SelectedValue
                };

                try
                {
                    productoService.AgregarProducto(nuevoProducto);
                    MostrarProductos(); // Refrescar la lista de productos.
                    LimpiarCampos(); // Limpiar campos después de agregar.
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al agregar el producto: {ex.Message}");
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                var idSeleccionado =
                    (int)dataGridViewProductos.CurrentRow.Cells["ProductoID"].Value;

                try
                {
                    // Llama al servicio para eliminar el registro seleccionado.
                    productoService.EliminarProducto(idSeleccionado);
                    MostrarProductos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e) => MostrarProductos();

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número válido y mayor que cero.");
                return false;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad en stock debe ser un número entero no negativo.");
                return false;
            }

            if (comboBoxCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una categoría.");
                return false;
            }

            return true; // Todos los campos son válidos
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripción.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            comboBoxCategorias.SelectedIndex = -1;
        }
    }
}

