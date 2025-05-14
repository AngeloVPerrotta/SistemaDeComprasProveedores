using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Familia { get; set; } // Administrador, SuperUsuario, etc.
        public List<int> PatentesIds { get; set; } = new List<int>();

    }
}
