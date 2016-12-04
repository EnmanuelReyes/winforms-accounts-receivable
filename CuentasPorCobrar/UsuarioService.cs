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

        public Usuario getUsuario(string nombre, string contrasena)
        {
            try
            {
                var usuario = from em in entities.Usuario where (em.Nombre.Equals(nombre) && em.Contrasena.Equals(contrasena)) select em;
                return usuario.First();
            } catch(Exception e)
            {
                return null;
            }
            
        }

        public bool tieneRol(Usuario user, string rol)
        {
            try
            {
                //var usuario = from em in entities.Usuario where (em.Rol.Nombre)
                //var usuario = from em in entities.Usuario where (em..Equals(nombre) && em.Contrasena.Equals(contrasena)) select em;
                return null != null;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
