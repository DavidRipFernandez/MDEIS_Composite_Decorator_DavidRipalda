using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataDecorador.Kata2Notificaciones
{
    public class BasicNotificacion : Notificacion
    {
        public void Send()
        {
            Console.WriteLine("Enviando notificación básica");
        }
    }
}
