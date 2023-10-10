using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesControl;
using Entidades.EntidadesUsuarios;

namespace Entidades
{
    public sealed class ControlApp
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Volquete> listaVolquetes = new List<Volquete>();
        


        public static void HarcodeoUsuariosYVolquetes()
        {
            UsuarioControl.AgregarUsuario(new Usuario("a", "a", 1234, "Miguel", "Villalba", 23451));

            VolqueteControl.AgregarVolquete(new Volquete("Pequeño",10000,(float)1.5,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Mediano",15000, (float)3,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Estandar",25000, (float)6,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Grande",30000, (float)10,"Todo tipo de materiales"));
            VolqueteControl.AgregarVolquete(new Volquete("Super Grande",40000, (float)12,"Todo tipo de materiales"));
        }



    }
}
