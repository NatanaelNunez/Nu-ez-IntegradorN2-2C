using Entidades;

namespace Nuñez_IgnacioNatanael_2C_TPFinal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Login());
        }

        static public void mostrarPanel(int numPanel, Usuario usuarioActivo)
        {
            MessageBox.Show(usuarioActivo.nombre);
            if (numPanel == 1)
            {
            //    formInicio.Show();
            }


            /*  ApplicationConfiguration.Initialize();
              Application.Run(new Form.ControlAccessibleObject());
              Panel.sho*/

        }
    }
}