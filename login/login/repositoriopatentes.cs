using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace login
{
    public static class repositoriopatentes
    {
        private const string RutaArchivo = "patentes.csv";

        public static List<patente> CargarPatentes()
        {
            return File.ReadAllLines(RutaArchivo)
                .Select(l => l.Split(';'))
                .Select(p => new patente { Id = int.Parse(p[0]), Nombre = p[1] })
                .ToList();
        }
    }
}
