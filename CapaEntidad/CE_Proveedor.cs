using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono {  get; set; }
        public string Cuit {  get; set; }
        public string CondicionIVA {  get; set; }
        public CE_Producto oProducto {  get; set; }

    }
}
