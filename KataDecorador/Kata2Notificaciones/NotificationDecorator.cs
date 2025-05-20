using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioKataIndividual.KataDecorador.Kata2Notificaciones
{
    public abstract class NotificationDecorator : Notificacion
    {
        protected Notificacion _notification;

        public NotificationDecorator(Notificacion notification)
        {
            _notification = notification;
        }

        public virtual void Send()
        {
            _notification.Send();
        }

    }
}
