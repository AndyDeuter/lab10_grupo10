using buisnesLayerDml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLibrary
{
    public class PedidoRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Ecommerce;Integrated Security=True";

        public void Insertar(Pedido pedido)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Pedidos (FechaPedido, ProductoID, Cantidad) VALUES (@FechaPedido, @ProductoID, @Cantidad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);
                cmd.Parameters.AddWithValue("@ProductoID", pedido.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Pedido> ObtenerTodosLosPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Pedidos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pedidos.Add(new Pedido()
                        {
                            PedidoID = reader.GetInt32(0),
                            FechaPedido = reader.GetDateTime(1),
                            ProductoID = reader.GetInt32(2),
                            Cantidad = reader.GetInt32(3)
                        });
                    }
                }
            }

            return pedidos;
        }
    }
}
