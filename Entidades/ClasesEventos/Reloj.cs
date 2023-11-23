using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ClasesEventos
{
    public class Reloj
    {
        int hora;
        int minuto;
        int segundo;

        public delegate void NoficadorCambioTiempo(Reloj reloj);
        public event NoficadorCambioTiempo segundoCambio;

        public void Iniciar()
        {
            //lo ejecutamos en un hilo secundario un bucle infinito 
            Task.Run(() =>
            {
                while(true)
                {
                    DateTime dateTime = DateTime.Now;
                    Thread.Sleep(100);

                    if(dateTime.Second != segundo)
                    {
                        if(segundoCambio is not null)
                        {
                            segundoCambio.Invoke(this);
                        }

                    }
                    hora = dateTime.Hour;
                    minuto = dateTime.Minute;
                    segundo = dateTime.Second;

                }

            });
        }

        public override string ToString()
        {
            return $"{hora}:{minuto}:{segundo}";

        }
    }
}
