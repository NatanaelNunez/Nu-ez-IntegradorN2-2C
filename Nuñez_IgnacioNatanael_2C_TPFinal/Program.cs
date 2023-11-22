using Entidades;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Login());
        }

        /// <summary>
        /// Muestra un panel según el número proporcionado y el usuario activo.
        /// </summary>
        /// <param name="numPanel">Número del panel a mostrar.</param>
        /// <param name="usuarioActivo">Usuario activo.</param>
        static public void MostrarPanel(int numPanel, Usuario usuarioActivo)
        {
            MessageBox.Show(usuarioActivo.Nombre);

            // Se verifica el número del panel
            if (numPanel == 1)
            {
                // Código para mostrar el primer panel
                // formInicio.Show();
            }

            /*  ApplicationConfiguration.Initialize();
                Application.Run(new Form.ControlAccessibleObject());
                Panel.sho*/
        }
    }
}
