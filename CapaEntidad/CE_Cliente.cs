using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set;}
        public string Vehiculo { get; set;}
        public string TrabajoRealizado { get; set;}
        public string Filtro { get; set; }
        public CE_Producto oProducto { get; set; }
        
    }
}
