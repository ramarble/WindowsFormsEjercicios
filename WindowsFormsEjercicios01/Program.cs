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
            UserClass.populateUserlist();
            MessageBox.Show(UserClass.getUserList().First().getName());
            MessageBox.Show(UserClass.getUserList().First().getPassword());
            ApplicationConfiguration.Initialize();
            Application.Run(new InicioSesion());
        
        }



    }
}