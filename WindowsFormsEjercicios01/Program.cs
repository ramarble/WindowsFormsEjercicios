using WindowsFormsEjercicios01.Controladores;
using WindowsFormsEjercicios01.Modelos;

namespace WindowsFormsEjercicios01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {


            //debugs
            //MessageBox.Show(UserClass.getUserList().First().getName());
            //MessageBox.Show(UserClass.getUserList().First().getPassword());

            ApplicationConfiguration.Initialize();
            Application.Run(new InicioSesion());

        }



    }
}