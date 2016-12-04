using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class TransaccionService
    {
        private CXCEntities entities = new CXCEntities();

        public IEnumerable searchByCriteria(string criteria)
        {
            try
            {
                var transactions = from em in entities.Transaccion.Include("Cliente").Include("TipoMovimiento") where (em.Cliente.Nombre.Contains(criteria) ||
                                   em.IdTransaccion.ToString().Contains(criteria) || 
                                   em.Monto.ToString().Contains(criteria) ||
                                   em.TipoDocumento.Descripcion.Contains(criteria) ||
                                   em.TipoMovimiento.Descripcion.Contains(criteria)) select em;
                return transactions.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
