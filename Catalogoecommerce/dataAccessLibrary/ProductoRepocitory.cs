using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLibrary
{
    public class ProductoRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Ecommerce;Integrated Security=True";

        public void Insertar(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Productos (Nombre, Descripción, Precio, CantidadEnStock, CategoriaID) VALUES (@Nombre, @Descripción, @Precio, @CantidadEnStock, @CategoriaID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripción", producto.Descripción);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@CantidadEnStock", producto.CantidadEnStock);
                cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Productos SET Nombre=@Nombre, Descripción=@Descripción, Precio=@Precio, CantidadEnStock=@CantidadEnStock WHERE ProductoID=@ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripción", producto.Descripción);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@CantidadEnStock", producto.CantidadEnStock);
                cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int productoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Productos WHERE ProductoID=@ProductoID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto()
                        {
                            ProductoID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripción = reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                            CantidadEnStock = reader.GetInt32(4),
                            CategoriaID = reader.GetInt32(5)
                        });
                    }
                }
            }

            return productos;
        }
    }
