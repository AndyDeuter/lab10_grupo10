using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buisnesLayerDml
{
    public class Producto
    {
      
            public int ProductoID { get; set; }         
            public string Nombre { get; set; }           
            public string Descripción { get; set; }      
            public decimal Precio { get; set; }          
            public int CantidadEnStock { get; set; }    
            public int CategoriaID { get; set; }       
    }
}
