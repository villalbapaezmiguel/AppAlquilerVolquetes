using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Entidades.EntidadesUsuarios;

namespace Entidades
{
    public sealed class ControlApp
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Volquete> listaVolquetes = new List<Volquete>();
        public static List<string> listaMarcas = new List<string>();

        public static List<string> GetMarcasVolquetesCamion
        {
            get
            {
                foreach(VolqueteCamion item in listaVolquetes)
                {
                    listaMarcas.Add(item.Marca);
                }
                return listaMarcas;
            }
        }


        public static void HarcadeoVolquetesCamion()
        {                                                   //altura        largo       ancho     Precio  Dias de arriendo      modelo   CRuedas cajaAbierta 
            listaVolquetes.Add(new VolqueteCamion("Volvo", (float)1.652, (float)4.425, (float)1.863 , (float)120000,10, "Volvo XC40",8,true));
            listaVolquetes.Add(new VolqueteCamion("Komatsu", (float)8, (float)15, (float)10 , (float)500000, 10, "Komatsu AHS", 4,true));
            listaVolquetes.Add(new VolqueteCamion("Mack", (float)11.10, (float)28, (float)9.5 , (float)80000, 18, "Mack CV713 Granite", 8,true));
            listaVolquetes.Add(new VolqueteCamion("Hitachi", (float)5, (float)8.40, (float)2.30 , (float)160000, 32,"Hitachi EH3500AC-3", 4,true));
            listaVolquetes.Add(new VolqueteCamion("Caterpillar", (float)25, (float)51, (float)22 ,(float)220000, 9 ,"82415 20", 8,true));
        }

        /// <summary>
        /// Agrega un objeto de tipo volquete a la lista de volquetes de la clase usuario
        /// </summary>
        /// <param name="volquete"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool AregarVolquete(Volquete volquete , Usuario usuario)
        {
            if(volquete is not  null && usuario is not null) 
            {
                usuario.ListaVolquete.Add(volquete);   
                return true;
            }
            return false;
        }
        /// <summary>
        /// Busca en la lista de volquetes y retorna un objeto de tipo volquete , caso contririo devuelve un null
        /// </summary>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static Volquete? EncontrarVolquetePorMarca(string marca)
        {
            foreach(Volquete item in listaVolquetes) 
            { 
                if(marca == item.Marca)
                {
                   return item;
                } 
            }
            return null;
        }

        /// <summary>
        /// Elimina un volquete de la lista de los volquetes instancia
        /// </summary>
        /// <param name="volquete"></param>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool EliminarVolquete(Volquete volquete, Usuario usuario)//verificar si funciona
        {
            if (volquete is not null && usuario is not null)
            {
                if(BuscarVolquete(volquete) is true)
                {
                    listaVolquetes.Remove(volquete);
                    return true;
                }
            }
            return true;
        }

        public static bool BuscarVolquete(Volquete volquete)
        {
            if( volquete is not null )
            {
                foreach(Volquete item in listaVolquetes)
                {
                    if(item == volquete)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Harcodeo la lista de usuarios 
        /// </summary>
        /// <returns></returns>
        public static List<Usuario> IntanciarUsuarios()
        {
            listaUsuarios.Add(new Usuario("a", "a", "Miguel", "Villalba", 21, new DateTime(2001, 12, 10)));

            return listaUsuarios;
        }
        /// <summary>
        /// Agrega un Usuario a la lista de usuarios , retorna true si se puedo agregar , caso contrario false
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static bool AgregarUsuario(Usuario usuario)
        {
            if(usuario is not null)
            {
                if(!ExisteUsuario(usuario))
                {
                    listaUsuarios.Add(usuario);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// Verifica si un usuario existe en la lista
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool ExisteUsuario(Usuario usuario)
        {
            if( usuario is not null) 
            {
                foreach(Usuario item in listaUsuarios)
                {
                    if(item == usuario)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Busca un usuario por su correo y clave , si lo encontro devuelve un objeto usuario , caso contrario retorna null
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static Usuario? EncontrarUsuarioPorCorreoYClave(string correo , string clave)
        {
            foreach(Usuario item in listaUsuarios)
            {
                if(item.Correo == correo && item.Clave == clave)
                {
                    return item;
                }
            }
            return null;
        }

    }
}
