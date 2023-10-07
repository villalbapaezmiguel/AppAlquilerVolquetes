using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.EntidadesControl
{
    public sealed class VolqueteControl
    {
        private static List<Volquete> listaVolquetes = new List<Volquete>();




        public static bool AgregarVolquete(Volquete volquete)
        {
            if(volquete is not null)
            {
                if(!ExistePorElMarca(volquete.Marca))
                {
                    listaVolquetes.Add(volquete);
                    return true;
                }
            }
            return false;
        }

        public static bool ExistePorElMarca(string marca)
        {
            bool existe = listaVolquetes.Exists(volquete => volquete.Marca == marca);
            return existe;
        }



        /// <summary>
        /// Devuelvo la lista de volquetes Sin la referencia actual de la lista original de volquetes
        /// </summary>
        public List<Volquete> GetListaVolquetes
        {
            get
            {
                List<Volquete> nuevaLista = new();
                foreach(Volquete item in listaVolquetes) 
                { 
                    Volquete nuevo = new Volquete(item.Marca , item.Altura, item.Largo,item.Ancho,item.Precio,item.DiasDeArriendo);
                    nuevaLista.Add(nuevo);
                }            
                return nuevaLista;
            }
        }


    }
}
