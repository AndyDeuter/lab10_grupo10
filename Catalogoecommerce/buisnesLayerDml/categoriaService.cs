using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnesLayerDml
{
    public class CategoriaService
    {
        private CategoriaRepository categoriaRepository;

        public CategoriaService()
        {
            categoriaRepository = new CategoriaRepository();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            ValidarCategoria(categoria);

            categoriaRepository.Insertar(categoria);
        }

        public void ActualizarCategoria(Categoria categoria)
        {
            if (categoria.CategoriaID <= 0)
                throw new ArgumentException("El ID de la categoría es inválido.");

            ValidarCategoria(categoria);

            categoriaRepository.Actualizar(categoria);
        }

        public void EliminarCategoria(int categoriaID)
        {
            if (categoriaID <= 0)
                throw new ArgumentException("El ID de la categoría es inválido.");

            categoriaRepository.Eliminar(categoriaID);
        }

        public List<Categoria> ObtenerTodasLasCategorias()
        {
            return categoriaRepository.ObtenerTodasLasCategorias();
        }

        private void ValidarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

        }
    }
}
