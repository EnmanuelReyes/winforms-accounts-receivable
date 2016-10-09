using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasPorCobrar
{
    class UsuarioService
    {
        private CXCEntities entities = new CXCEntities();

        public bool existeUsuario(string nombre, string contrasena)
        {
            try
            {
                var usuario = from em in entities.Usuario where (em.Nombre.Equals(nombre) && em.Contrasena.Equals(contrasena)) select em;
                return usuario.First() != null;
            } catch(Exception e)
            {
                return false;
            }
            
        }
    }
}
