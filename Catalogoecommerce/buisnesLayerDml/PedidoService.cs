using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnesLayerDml
{
    public class PedidoService
    {
        private PedidoRepository pedidoRepository;

        public PedidoService()
        {
            pedidoRepository = new PedidoRepository();
        }

        public void AgregarPedido(Pedido pedido)
        {
            // Validaciones
            ValidarPedido(pedido);

            // Llamar al repositorio para insertar el pedido
            pedidoRepository.Insertar(pedido);
        }

        public List<Pedido> ObtenerTodosLosPedidos()
        {
            return pedidoRepository.ObtenerTodosLosPedidos();
        }

        private void ValidarPedido(Pedido pedido)
        {
            if (pedido.ProductoID <= 0)
                throw new ArgumentException("El ID del producto es obligatorio.");

            if (pedido.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");

            // Puedes agregar más validaciones si es necesario.

            // Aquí podrías verificar si el producto existe y si hay suficiente stock.
            // Esto requeriría acceso a la lógica de negocio del Producto.
            var productoService = new ProductoService();
            var productos = productoService.ObtenerTodosLosProductos();
            var producto = productos.Find(p => p.ProductoID == pedido.ProductoID);
            if (producto == null || producto.CantidadEnStock < pedido.Cantidad)
                throw new InvalidOperationException("No hay suficiente stock para realizar el pedido.");

            // Si todo está bien, puedes continuar.
        }
    }
}
