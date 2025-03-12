using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// <summary>
    /// Suscriptor que envía una notificación por correo cuando ocurre un evento.
    /// </summary>
    public class NotificacionCorreo : IEscuchaEvento
    {
        private string correo;
        private string mensaje;

        public NotificacionCorreo(string correo, string mensaje)
        {
            this.correo = correo;
            this.mensaje = mensaje;
        }

        /// <summary>
        /// Simula el envío de un correo electrónico cuando ocurre un evento.
        /// </summary>
        public void Actualizar(string nombreArchivo)
        {
            Console.WriteLine($"Enviando correo a {correo}: {mensaje.Replace("%s", nombreArchivo)}");
        }
    }
}
