using Entidades.EntidadesBD;
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

        private static string[] listaHorarios = new string[]
        {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
        };

        public static Volquete? EncontrarVolquetePorTipo(string volquetePorTipo)
        {
            if(!(volquetePorTipo == string.Empty)) 
            {
                foreach(Volquete item in GetListaVolquetes)
                {
                    if(item.TipoVolquete == volquetePorTipo) 
                    {
                        return item;
                    }
                } 
            }
            return null;
        }


        /// <summary>
        /// Devuelvo la lista de volquetes Sin la referencia actual de la lista original de volquetes
        /// </summary>
        public static List<Volquete> GetListaVolquetes
        {
            get
            {
                List<Volquete> nuevaLista = VolqueteBD.LeerDB();

                return nuevaLista;
            }
        }

        public static string[] GetHorarios
        {
            get
            {
                string[] nuevo = new string[listaHorarios.Length];
                for (int i = 0; i < listaHorarios.Length; i++)
                {
                    nuevo[i] = listaHorarios[i];
                }
                return nuevo;
            }
        }


    }
}
