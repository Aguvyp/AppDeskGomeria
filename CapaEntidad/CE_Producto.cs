using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Codigo {  get; set; }
        public CE_Categoria oCategoria { get; set; }
        public double Precio {  get; set; }
         
    }
}
