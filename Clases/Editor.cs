using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// <summary>
    /// Representa un editor de archivos que genera eventos al abrir o guardar archivos.
    /// </summary>
    public class Editor
    {
        public GestorEventos Eventos { get; } = new();
        private string archivo;

        /// <summary>
        /// Simula la apertura de un archivo y notifica a los suscriptores.
        /// </summary>
        public void AbrirArchivo(string ruta)
        {
            archivo = ruta;
            Eventos.Notificar("abrir", archivo);
        }

        /// <summary>
        /// Simula el guardado de un archivo y notifica a los suscriptores.
        /// </summary>
        public void GuardarArchivo()
        {
            File.WriteAllText(archivo, "Contenido actualizado...");
            Eventos.Notificar("guardar", archivo);
        }
    }
}
