using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class autenticador
    {
        public static usuario UsuarioActual { get; private set; }

        public static bool Login(string usuario, string contraseña)
        {
            var usuarios = repositoriousuarios.CargarUsuarios();
            var u = usuarios.FirstOrDefault(x => x.NombreUsuario == usuario && x.Contraseña == contraseña);
            if (u != null)
            {
                UsuarioActual = u;
                return true;
            }
            return false;
        }

        public static void Logout()
        {
            UsuarioActual = null;
        }
    }
}
