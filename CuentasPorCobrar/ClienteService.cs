using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class ClienteService
    {
        private CXCEntities entities = new CXCEntities();

        public static bool ValidaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0 && !pCedula.Equals("00000000000"))
                return true;
            else
                return false;
        }

        public bool PermiteTransaccion(decimal montoTransaccion, int tipoMovimiento, int clienteId)
        {
            try
            {
                var cliente = from em in entities.Cliente where (em.IdCliente.Equals(clienteId)) select em;
                Cliente clienteFromDb = cliente.First();
                if(tipoMovimiento == 1)
                {
                    return clienteFromDb.LimiteDeCredito - montoTransaccion < 0;
                }
                return true;
            }
            catch (Exception ignored)
            {
                return true;
            } 
        }

        public void ActualizaBalance(decimal montoTransaccion, int tipoMovimiento, int clienteId)
        {
            try
            {
                var cliente = from em in entities.Cliente where (em.IdCliente.Equals(clienteId)) select em;
                Cliente clienteFromDb = cliente.First();
                switch (tipoMovimiento)
                {
                    case 1:
                        clienteFromDb.LimiteDeCredito -= montoTransaccion;
                        break;
                    case 2:
                        clienteFromDb.LimiteDeCredito += montoTransaccion;
                        break;  

                }
                int num = entities.SaveChanges();

            }
            catch (Exception e)
            {
            }
        }

        public IEnumerable<Cliente> searchByCriteria(string criteria)
        {
            try
            {
                var clients = from em in entities.Cliente
                              where (em.Nombre.Contains(criteria) ||
                               em.Cedula.ToString().Contains(criteria) ||
                               em.LimiteDeCredito.ToString().Contains(criteria) ||
                               em.IdCliente.ToString().Contains(criteria))
                              select em;
                return clients.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public List<Cliente> getClientes()
        {
            return (List<Cliente>)from em in entities.Cliente.ToList() select em;

        }
    }
}
