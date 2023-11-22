using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Nuñez_IgnacioNatanael_2C_TPFinal.Eventos
{
    internal class GestorMensaje
    {
            private static Form_Mensaje formMensaje;

            public static void InicializarFormMensaje()
            {
                if (formMensaje == null)
                {
                    formMensaje = new Form_Mensaje();
                }
            }

            public static void MostrarMensajeConProceso(Action proceso, string mensaje)
            {
                InicializarFormMensaje();

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
}
