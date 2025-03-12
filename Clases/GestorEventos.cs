using Observador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Clases
{
    /// <summary>
    /// Administra la suscripción y notificación de eventos.
    /// </summary>
    public class GestorEventos
    {
        private Dictionary<string, List<IEscuchaEvento>> suscriptores = new();

        /// <summary>
        /// Suscribe un oyente a un evento específico.
        /// </summary>
        public void Suscribir(string tipoEvento, IEscuchaEvento oyente)
        {
            if (!suscriptores.ContainsKey(tipoEvento))
                suscriptores[tipoEvento] = new List<IEscuchaEvento>();

            suscriptores[tipoEvento].Add(oyente);
        }

        /// <summary>
        /// Elimina la suscripción de un oyente a un evento.
        /// </summary>
        public void Desuscribir(string tipoEvento, IEscuchaEvento oyente)
        {
            if (suscriptores.ContainsKey(tipoEvento))
                suscriptores[tipoEvento].Remove(oyente);
        }

        /// <summary>
        /// Notifica a los oyentes cuando ocurre un evento.
        /// </summary>
        public void Notificar(string tipoEvento, string nombreArchivo)
        {
            if (suscriptores.ContainsKey(tipoEvento))
            {
                foreach (var oyente in suscriptores[tipoEvento])
                    oyente.Actualizar(nombreArchivo);
            }
        }
    }
}
