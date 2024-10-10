using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataAccessLibrary;
using buisnesLayerDml;

namespace buisnesLayerDml
{
    public class ProductoService
    {
        private ProductoRepository productoRepository;

        public ProductoService()
        {
            productoRepository = new ProductoRepository();
        }

        public void AgregarProducto(Producto producto)
        {
            ValidarProducto(producto);
            productoRepository.Insertar(producto);
        }

        public void ActualizarProducto(Producto producto)
        {
            if (producto.ProductoID <= 0)
                throw new ArgumentException("El ID del producto es inválido.");

            ValidarProducto(producto);
            productoRepository.Actualizar(producto);
        }

        public void EliminarProducto(int productoID)
        {
            if (productoID <= 0)
                throw new ArgumentException("El ID del producto es inválido.");

            productoRepository.Eliminar(productoID);
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return productoRepository.ObtenerTodosLosProductos();
        }

        private void ValidarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            if (producto.Precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");

            if (producto.CantidadEnStock < 0)
                throw new ArgumentException("La cantidad en stock no puede ser negativa.");

            if (producto.CategoriaID <= 0)
                throw new ArgumentException("La categoría es obligatoria.");
        }

    }
