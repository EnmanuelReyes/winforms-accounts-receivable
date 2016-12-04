using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    public class TransacccionDTO
    {
        public int IdTransaccion { get; set; }
        public string NumeroDocumento { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Monto { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoMovimiento { get; set; }

    }
}
