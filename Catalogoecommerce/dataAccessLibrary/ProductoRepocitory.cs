using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectionDB;

namespace dataAccessLibrary
{
    using System.Collections.Generic;
    using MySql.Data.MySqlClient;

    public class ProductoRepository
    {
        private DatabaseConnection dbConnection;

        public ProductoRepository()
        {
            dbConnection = new DatabaseConnection("localhost", "Ecommerce", "your_username", "your_password");
        }

        // Método para insertar un nuevo producto
        public void Insertar(Producto producto)
        {
            using (var conn = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Productos (Nombre, Descripción, Precio, CantidadEnStock, CategoriaID) VALUES (@Nombre, @Descripción, @Precio, @CantidadEnStock, @CategoriaID)";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripción", producto.Descripción);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@CantidadEnStock", producto.CantidadEnStock);
                cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para actualizar un producto existente
        public void Actualizar(Producto producto)
        {
            using (var conn = dbConnection.GetConnection())
            {
                string query = "UPDATE Productos SET Nombre=@Nombre, Descripción=@Descripción, Precio=@Precio, CantidadEnStock=@CantidadEnStock, CategoriaID=@CategoriaID WHERE ProductoID=@ProductoID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Descripción", producto.Descripción);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@CantidadEnStock", producto.CantidadEnStock);
                cmd.Parameters.AddWithValue("@CategoriaID", producto.CategoriaID);
                cmd.Parameters.AddWithValue("@ProductoID", producto.ProductoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para eliminar un producto por su ID
        public void Eliminar(int productoID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                string query = "DELETE FROM Productos WHERE ProductoID=@ProductoID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Método para obtener todos los productos
        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (var conn = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Productos";
                var cmd = new MySqlCommand(query, conn);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
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

        // Método para obtener un producto por su ID
        public Producto ObtenerPorId(int productoID)
        {
            using (var conn = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Productos WHERE ProductoID=@ProductoID";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductoID", productoID);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Producto()
                        {
                            ProductoID = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Descripción = reader.GetString(2),
                            Precio = reader.GetDecimal(3),
                            CantidadEnStock = reader.GetInt32(4),
                            CategoriaID = reader.GetInt32(5)
                        };
                    }
                    else
                    {
                        return null; // No se encontró el producto
                    }
                }
            }
        }
    }
}
