using System;
using System.Collections;
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
            return entities.Usuario.Where(x => x.Nombre == nombre && x.Contrasena == contrasena).FirstOrDefault() ?? null;
        }        

        public bool tieneRol(Usuario user, string rol)
        {
            var usuario = getUsuario(user.Nombre, user.Contrasena);
            if (user != null)
            {
                var rl = entities.Rol.Where(x => x.Nombre == rol).FirstOrDefault();
                return rl != null ? true : false;
            }
            return false;
        }
    }
}
