using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observador.Interfaces
{
    /// <summary>
    /// Define la estructura para los suscriptores que reaccionan a eventos.
    /// </summary>
    public interface IEscuchaEvento
    {
        /// <summary>
        /// Método que se ejecuta cuando ocurre un evento.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo afectado.</param>
        void Actualizar(string nombreArchivo);
    }
}
