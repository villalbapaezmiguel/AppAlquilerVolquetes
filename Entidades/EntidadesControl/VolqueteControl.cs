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

        private static string[] listaSemanasMes = new string[]
        {
            "1:Semanas",
            "2:Semanas",
            "3:Semanas",
            "1:Mes",
            "2:Mes",
            "3:Mes",
            "4:Mes",
            "5:Mes"
        };


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


        public static bool AgregarVolquete(Volquete volquete)
        {
            if(volquete is not null)
            {
                if(!ExistePorTipoDeVolquete(volquete.TipoVolquete))
                {
                    listaVolquetes.Add(volquete);
                    ControlApp.ControlAgregarVolquete(volquete);
                    return true;
                }
            }
            return false;
        }

        public static bool ExistePorTipoDeVolquete(string marca)
        {
            bool existe = listaVolquetes.Exists(volquete => volquete.TipoVolquete == marca);
            return existe;
        }



        /// <summary>
        /// Devuelvo la lista de volquetes Sin la referencia actual de la lista original de volquetes
        /// </summary>
        public static List<Volquete> GetListaVolquetes
        {
            get
            {
                List<Volquete> nuevaLista = new();
                foreach(Volquete item in listaVolquetes) 
                { 
                    Volquete nuevo = new Volquete(item.TipoVolquete , item.Precio, item.Capacidad,item.Observacion);
                    nuevaLista.Add(nuevo);
                }            
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
        public static string[] GetSemanaMes
        {
            get
            {
                string[] nuevo = new string[listaSemanasMes.Length];
                for (int i = 0; i < listaSemanasMes.Length; i++)
                {
                    nuevo[i] = listaSemanasMes[i];
                }
                return nuevo;
            }
        }


    }
}
