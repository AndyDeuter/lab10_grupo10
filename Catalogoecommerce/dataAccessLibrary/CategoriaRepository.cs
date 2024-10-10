using buisnesLayerDml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLibrary
{
    public class CategoriaRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Ecommerce;Integrated Security=True";

        public void Insertar(Categoria categoria)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Categorías (Nombre) VALUES (@Nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Categoria categoria)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Categorías SET Nombre=@Nombre WHERE CategoriaID=@CategoriaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@CategoriaID", categoria.CategoriaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int categoriaID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Categorías WHERE CategoriaID=@CategoriaID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoriaID", categoriaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Categoria> ObtenerTodasLasCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Categorías";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria()
                        {
                            CategoriaID = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }

            return categorias;
        }
    }

    PedidoRepository.cs
    csharp
// CapaDatos/PedidoRepository.cs
using System.Collections.Generic;
using System.Data.SqlClient;

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
