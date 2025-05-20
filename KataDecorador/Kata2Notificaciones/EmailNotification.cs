using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataDecorador.Kata2Notificaciones
{
    public class EmailNotification : NotificationDecorator
    {
        public EmailNotification(Notificacion notification) : base(notification)
        {
        }
        public override void Send()
        {
            base.Send();
            Console.WriteLine("Enviando notificación por correo electrónico");
        }

    }
}
