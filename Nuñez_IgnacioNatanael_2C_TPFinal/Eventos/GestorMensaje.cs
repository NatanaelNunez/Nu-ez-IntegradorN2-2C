using System;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Eventos
{
    /// <summary>
    /// Clase que gestiona la presentación de mensajes.
    /// </summary>
    internal class GestorMensaje
    {
        private static Form_Mensaje formMensaje;

        /// <summary>
        /// Evento que se dispara al mostrar un mensaje.
        /// </summary>
        public static event MensajeMostradoEventHandler MensajeMostrado;

        /// <summary>
        /// Delegado del evento.
        /// </summary>
        /// <param name="sender">Objeto que desencadenó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        public delegate void MensajeMostradoEventHandler(object sender, MensajeEventArgs e);

        /// <summary>
        /// Inicializa el formulario de mensaje si aún no se ha inicializado.
        /// </summary>
        public static void InicializarFormMensaje()
        {
            if (formMensaje == null)
            {
                formMensaje = new Form_Mensaje();
            }
        }

        /// <summary>
        /// Muestra un mensaje junto con la ejecución de un proceso.
        /// </summary>
        /// <param name="proceso">Acción a ejecutar.</param>
        /// <param name="mensaje">Mensaje a mostrar.</param>
        public static void MostrarMensajeConProceso(Action proceso, string mensaje)
        {
            InicializarFormMensaje();

            // Llama al evento MensajeMostrado antes de iniciar el hilo
            MensajeMostrado?.Invoke(formMensaje, new MensajeEventArgs(mensaje));

            // Muestra el mensaje
            formMensaje.MostrarMensaje(mensaje);

            // Inicia un hilo para ejecutar el proceso
            Thread thread = new Thread(() =>
            {
                // Ejecuta el proceso
                proceso();

                // Oculta el mensaje después de completar el proceso
                OcultarMensaje();
            });

            // Inicia el hilo
            thread.Start();
        }

        /// <summary>
        /// Oculta el formulario de mensaje.
        /// </summary>
        public static void OcultarMensaje()
        {
            if (formMensaje != null)
            {
                // Oculta el formulario de mensaje en el hilo de la interfaz de usuario
                formMensaje.OcultarMensaje();
            }
        }
    }

    /// <summary>
    /// Clase para los argumentos del evento de mensaje.
    /// </summary>
    public class MensajeEventArgs : EventArgs
    {
        /// <summary>
        /// Obtiene el mensaje asociado a los argumentos del evento.
        /// </summary>
        public string Mensaje { get; }

        /// <summary>
        /// Constructor de la clase MensajeEventArgs.
        /// </summary>
        /// <param name="mensaje">Mensaje asociado a los argumentos del evento.</param>
        public MensajeEventArgs(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}