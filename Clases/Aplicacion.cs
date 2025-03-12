using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// <summary>
    /// Configura la aplicación y registra los suscriptores.
    /// </summary>
    public class Aplicacion
    {
        public void Configurar()
        {
            Editor editor = new Editor();

            var registro = new RegistroEventos("log.txt", "Se ha abierto el archivo: %s");
            editor.Eventos.Suscribir("abrir", registro);

            var alertaCorreo = new NotificacionCorreo("admin@example.com", "Se ha guardado el archivo: %s");
            editor.Eventos.Suscribir("guardar", alertaCorreo);

            editor.AbrirArchivo("documento.txt");
            editor.GuardarArchivo();
        }
    }
}
