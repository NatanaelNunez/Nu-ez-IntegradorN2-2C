using System;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Eventos
{
    internal class GestorMensaje
    {
        private static Form_Mensaje formMensaje;

        // Evento que se dispara al mostrar un mensaje
        public static event MensajeMostradoEventHandler MensajeMostrado;

        // Delgado del evento
        public delegate void MensajeMostradoEventHandler(object sender, MensajeEventArgs e);

        // MensajeMostrado es un evento y MensajeMostradoEventHandler es el tipo de delegado asociado a ese evento.

        public static void InicializarFormMensaje()
        {
            if (formMensaje == null)
            {
                formMensaje = new Form_Mensaje();
            }
        }

        // Este verifica si se llama al delegado para invokar al evento
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

        public static void OcultarMensaje()
        {
            if (formMensaje != null)
            {
                // Oculta el formulario de mensaje en el hilo de la interfaz de usuario
                formMensaje.OcultarMensaje();
            }
        }
    }

    // Clase para los argumentos del evento
    public class MensajeEventArgs : EventArgs
    {
        public string Mensaje { get; }

        public MensajeEventArgs(string mensaje)
        {
            Mensaje = mensaje;
        }
    }
}
