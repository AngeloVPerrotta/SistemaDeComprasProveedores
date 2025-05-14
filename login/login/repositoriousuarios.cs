using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace login
{
   

    public static class repositoriousuarios
    {
        private const string RutaArchivo = "usuarios.csv";

        public static List<usuario> CargarUsuarios()
        {
            var usuarios = new List<usuario>();
            foreach (var linea in File.ReadAllLines(RutaArchivo))
            {
                var partes = linea.Split(';');
                var user = new usuario
                {
                    Id = int.Parse(partes[0]),
                    NombreUsuario = partes[1],
                    Contraseña = partes[2],
                    Familia = partes[3],
                    PatentesIds = partes[4].Split(',').Where(p => !string.IsNullOrWhiteSpace(p)).Select(int.Parse).ToList()
                };
                usuarios.Add(user);
            }
            return usuarios;
        }

        public static void GuardarUsuarios(List<usuario> usuarios)
        {
            var lineas = usuarios.Select(u =>
                $"{u.Id};{u.NombreUsuario};{u.Contraseña};{u.Familia};{string.Join(",", u.PatentesIds)}"
            );
            File.WriteAllLines(RutaArchivo, lineas);
        }
    }
}
